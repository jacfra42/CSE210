using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input = -1;
        List<int> nums = new List<int>();
        while (input != 0)
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                nums.Add(input);
            }
        }

        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float avg = (float)sum / nums.Count;
        Console.WriteLine($"The average is: {avg}");

        int largestNum = 0;
        foreach (int num in nums)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}