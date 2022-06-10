using System;


BinaryTree tree = new BinaryTree();
tree.Insert(6);
tree.PrintInOrder();
tree.Insert(4);
tree.PrintInOrder();
tree.Insert(7);
tree.PrintInOrder();
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

    public void Insert(int value)
    {
        if (root == null)
        {
            Node? newNode = new Node();
            newNode.value = value;
            root = newNode;
        }
        else
        {
            Insert(root, value);
        }
    }

    /// <summary>
    /// Inserts a given value into the tree
    /// </summary>
    /// <param name="value"></param>
    private void Insert(Node? node, int value)
    {
        // Is the root null!!!
        Node? newNode = new Node();
        newNode.value = value;

        if (node == null /* if the list is empty*/)
        {
            node = newNode;
        }
        else if (value < node.value /* if the value is less than the node value*/)
        {
            Insert(node.left, value);
        }
        else if (value > node.value /* if the value is greater than the node value*/)
        {
            Insert(node.right, value);
        }
    }

    private void PrintInOrder(Node? node)
    {
        if(node == null)
        {
            return;
        }
        if (node.left == null)
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
