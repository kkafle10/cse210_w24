using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Ask the user for a series of numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, enter 0 to stop:");
        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        // Compute the sum, average, and find the maximum number
        int sum = 0;
        double average = 0;
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
                max = number;
        }
        if (numbers.Count > 0)
            average = (double)sum / numbers.Count;

        // Print the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
    
}