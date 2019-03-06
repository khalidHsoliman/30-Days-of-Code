using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int t = int.Parse(Console.ReadLine()); 

        while(t-- > 0)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num) ? "Prime" : "Not prime");  
        }

        Console.ReadLine(); 
    }

    private static bool IsPrime(int num)
    {
        if (num == 1)
            return false;

        int m = num / 2; 

        for (int i = 2; i <= m; i++)
        {
            if (num % i == 0)
                return false;       
        }

        return true; 
    }
}

