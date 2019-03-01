using System;

// stack implementation using array
// LIFO
class Stack<T>
{
    int tos;
    static readonly int maxSize = 100;
    T[] myArray = new T[maxSize];

    public Stack()
    {
        tos = -1; 
    }

    public Stack(int maxSize)
    {
        myArray = new T[maxSize];
        tos = -1; 
    }

    public void Push(T data)
    {
        if (tos >= maxSize)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }

        myArray[++tos] = data;
    }

    public T Pop()
    {
        T data = default(T);

        if (!isEmpty())
            data = myArray[tos--];
        else
            Console.WriteLine("Stack Underflow");

        return data; 
    }

    public T Peak()
    {
        if (tos < 0)
        {
            Console.WriteLine("Stack Underflow");
            return default(T);
        }

        return myArray[tos]; 
    }

    public bool isEmpty()
    {
        return (tos == -1 ? true : false); 
    }
}


// queue implementatio using array
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
        tail =  0; 
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
    Stack<char> myStack = new Stack<char>();
    Queue<char> myQueue = new Queue<char>(); 

    void pushCharacter(char ch)
    {
        myStack.Push(ch); 
    }

    void enqueueCharacter(char ch)
    {
        myQueue.Enqueue(ch); 
    }

    char popCharacter()
    {
        return myStack.Pop();
    }

    char dequeueCharacter()
    {
        return myQueue.Dequeue(); 
    }

    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}