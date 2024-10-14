using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Municipal_App.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public BitmapImage? Image { get; set; }

        public Event(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public Event(string name, string location, BitmapImage image)
        {
            Name = name;
            Location = location;
            Image = image;
        }

        
    }
}
