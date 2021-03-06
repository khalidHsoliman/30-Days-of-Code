﻿using System;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class Solution
{
    // Not needed 
    static int cardinality(Node root)
    {
        if (root == null)
            return 0; 

        return 1 + cardinality(root.right) + cardinality(root.left); 
    }

    static int getHeight(Node root)
    {
        if (root == null)
            return -1;

        int leftHeight  = getHeight(root.left);
        int rightHeight = getHeight(root.right); 

        return 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }

            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }

            return root;
        }
    }

    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }

        int height = getHeight(root);
        Console.WriteLine(height);

        Console.ReadKey();
    }
}