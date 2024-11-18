using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_App.Utils
{
    public class Tree<T>
    {
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








        // Method to find a node
        public TreeNode<T> FindNode(TreeNode<T> node, T target)
        {
            if (node == null) return null;

            // Check if the current node matches the target
            if (node.Data != null && node.Data.Equals(target))
            {
                return node;
            }

            // Recursively search through children
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

        // Method to add a child to a target node
        public bool AddChildToNode(T target, T childData)
        {
            // Find the target node
            var targetNode = FindNode(Root, target);
            if (targetNode != null)
            {
                // Add the new child
                var childNode = new TreeNode<T>(childData);
                targetNode.AddChild(childNode);
                return true; // Successfully added
            }

            return false; // Node not found
        }

        public void GetNodesAtDepth<TChild>(TreeNode<T> node, int targetDepth, int currentDepth, List<TreeNode<TChild>> result)
        {
            if (node == null) return;

            // If the target depth is reached, check if the node contains the desired type
            if (currentDepth == targetDepth && node.Data is TChild childData)
            {
                result.Add(new TreeNode<TChild>(childData));
                return;
            }

            // Recursively traverse the children
            foreach (var child in node.Children)
            {
                GetNodesAtDepth(child, targetDepth, currentDepth + 1, result);
            }
        }
    }
}
