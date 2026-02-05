using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
          )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < GetDuration())
        {
            Console.Write("\nBreathe in...");
            PauseWithCountdown(3);
            elapsedTime += 3;

            Console.Write("\nNow breathe out...");
            PauseWithCountdown(3);
            elapsedTime += 3;
        }

        DisplayEndingMessage();
    }
}
