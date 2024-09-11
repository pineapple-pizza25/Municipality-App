using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_App
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Issue(string location, string category, string description)
        {
            this.Location = location;
            this.Category = category;
            this.Description = description;
        }
    }
}
