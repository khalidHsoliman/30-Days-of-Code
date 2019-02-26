using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        int N = 0; 

        try
        {
            N = int.Parse(S);
            Console.WriteLine(S); 
        }

        catch(Exception ex)
        {
            Console.WriteLine("Bad String");
        }

        Console.ReadKey();
    }
}

