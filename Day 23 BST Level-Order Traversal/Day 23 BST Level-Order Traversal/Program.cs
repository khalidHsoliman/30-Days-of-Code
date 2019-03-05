using System;

// Tree node
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

class Tree
{
    private Node root;

    Queue<Node> queue = new Queue<Node>();

    public Tree()
    {
        Root = null; 
    }

    public Tree(Node root)
    {
        Root = root;
    }


    internal Node Root { get => root; private set => root = value; }


    // Create tree statically with no object, recursively
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (root == null)
            root = newNode;
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if (data < current.data)
                {
                    current = current.left;
                    if (current == null)
                    {
                        parent.left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.right;
                    if (current == null)
                    {
                        parent.right = newNode;
                        return;
                    }
                }
            }
        }
    }


    //--------------------------------
    // Traversal 
    //--------------------------------
    // root-left-right
    // DFS
    public void Preorder(Node Root)
    {
        if (Root != null)
        {
            Console.Write(Root.data + " ");
            Preorder(Root.left);
            Preorder(Root.right);
        }
    }

    // left-root-right
    public void Inorder(Node Root)
    {
        if (Root != null)
        {
            Inorder(Root.left);
            Console.Write(Root.data + " ");
            Inorder(Root.right);
        }
    }

    // left-right-root
    public void Postorder(Node Root)
    {
        if (Root != null)
        {
            Postorder(Root.left);
            Postorder(Root.right);
            Console.Write(Root.data + " ");
        }
    }

    // root-childern-grandchildern-etc...
    // BFS
    public void levelOrder(Node Root)
    {
        if (Root != null)
        {
            queue.Enqueue(Root);

            while (!queue.isEmpty())
            {
                Node node = queue.Dequeue();

                Console.Write(node.data + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);

            }

        }
    }

}
// Queue implementation using array
// FIFO
class Queue<T>
{
    int head;
    int tail;
    int size = 0;
    static readonly int maxSize = 100;
    T[] myArray = new T[maxSize];

    public Queue()
    {
        head = -1;
        tail = 0;
    }

    public Queue(int maxSize)
    {
        myArray = new T[maxSize];
        head = -1;
        tail = 0;
    }

    public void Enqueue(T data)
    {
        if (head >= maxSize)
            head = -1;

        myArray[++head] = data;

        size++;
    }

    public T Dequeue()
    {
        T data = default(T);

        if (!isEmpty())
        {
            data = myArray[tail++];
            size--;
            if (tail >= maxSize)
                tail = 0;
        }

        return data;
    }

    public T Peak()
    {
        if (!isEmpty())
            return myArray[tail];
        else
            return default(T);
    }

    public bool isEmpty()
    {
        return (size == 0 ? true : false);
    }
}


class Solution
{    
    static void Main(String[] args)
    {
        Tree tree = new Tree(); 

        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            tree.Insert(data);
        }

        tree.Inorder(tree.Root);
        Console.WriteLine();
        tree.Postorder(tree.Root);
        Console.WriteLine();
        tree.Preorder(tree.Root);
        Console.WriteLine();
        tree.levelOrder(tree.Root); 


        Console.ReadKey();
    }
}