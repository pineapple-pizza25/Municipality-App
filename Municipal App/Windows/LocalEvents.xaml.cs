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
        Queue<Event> EventStack = new();
        HashSet<string> UserSearches = new();
        HashSet<Event> RecommendedEvents = new();
        HashSet<string> CategoriesSet = new();

        public LocalEvents()
        {
            InitializeComponent();

            InitialiseDictionary();
            LoadEvents();
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            Window win = new MainWindow();
            win.Show();
            this.Hide();
        }

        private void InitialiseDictionary()
        {
            Events.Add("2024-10-20_Beach_Marathon", new Event("Beach Marathon", "North Beach", new DateOnly(2024, 10, 20), new TimeOnly(7, 0), "Sports"));
            Events.Add("2024-10-31_Halloween_Party", new Event("Halloween Party", "Suncoast", new DateOnly(2024, 10, 31), new TimeOnly(20, 0), "Holiday"));
            Events.Add("2024-11-10_Beach_Clean_up", new Event("Beach Clean up", "North Beach", new DateOnly(2024, 11, 10), new TimeOnly(9, 0), "Community"));
            Events.Add("2024-11-29_Soccer_Match", new Event("Soccer Match", "Moses Mabida Stadium", new DateOnly(2024, 11, 29), new TimeOnly(15, 30), "Sports"));
            Events.Add("2024-12-01_Bech_Festival", new Event("Bech Festival", "Point", new DateOnly(2024, 12, 01), new TimeOnly(11, 0), "Culture"));
            Events.Add("2025-12-10_Music_Festival", new Event("Music Festival", "Varsity College", new DateOnly(2025, 12, 10), new TimeOnly(18, 0), "Entertainment"));
            Events.Add("2025-12-14_Rugby_Match", new Event("Rugby Match", "Kingsmead Stadium", new DateOnly(2025, 12, 14), new TimeOnly(17, 0), "Sports"));
            Events.Add("2025-12-25_Christmas_Party", new Event("Christmas Party", "Blue Lagoon", new DateOnly(2025, 12, 25), new TimeOnly(14, 0), "Holiday"));
            Events.Add("2025-12-31_New_Years_Celebration", new Event("New Years Celebration", "North Beach", new DateOnly(2025, 12, 31), new TimeOnly(20, 0), "Holiday"));
            Events.Add("2024-11-05_Town_Hall_Meeting", new Event("Town Hall Meeting", "Community Center", new DateOnly(2024, 11, 05), new TimeOnly(18, 0), "Announcement"));
            Events.Add("2024-11-15_Volunteer_Registration", new Event("Volunteer Registration", "City Hall", new DateOnly(2024, 11, 15), new TimeOnly(10, 0), "Announcement"));
            Events.Add("2024-12-10_City_Council_Elections", new Event("City Council Elections", "City Hall", new DateOnly(2024, 12, 10), new TimeOnly(8, 0), "Announcement"));
            Events.Add("2024-12-20_New_Year_Prep", new Event("New Year Preparation Meeting", "Town Square", new DateOnly(2024, 12, 20), new TimeOnly(17, 0), "Announcement"));

            InitialiseCategoriesHash();
        }

        private void InitialiseCategoriesHash()
        {
            foreach (Event localEvent in Events.Values)
            {
                CategoriesSet.Add(localEvent.Category);
            }

            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cmbCategory.ItemsSource = CategoriesSet;
        }

        private void LoadEvents()
        {
            InitialisStack();

            for (int i = 0; i < 3; i++)
            {
                Event localEvent = EventStack.Dequeue();

                Label eventLabel = new Label()
                {

                    Content = $"{localEvent.Category}\n" +
                    $"{localEvent.Name}",
                    Foreground = Brushes.Black,
                    FontSize = 14,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,


                };

                eventLabel.MouseLeftButtonDown += (sender, e) =>
                {
                    Console.WriteLine($"Button clicked for event: {localEvent.Name}");
                    PopulateDetailsStackPanel(localEvent);
                };


                Border border = new Border
                {
                    Child = eventLabel,
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
                EventStack.Enqueue(item);
            }
        }

        private HashSet<Event> Search(string searchValue)
        {
            return new HashSet<Event>(Events.Values.Where(e => e.Name.Contains(searchValue, StringComparison.OrdinalIgnoreCase)));
        }

        private HashSet<Event> SearchByCategory(string searchValue)
        {
            return new HashSet<Event>(Events.Values.Where(e => e.Category.Contains(searchValue, StringComparison.OrdinalIgnoreCase)));
        }

        private void GetRecommeneded()
        {
            if (UserSearches == null) return;

            foreach (string search in UserSearches)
            {
                if (Events == null) return;

                RecommendedEvents.Add(Events.Values.FirstOrDefault(e => e.Name.Contains(search, StringComparison.OrdinalIgnoreCase)));
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchValue = txtSearch.Text;

            HashSet<Event> searchedEvents = Search(searchValue);

            if (searchedEvents.Count != 0)
            {
                UserSearches.Add(searchValue);
            }

            PopulateStackPanel(searchedEvents);

        }

        private void PopulateStackPanel(HashSet<Event> eventHash)
        {
            spEvents.Children.Clear();

            foreach (Event localEvent in eventHash)
            {
                Label eventLabel = new Label()
                {

                        Content = $"{localEvent.Category}\n" +
                        $"{localEvent.Name}",
                        Foreground = Brushes.Black,
                        FontSize = 14,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,

                    
                };

                eventLabel.MouseLeftButtonDown += (sender, e) =>
                {
                    Console.WriteLine($"Button clicked for event: {localEvent.Name}");
                    PopulateDetailsStackPanel(localEvent);
                };


                Border border = new Border
                {
                    Child = eventLabel,
                    BorderBrush = Brushes.Black,
                    BorderThickness = new Thickness(2),
                    Background = Brushes.LightCyan,
                    Padding = new Thickness(5),
                    Margin = new Thickness(10)
                };


                spEvents.Children.Add(border);
            }
        }


        //https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/how-to-use-the-image-element?view=netframeworkdesktop-4.8
        public void PopulateDetailsStackPanel(Event localEvent)
        {
            spEventDetails.Children.Clear();

            Image myImage = new Image();
            myImage.Height = 200;
            myImage.Width = 200;

            BitmapImage myBitmapImage = new BitmapImage();

            myBitmapImage.BeginInit();

            if (localEvent.Category == "Announcement")
            {
                myBitmapImage.UriSource = new Uri("pack://application:,,,/Images/announcement.jpg", UriKind.Absolute);
            }
            else
            {
                myBitmapImage.UriSource = new Uri("pack://application:,,,/Images/events.jpg", UriKind.RelativeOrAbsolute); 
            }

            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();
            myImage.Source = myBitmapImage;

            TextBlock eventName = new()
            {
                Text = $" {localEvent.Name} ",
                FontSize = 20,
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            TextBlock eventDetails = new()
            {
                Text = $"Date: {localEvent.EventDate} \nTime: {localEvent.EventTime}"+
                $"\nLocation: {localEvent.Location}" ,
                FontSize = 16,
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            spEventDetails.Children.Add(myImage);
            spEventDetails.Children.Add(eventName);
            spEventDetails.Children.Add(eventDetails);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            GetRecommeneded();

            spEvents.Children.Clear();

            TextBlock headingBlock = new TextBlock()
            {
                Text = $"Recommended Events",
                Foreground = Brushes.Black,
                FontSize = 14,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            Border headingBorder = new Border
            {
                Child = headingBlock,
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(2),
                Background = Brushes.LightCyan,
                Padding = new Thickness(5),
                Margin = new Thickness(10)
            };


            spEvents.Children.Add(headingBorder);

            foreach (Event localEvent in RecommendedEvents)
            {
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

        private void btnFilterCategory_Click(object sender, RoutedEventArgs e)
        {
            string searchValue = cmbCategory.Text;

            if (searchValue == null || searchValue == "") return;

            HashSet<Event> searchedEvents =  SearchByCategory(searchValue);

            PopulateStackPanel(searchedEvents);
        }
    }
}
