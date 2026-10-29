using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // ADD SIGN
        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit <= 2 && letter != "F" && grade != 100)
        {
            sign = "-";
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Print message
        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You will get it next time!");
        }
    }
}