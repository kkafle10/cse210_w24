using System;

class Program
{
    static void Main(string[] args)

    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Initialize variable to hold letter grade
        char letter;

        // Determine letter grade based on percentage
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Print the letter grade
        Console.WriteLine("Your letter grade is: " + letter);

        // Check if the student passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard for next time!");
        }

        
    }
}


