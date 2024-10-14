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

        Dictionary<string, Event> Events = new();
        Stack<Event> EventStack = new();

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
            Events.Add("2024-10-20_Beach_Marathon", new Event("Beach Marathon", "North Beach", new DateOnly(2024, 10, 20), new TimeOnly(7, 0)));
            Events.Add("2024-10-31_Halloween_Party", new Event("Halloween Party", "Suncoast", new DateOnly(2024, 10, 31), new TimeOnly(20, 0)));
            Events.Add("2024-11-10_Beach_Clean_up", new Event("Beach Clean up", "North Beach", new DateOnly(2024, 11, 10), new TimeOnly(9, 0)));
            Events.Add("2024-11-29_Soccer_Match", new Event("Soccer Match", "Moses Mabida Stadium", new DateOnly(2024, 11, 29), new TimeOnly(15, 30)));
            Events.Add("2024-12-01_Bech_Festival", new Event("Bech Festival", "Point", new DateOnly(2024, 12, 01), new TimeOnly(11, 0)));
            Events.Add("2025-12-10_Music_Festival", new Event("Music Festival", "Varsity College", new DateOnly(2025, 12, 10), new TimeOnly(18, 0)));
            Events.Add("2025-12-14_Rugby_Match", new Event("Rugby Match", "Kingsmead Stadium", new DateOnly(2025, 12, 14), new TimeOnly(17, 0)));
            Events.Add("2025-12-25_Christmas_Party", new Event("Christmas Party", "Blue Lagoon", new DateOnly(2025, 12, 25), new TimeOnly(14, 0)));
            Events.Add("2025-12-31_New_Years_Celebration", new Event("New Years Celebration", "North Beach", new DateOnly(2025, 12, 31), new TimeOnly(20, 0)));

        }

        private void LoadEvents()
        {
            InitialisStack();

            for (int i = 0; i < 3; i++)
            {
                Event localEvent = EventStack.Pop();

                TextBlock textBlock = new TextBlock()
                {
                    Text = $"Join us for {localEvent.Name} on {localEvent.EventDate:MMMM dd, yyyy}\n" +
                    $"At {localEvent.Location}",
                    Foreground = Brushes.Black,
                    FontSize = 14,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };

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

        private void InitialisStack()
        {
            foreach (var item in Events.Values)
            {
                EventStack.Push(item);
            }
        }

        private IEnumerable<Event> Search(string searchValue)
        {
            return Events.Values.Where(e => e.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase));
        }

        private void GetRecommeneded()
        {
            //TODO
        }
    }
}
