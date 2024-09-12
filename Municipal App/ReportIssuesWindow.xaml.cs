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
using Microsoft.Win32;
using Color = System.Drawing.Color;
//using Color = System.Windows.Media.Color;

namespace Municipal_App
{
    /// <summary>
    /// Interaction logic for ReportIssuesWindow.xaml
    /// </summary>
    public partial class ReportIssuesWindow : Window
    {
        public static List<Issue> issues = new List<Issue>();

        static BitmapImage selectedImage;


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
                return;
            }

            if (selectedImage == null)
            {
                issues.Add(new Issue(location, category, description));
            }
            else
            {
                issues.Add(new Issue(location, category, description, selectedImage));
            }

            lblFeedback.Background = new SolidColorBrush(Colors.Black);
            lblFeedback.Foreground = new SolidColorBrush(Colors.Green);
            lblFeedback.Content = "Your issue was saved successfully";
        }

        private string ConvertRichTextBoxContentsToString(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            return textRange.Text;
        }

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
