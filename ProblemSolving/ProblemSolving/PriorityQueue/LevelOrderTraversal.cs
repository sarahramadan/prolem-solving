using ProblemSolving.QueueAndStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.PriorityQueue;

public class LevelOrderTraversal
{
    public void LevelOrderTraversalUsingRecersion(TreeNode? currentNode,int level,List<List<int>> result)
    {
        if (currentNode == null) return;
        if(result.Count <= level)
        {
            result.Add(new List<int>());
        }

        result[level].Add(currentNode.val);

        LevelOrderTraversalUsingRecersion(currentNode?.left, level + 1, result);
        LevelOrderTraversalUsingRecersion(currentNode?.right, level + 1, result);
    }
    public List<List<int>>  LevelOrderTraversalUsingQueue(TreeNode currentNode)
    {
        List<List<int>> result= new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(currentNode == null) return result;
        queue.Enqueue(currentNode);
        while(queue.Count > 0)
        {
            int n = queue.Count;

            var subLevel = new List<int> ();
            for (int i = 0; i < n; i++)
            {
                var node = queue.Dequeue();
                subLevel.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(subLevel);
        }
        return result;

    }
    public List<List<int>> levelOrder(TreeNode node)
    {
        List<List<int>> result = new List<List<int>>();
        LevelOrderTraversalUsingRecersion(node, 0, result);
        return result;
    }
    public void Run()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(3);
        root.right = new TreeNode(2);
        root.right.right = new TreeNode(4);
        root.right.right.left = new TreeNode(6);
        root.right.right.right = new TreeNode(5);

        // Perform level order traversal
        List<List<int>> res = levelOrder(root);

        // Print the result
        foreach (List<int> level in res)
        {
            foreach (int data in level)
            {
                Console.Write(data + " ");
            }
        }
    }
    public void Run2()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(3);
        root.right = new TreeNode(2);
        root.right.right = new TreeNode(4);
        root.right.right.left = new TreeNode(6);
        root.right.right.right = new TreeNode(5);

        // Perform level order traversal
        List<List<int>> res = LevelOrderTraversalUsingQueue(root);

        // Print the result
        foreach (List<int> level in res)
        {
            foreach (int data in level)
            {
                Console.Write(data + " ");
            }
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
