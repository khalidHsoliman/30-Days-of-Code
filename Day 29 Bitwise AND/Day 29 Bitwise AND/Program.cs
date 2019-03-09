using System;

class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            Console.WriteLine((k-1 | k) <= n ? k-1 : k-2); 
        }

        Console.ReadKey();
    }
}
