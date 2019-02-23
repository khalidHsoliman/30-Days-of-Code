using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
        maximumDifference = 0; 
    }

    public void computeDifference()
    {
        int diff = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = i+1; j < elements.Length; j++)
            {
                diff = Math.Abs(elements[i] - elements[j]);
                if (diff > maximumDifference)
                    maximumDifference = diff; 
            }
        }
    }

} 

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}