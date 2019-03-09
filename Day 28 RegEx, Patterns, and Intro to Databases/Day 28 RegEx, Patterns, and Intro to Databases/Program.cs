using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        Regex regex = new Regex(".+@gmail\\.com$");

        List<string> names = new List<string>(); 
        
        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];
            string emailID = firstNameEmailID[1];

            if(regex.IsMatch(emailID))
            {
                names.Add(firstName); 
            }
        }

        names.Sort();

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
