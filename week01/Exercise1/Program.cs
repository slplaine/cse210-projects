using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // First name entry
        Console.Write("What is your first name? ");
         string? first = Console.ReadLine(); 
         // Last name entry
         Console.Write("What is your last name? "); 
         string? last = Console.ReadLine();
          // Output formatted name
          Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}