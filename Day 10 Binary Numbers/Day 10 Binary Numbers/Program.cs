using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)

        { 
            bool NumIsOne = false;

            int num = 0;
            int numOfOnes = 0;
            int maxOnes = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            int reminder = 0;

            Stack<int> myStack = new Stack<int>(); 

            while(n > 0)
            {
                reminder = n % 2;
                n = n / 2;

                myStack.Push(reminder); 
            }

            while (myStack.Count != 0)
            {
                num = myStack.Pop();

                Console.Write(num);

                if (num == 1)
                {
                    if (NumIsOne)
                        numOfOnes++;
                    else
                    {
                        if (numOfOnes == 0)
                            numOfOnes = 1;
                        NumIsOne = true;
                    }
                }

                else
                {
                    NumIsOne = false;
                    if(numOfOnes > maxOnes)
                        maxOnes = numOfOnes;
                    numOfOnes = 0; 
                }
            }

            if (numOfOnes > maxOnes)
                maxOnes = numOfOnes;

            Console.WriteLine();
            Console.WriteLine(maxOnes);
            
            Console.ReadKey();
        }
    }
}
