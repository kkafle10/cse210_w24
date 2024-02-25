using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
     static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "4")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            switch (choice)
            {
                case "1":
                    Console.Write("Enter duration (in seconds) for Breathing Activity: ");
                    int breathingDuration = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    BreathingActivity breathingActivity = new BreathingActivity(breathingDuration);
                    breathingActivity.Start();
                    break;

                case "2":
                    Console.Write("Enter duration (in seconds) for Reflection Activity: ");
                    int reflectionDuration = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    ReflectionActivity reflectionActivity = new ReflectionActivity(reflectionDuration);
                    reflectionActivity.Start();
                    break;

                case "3":
                    Console.Write("Enter duration (in seconds) for Listing Activity: ");
                    int listingDuration = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    ListingActivity listingActivity = new ListingActivity(listingDuration);
                    listingActivity.Start();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
