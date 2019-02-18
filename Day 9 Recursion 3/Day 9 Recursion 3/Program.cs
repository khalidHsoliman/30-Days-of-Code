using System;
using System.IO;


using System.Threading.Tasks;

namespace Day_9_Recursion_3
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return (n * Factorial(n - 1));
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
