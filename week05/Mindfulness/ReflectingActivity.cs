using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you use this experience in the future?"
    };

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        int elapsedTime = 0;

        // 🔹 Cópia da lista de perguntas
        List<string> remainingQuestions = new List<string>(_questions);

        while (elapsedTime < GetDuration())
        {
            // Se acabar, recria a lista
            if (remainingQuestions.Count == 0)
            {
                remainingQuestions = new List<string>(_questions);
            }

            int index = rand.Next(remainingQuestions.Count);
            string question = remainingQuestions[index];

            Console.Write($"\n> {question} ");
            PauseWithSpinner(5);

            elapsedTime += 5;

            // 🔹 Remove a pergunta já usada
            remainingQuestions.RemoveAt(index);
        }

        DisplayEndingMessage();
    }
}
