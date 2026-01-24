// Improvement: The program now saves and loads journal entries in CSV format,
// improving the process so the file can be opened directly in Excel
using System; 
using System.Collections.Generic; 
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "7")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load (.txt)");
            Console.WriteLine("4. Save (.txt)");
            Console.WriteLine("5.Load (.csv)");
            Console.WriteLine("6.Save (.csv)");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString("MM/dd/yyyy"),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.Write("What is the filename? "); 
                string filename = Console.ReadLine(); 
                journal.LoadFromCsv(filename);
            }
            else if (choice == "6")
            {
                Console.Write("What is the filename? "); 
                string filename = Console.ReadLine(); 
                journal.SaveToCsv(filename);
            }
            else if (choice == "7")
            {
                Console.WriteLine("Goodbye!");
            }   
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
