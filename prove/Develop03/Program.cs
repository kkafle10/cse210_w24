using System;


using System;
using System.Collections.Generic;
using System.Linq;




class Program
{
    static void Main(string[] args)
    {
        // Sample scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        while (true)
        {
            Console.WriteLine("Press Enter to reveal more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            Console.Clear();
            scripture.HideRandomWords();
            scripture.Display();

            if (scripture.AllWordsHidden())
                break;
        }
    }
}

