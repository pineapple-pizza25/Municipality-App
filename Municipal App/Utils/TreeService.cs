using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_App.Utils
{
    class TreeService<T>
    {

        //Title: Singleton Design Pattern in C# - Do it THAT way
        //Author: tutorialsEU - C#
        //Date: 24 November 2022
        //Availabilty: https://www.youtube.com/watch?v=r6Y0SmbufmU&t=614s

        private TreeService() { }

        private static Tree<object> _instance;
        private static readonly object _lock = new object();
        public static Tree<object> Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Tree<object>(default);
                        var category = new TreeNode<object>("Electricity");
                        var category2 = new TreeNode<object>("Water");
                        var category3 = new TreeNode<object>("Roads");
                        var category4 = new TreeNode<object>("Sanitation");
                        var category5 = new TreeNode<object>("Other");
                        _instance.Root.AddChild(category);
                        _instance.Root.AddChild(category2);
                        _instance.Root.AddChild(category3);
                        _instance.Root.AddChild(category4);
                        _instance.Root.AddChild(category5);
                    }
                }
            }

            return _instance;
        }

    }
}
