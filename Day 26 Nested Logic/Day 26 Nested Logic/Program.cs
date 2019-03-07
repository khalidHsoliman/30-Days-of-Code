using System;
using System.Collections.Generic;
using System.IO;


class Solution
{
    static void Main(String[] args)
    {
        string[] returnDate_temp = Console.ReadLine().Split(' ');
        int[] returnDate = Array.ConvertAll(returnDate_temp, Int32.Parse);

        string[] expectDate_temp = Console.ReadLine().Split(' ');
        int[] expectDate = Array.ConvertAll(expectDate_temp, Int32.Parse);

        int dayDiff   = returnDate[0] - expectDate[0];                 
        int monthDiff = returnDate[1] - expectDate[1];
        int yearDiff  = returnDate[2] - expectDate[2];

        int fine = 0;

        if (dayDiff > 0 || monthDiff > 0 || yearDiff > 0)
        {
            if (dayDiff > 0 && monthDiff == 0 && yearDiff == 0)
                fine = 15 * dayDiff;

            else if (monthDiff > 0 && yearDiff == 0)
                fine = 500 * monthDiff;

            else if (yearDiff > 0)
                fine = 10000; 
        }
            

        Console.WriteLine(fine);

        Console.ReadKey();
    }
}

