using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] keyValue;
            string name; 

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                keyValue = Console.ReadLine().Split(' ');

                phoneBook.Add(keyValue[0], keyValue[1]); 
            }


            while (true)
            {
                name = Console.ReadLine();
                if (name == "")
                    break; 

                if (phoneBook.ContainsKey(name))
                    Console.WriteLine(name + "=" + phoneBook[name]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
