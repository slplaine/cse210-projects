using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        var numbers = new List<int>();
        while (true)
        {
            Console.Write("Please enter a number: "); 
            string input = Console.ReadLine();
            bool ok = int.TryParse(input, out int userNumber);
            if (!ok)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }
            if (userNumber == 0)
            {
                break;
            }
            numbers.Add(userNumber);
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered."); 
            return;
        }
        int sum = numbers.Sum();
        double average = (double)sum / numbers.Count;
        int largest = numbers.Max();
        
        Console.WriteLine($"The sum is {sum}"); 
        Console.WriteLine($"The average is {average}"); 
        Console.WriteLine($"The largest number was {largest}");
    }
}