using Municipal_App.Models;
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
    public partial class LocalEvents : Window
    {

        Dictionary<DateOnly, Event> Events = new();

        public LocalEvents()
        {
            InitializeComponent();

            InitialiseDictionary();
            LoadEvents();
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void InitialiseDictionary()
        {
            Events.Add(new DateOnly(2024, 10, 20), new Event("Beach Marathon", "North Beach"));
            Events.Add(new DateOnly(2024, 10, 31), new Event("Halloween Party", "Suncoast"));
            Events.Add(new DateOnly(2024, 11, 10), new Event("Beach Clean up", "North Beach"));
            Events.Add(new DateOnly(2024, 11, 29), new Event("Soccer Match", "Moses Mabida Stadium"));
        }

        private void LoadEvents()
        {
            foreach (var localEvent in Events)
            {
                TextBlock textBlock = new TextBlock()
                {
                    Text = $"Join us for {localEvent.Value.Name} on {localEvent.Key:MMMM dd, yyyy}\n" +
                    $"At {localEvent.Value.Location}",
                    Foreground = Brushes.Black,
                    FontSize = 14,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

                Image image = new Image();

                Border border = new Border
                {
                    Child = textBlock,
                    BorderBrush = Brushes.Black,
                    BorderThickness = new Thickness(2),
                    Background = Brushes.LightCyan,
                    Padding = new Thickness(5),
                    Margin = new Thickness(10)
                };


                spEvents.Children.Add(border);
            }

        }
    }
}
