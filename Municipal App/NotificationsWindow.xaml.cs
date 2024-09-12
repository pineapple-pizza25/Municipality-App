using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Municipal_App
{
    /// <summary>
    /// Interaction logic for NotificationsWindow.xaml
    /// </summary>
    public partial class NotificationsWindow : Window
    {
        public NotificationsWindow()
        {
            InitializeComponent();

            foreach (Issue issue in ReportIssuesWindow.issues)
            {
                TextBlock textBlock = new TextBlock()
                {
                    Text = "You successfully reported an issue regarding " +
                     issue.Category + " at " + issue.Location,
                    Foreground = Brushes.Black,
                    FontSize = 14,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                Border border = new Border
                {
                    Child = textBlock,
                    BorderBrush = Brushes.Blue,
                    BorderThickness = new Thickness(2),
                    Background = Brushes.LightCyan,
                    Padding = new Thickness(5),
                    Margin = new Thickness(10)
                };


                spNotifications.Children.Add(border);
            }
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Hide();
        }
    }
}
