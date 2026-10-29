
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int exitNum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != exitNum) numberList.Add(num);

        } while (num != exitNum);

        int sum = 0;
        for (int i = 0; i < numberList.Count; i++)
        {
            sum += numberList[i];
        }

        Console.WriteLine($"The sum is: {sum}");

        float avg = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {numberList.Max()}");

        Console.WriteLine($"The smallest positive number is: {numberList.Where(n => n >= 0).Min()}");

        numberList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }

    }
}