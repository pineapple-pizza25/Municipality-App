using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Municipal_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            ReportIssuesWindow win = new ReportIssuesWindow();
            win.Show();
            this.Hide();
        }

        private void btnNotifications_Click(object sender, RoutedEventArgs e)
        {
            NotificationsWindow win = new NotificationsWindow();
            win.Show();
            this.Hide();
        }
    }
}