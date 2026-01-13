using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Grade Percent: ");
        string input = Console.ReadLine();
        double grade;
        bool ok = double.TryParse(input, out grade);
        if (!ok)
            {arabéns, você passou na disciplina!
            Console.WriteLine("Invalid entry. Please enter a number.");
            return;
            }
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string sign = "";
        int lastDigit = ((int)grade) % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"{letter}{sign}");            
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the subject!");
        }
        else
        {
            Console.WriteLine("Don't give up, try again next time!");
        }
    }
}