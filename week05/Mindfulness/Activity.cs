using System;
using System.Threading;

public class Activity
{
    
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    
    public int GetDuration()
    {
        return _duration;
    }

    
    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int endTime = seconds * 10;

        for (int i = 0; i < endTime; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

   
    public void PauseWithSpinner(int seconds)
    {
        ShowSpinner(seconds);
    }

    public void PauseWithCountdown(int seconds)
    {
        ShowCountDown(seconds);
    }
}
