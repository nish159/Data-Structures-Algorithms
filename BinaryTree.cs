using System;

public class Node
{
    public int value { get; set; }
    public Node? left;
    public Node? right;
}

public class BinaryTree
{
    // want to keep the root private to control the root 
    private Node? root;

    /// <summary>
    /// Prints the value of the nodes in the tree in order
    /// </summary>
    public void PrintInOrder()
    {
        PrintInOrder(root);
    }

    /// <summary>
    /// Inserts a given value into the tree
    /// </summary>
    /// <param name="value"></param>
    private void Insert(int value)
    {
        // Is the root null!!!

    }

    private void PrintInOrder(Node? node)
    {
        if(node.left == null)
        {
            Console.Write(node.value + " ");
            return;
        }
        
        PrintInOrder(node.left); // Print the left subtree
        // Every node in the left sub-tree has been printed

        Console.Write(node.value + " "); // Print out the value in the current node

        PrintInOrder(node.right); // Print the right subtree
        // Every node in the right sub-tree has been printer
    }
}
