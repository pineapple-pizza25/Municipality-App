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
using Microsoft.Toolkit.Uwp.Notifications;
using Notification.Wpf;

namespace Municipal_App.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly NotificationManager __NotificationManager = new();

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

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            LocalEvents win = new();
            win.Show();
            this.Hide();
        }


        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            NotificationsWindow win = new NotificationsWindow();
            win.Show();
            this.Hide();
        }



        public void ShowFailureNotification(NotificationManager notificationManager)
        {
            notificationManager.Show("Under Construction", $"This feature has not been implemented yet", NotificationType.Information);
        }
    }
}