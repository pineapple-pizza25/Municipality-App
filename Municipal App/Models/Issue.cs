using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Municipal_App
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public BitmapImage? Image { get; set; }
        public string Status { get; set; } = "pending";
        public int Priority { get; set; } = 1;

        public Issue(string location, string category, string description)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
        }

        public Issue(string location, string category, string description, int priority)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
            this.Priority = priority;
        }

        public Issue(string location, string category, string description, BitmapImage image)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
            this.Image = image;
        }

        public Issue(string location, string category, string description, BitmapImage image, int priority)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
            this.Image = image;
            this.Priority = priority;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}";
        }
    }
}
