using System;

class Solution
{
    public static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp; 
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        int numSwaps = 0; 

        // bubble sort
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    swap(ref a[j],ref a[j + 1]);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }

            numSwaps += numberOfSwaps; 
        }

        Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: "  + a[a.Length - 1]);
    }
}

