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

namespace Municipal_App
{
    /// <summary>
    /// Interaction logic for ReportIssuesWindow.xaml
    /// </summary>
    public partial class ReportIssuesWindow : Window
    {
        public static List<Issue> issues = new List<Issue>();

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

            issues.Add(new Issue(location, category, description));
        }

        private string ConvertRichTextBoxContentsToString(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            return textRange.Text;
        }
    }


    //https://stackoverflow.com/questions/561166/binding-a-wpf-combobox-to-a-custom-list
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
