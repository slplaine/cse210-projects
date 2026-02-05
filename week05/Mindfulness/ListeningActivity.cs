using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nYou may begin in:");
        PauseWithCountdown(5);

        List<string> items = new List<string>();
        Stopwatch timer = new Stopwatch();
        timer.Start();

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        timer.Stop();
        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }
}
