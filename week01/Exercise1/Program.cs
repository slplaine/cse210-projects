using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // First name entry
        Console.Write("What is your first name? ");
         string firstName = Console.ReadLine(); 
         // Last name entry
         Console.Write("What is your last name? "); 
         string lastName = Console.ReadLine();
          // Output formatted name
          Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}"); 
    }
}