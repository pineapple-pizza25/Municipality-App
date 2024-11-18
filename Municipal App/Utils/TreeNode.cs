using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_App.Utils
{
    public class TreeNode<T>
    {
        //Title: Binding a WPF ComboBox to a custom list
        //Author: alc_aardvark
        //Date: 6 September 2012
        //Availabilty: https://www.codeproject.com/Articles/345191/Simple-Generic-Tree

        public T Data { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T data)
        {
            Data = data;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }
}
