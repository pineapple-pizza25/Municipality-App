using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_App.Utils
{
    public class Tree<T>
    {
        //Title: Binding a WPF ComboBox to a custom list
        //Author: alc_aardvark
        //Date: 6 September 2012
        //Availabilty: https://www.codeproject.com/Articles/345191/Simple-Generic-Tree


        public TreeNode<T> Root { get; set; }

        public Tree(T rootData)
        {
            Root = new TreeNode<T>(rootData);
        }

        public void Traverse(TreeNode<T> node, Action<T> action)
        {
            if (node == null) return;
            action(node.Data);
            foreach (var child in node.Children)
            {
                Traverse(child, action);
            }
        }

        public TreeNode<T> FindNode(TreeNode<T> node, T target)
        {
            if (node == null) return null;

            if (node.Data != null && node.Data.Equals(target))
            {
                return node;
            }

            foreach (var child in node.Children)
            {
                var result = FindNode(child, target);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }

        public bool AddChildToNode(T target, T childData)
        {
            var targetNode = FindNode(Root, target);
            if (targetNode != null)
            {
                var childNode = new TreeNode<T>(childData);
                targetNode.AddChild(childNode);
                return true;
            }

            return false; 
        }

        //returns all nodes at a specific dept
        public void GetNodesAtDepth<TChild>(TreeNode<T> node, int targetDepth, int currentDepth, List<TreeNode<TChild>> result)
        {
            if (node == null) return;

            if (currentDepth == targetDepth && node.Data is TChild childData)
            {
                result.Add(new TreeNode<TChild>(childData));
                return;
            }

            foreach (var child in node.Children)
            {
                GetNodesAtDepth(child, targetDepth, currentDepth + 1, result);
            }
        }
    }
}
