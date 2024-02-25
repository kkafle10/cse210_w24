using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalScore = 0;

    static void Main(string[] args)
    {
        LoadGoals();
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    SaveGoals();
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddGoal()
    {
        Console.WriteLine("\nSelect the type of goal to add:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, 0));
                break;
            case "2":
                goals.Add(new EternalGoal(name));
                break;
            case "3":
                Console.Write("Enter target count for the checklist goal: ");
                int targetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, targetCount));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not added.");
                return;
        }

        Console.WriteLine($"Goal '{name}' added successfully.");
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter your choice: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= goals.Count)
        {
            Console.WriteLine("Invalid choice. Event not recorded.");
            return;
        }

        goals[index].RecordEvent();
        totalScore += goals[index].Value;

        Console.WriteLine($"Event recorded for goal '{goals[index].Name}'.");
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in goals)
        {
            Console.Write($"{goal.Name} - ");
            if (goal.Completed)
            {
                Console.WriteLine("[X]");
            }
            else
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    Console.WriteLine(checklistGoal.GetProgress());
                }
                else
                {
                    Console.WriteLine("[ ]");
                }
            }
        }
    }

    static void ShowScore()
    {
        Console.WriteLine($"\nTotal Score: {totalScore}");
    }

    static void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Name}");
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string type = parts[0];
                        string name = parts[1];

                        Goal goal;
                        switch (type)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(name, 0);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(name);
                                break;
                            case "ChecklistGoal":
                                int targetCount = int.Parse(parts[2]);
                                goal = new ChecklistGoal(name, targetCount);
                                break;
                            default:
                                continue;
                        }

                        goals.Add(goal);
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
    }
}

