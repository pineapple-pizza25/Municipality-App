using Municipal_App.Utils;
using System;
using System.Collections.Generic;
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

namespace Municipal_App.Windows
{
    /// <summary>
    /// Interaction logic for RequestStatusWindow.xaml
    /// </summary>
    public partial class RequestStatusWindow : Window
    {
        Tree<object> tree = TreeService<object>.Instance();

        public RequestStatusWindow()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Hide();
        }

        private void DisplayIssues()
        {
            var dept2Nodes = new List<TreeNode<Issue>>();

            tree.GetNodesAtDepth(tree.Root, 2, 0, dept2Nodes);

            foreach (var node in dept2Nodes)
            {
                Issue issue = node.Data;

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


                spIssues.Children.Add(border);
            }

        }

    }
}
