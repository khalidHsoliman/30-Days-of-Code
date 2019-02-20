using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }

    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;
    private int avg = 0; 

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    public Student(string firstname, string lastname, int id, int[] scores) : base(firstname, lastname, id)
    {
        testScores = scores;
    }


    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    public char Calculate()
    {
        avg = testScores.Sum() / testScores.Length;

        if (avg >= 90)
            return 'O';

        else if (avg < 90 && avg >= 80)
            return 'E';

        else if (avg < 80 && avg >= 70)
            return 'A';

        else if (avg < 70 && avg >= 55)
            return 'P';

        else if (avg < 55 && avg >= 40)
            return 'D';

        else if (avg < 40)
            return 'T';

        else
            return '0';
    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");

        Console.ReadKey();
    }
}