using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int MyInt = 0;
        double MyDbl = 0.0;
        string MyStr = "";

        // Read and save an integer, double, and String to your variables.
        MyInt = int.Parse(Console.ReadLine());
        MyDbl = double.Parse(Console.ReadLine());
        MyStr = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + MyInt);

        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", d + MyDbl );

        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + MyStr);

        // The 's' variable above should be printed first.

        Console.ReadKey();
    }
}
