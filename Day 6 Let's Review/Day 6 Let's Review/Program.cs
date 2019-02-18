using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Let_s_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                for (int j = 0; j < s.Length; j++)
                {
                    if(j % 2 == 0)
                        Console.Write(s[j]); 
                }

                Console.Write('\t');

                for (int j = 0; 
                    j < s.Length; j++)
                {
                    if(j % 2 != 0)
                        Console.Write(s[j]); 
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
