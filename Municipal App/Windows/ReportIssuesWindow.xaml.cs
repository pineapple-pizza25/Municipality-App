using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;
using System.Threading;
using Notification.Wpf;
using Microsoft.Win32;
using Color = System.Drawing.Color;
using Microsoft.Toolkit.Uwp.Notifications;
using Municipal_App.Utils;
using System.Diagnostics;
//using Color = System.Windows.Media.Color;

namespace Municipal_App.Windows
{
    /// <summary>
    /// Interaction logic for ReportIssuesWindow.xaml
    /// </summary>
    public partial class ReportIssuesWindow : Window
    {
        Tree<object> tree = TreeService<object>.Instance();

        public static List<Issue> issues = new List<Issue>();

        //List used for notifictions
        public static List<Issue> notifications = new List<Issue>();

        static BitmapImage selectedImage;

        private static readonly NotificationManager __NotificationManager = new();

        public ReportIssuesWindow()
        {
            InitializeComponent();

            ConnectionViewModel vm = new ConnectionViewModel();
            DataContext = vm;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            string location = txtLocation.Text;
            string category = cmbCategory.Text;
            string description = ConvertRichTextBoxContentsToString(rtbDetails);

            if (location == "" || category == "" || description == "")
            {
                lblFeedback.Background = new SolidColorBrush(Colors.Black);
                lblFeedback.Foreground = new SolidColorBrush(Colors.Red);
                lblFeedback.Content = "Please enter all fields";

                ShowFailureNotification(new NotificationManager());
                return;
            }

            if (selectedImage == null)
            {
                //issues.Add(new Issue(location, category, description));
                tree.AddChildToNode(category, new Issue(location, category, description));
                CheckTree();

                issues.Add(new Issue(location, category, description));
                notifications.Add(new Issue(location, category, description));
            }
            else
            {
                tree.AddChildToNode(category, new Issue(location, category, description, selectedImage));
                issues.Add(new Issue(location, category, description, selectedImage));
                notifications.Add(new Issue(location, category, description, selectedImage));
            }

            ShowProgressbar(new NotificationManager());

            lblFeedback.Background = new SolidColorBrush(Colors.Black);
            lblFeedback.Foreground = new SolidColorBrush(Colors.Green);
            lblFeedback.Content = "Your issue was saved successfully";

            ShowSuccessNotification(new NotificationManager());
            ClearComponents();
        }

        /*
         * Converts the contents of a richTextBox to a string
         */
        private string ConvertRichTextBoxContentsToString(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            return textRange.Text;
        }

        /*
         * Select an Image from your files
         */
        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            //Title: display image into picturebox in c# windows application 4.6
            //Author: Haritha Computers and Technology
            //Date published: 31 May 2018
            //Available: https://www.youtube.com/watch?v=prfTc0SzjwE
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (ofd.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(ofd.FileName));
                ivPicture.Source = selectedImage;
            }
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Hide();
        }


        //check values in tree
        private void CheckTree()
        {
            tree.Traverse(tree.Root, data =>
            {
                System.Diagnostics.Trace.WriteLine(data);
            });
        }


        /*
         * Used to show the user a popup notification 
         * on their desktop
         * 
         * Title: Notifications.wpf/Documentation.md
         * Author: Platonenkov
         * Year published: 2022
         * Availability: https://github.com/Platonenkov/Notification.Wpf/blob/dev/Documentation.md#-notifications
         */
        public void ShowSuccessNotification(NotificationManager notificationManager)
        {
            string Category = cmbCategory.Text;
            notificationManager.Show("Issue Reported", $"Your issue regarding {Category} was saved successfully", NotificationType.Success);
        }
        public void ShowFailureNotification(NotificationManager notificationManager)
        {
            string Category = cmbCategory.Text;
            notificationManager.Show("Fields Empty", $"Please enter all fields", NotificationType.Error);
        }



        /*
         * Used to show the user a progress bar
         * 
         * Title: Notifications.wpf/Documentation.md
         * Author: Platonenkov
         * Year published: 2022
         * Availability: https://github.com/Platonenkov/Notification.Wpf/blob/dev/Documentation.md#-notifications
         */
        private async void ShowProgressbar(NotificationManager notificationManager)
        {
            using var progress = notificationManager.ShowProgressBar();
            for (var i = 0; i <= 100; i++)
            {
                progress.Cancel.ThrowIfCancellationRequested();
                progress.Report((i, $"Progress {i}", "With progress", true));
                await Task.Delay(TimeSpan.FromSeconds(0.02), progress.Cancel).ConfigureAwait(false);
            }
        }

        /*
         * Clears components
         */
        public void ClearComponents()
        {
            txtLocation.Clear();
            cmbCategory.Text = "";
            rtbDetails.Document.Blocks.Clear();
        }
    }

    //Title: Binding a WPF ComboBox to a custom list
    //Author: Kjetil Watnedal
    //Date: 18 February 2009
    //Availabilty: https://stackoverflow.com/questions/561166/binding-a-wpf-combobox-to-a-custom-list
    public class ConnectionViewModel : INotifyPropertyChanged
    {
        public ConnectionViewModel()
        {
            var categories = new List<Category>();
            categories.Add(new Category() { Name = "Roads", Value = "Roads" });
            categories.Add(new Category() { Name = "Water", Value = "Water" });
            categories.Add(new Category() { Name = "Electricity", Value = "Electricity" });
            categories.Add(new Category() { Name = "Sanitaion", Value = "Sanitaion" });
            categories.Add(new Category() { Name = "Other", Value = "Other" });
            _categories = new CollectionView(categories);
        }

        private readonly CollectionView _categories;
        private string _category;

        public CollectionView Categories
        {
            get { return _categories; }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                if (_category == value) return;
                _category = value;
                OnPropertyChanged("Category");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
