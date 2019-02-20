using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            int sum = 0;
            int maxSum = -100;

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            Console.WriteLine(maxSum); 

            Console.ReadKey();
        }
    }
}
