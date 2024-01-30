using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        PromptGenerator promptGenerator = new()
        {
            _prompts =
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What was the most important think I made today?",
                "If you could change something of today, what it could be?",
                "Count the blessings you have received today."
            }
        };
        Entry entry = new()
        {
            _date = DateTime.Now.ToString("dd/MM/yyyy")

        };


        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the folowing choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do?");
            userChoice = Console.ReadLine();

            Dictionary<string, Action> actions = new()
            {
                { "1", () => journal.AddEntry() },
                { "2", () => journal.DisplayAll() },
                { "3", () => journal.SaveToFile() },
                { "4", () => journal.LoadFromFile() },
                // { "5", () => Environment.Exit(0) }
            };

            if (actions.ContainsKey(userChoice))
            {
                actions[userChoice].Invoke();
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }


    }
}