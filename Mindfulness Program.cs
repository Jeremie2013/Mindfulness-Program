using System;
using System.Threading;

// Base class for all activities
public class Activity
{
    protected int Duration;

    public Activity(int duration)
    {
        Duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine("Activity starting...");
        Thread.Sleep(2000); // Pause for a few seconds, showing animation
        Console.WriteLine($"Prepare to begin. Duration: {Duration} seconds.");
        Thread.Sleep(3000); // Pause for a few more seconds
    }

    public virtual void End()
    {
        Console.WriteLine("Good job! Activity completed.");
        Thread.Sleep(2000); // Pause for a few seconds, showing animation
        Console.WriteLine($"Activity completed in {Duration} seconds.");
        Thread.Sleep(3000); // Pause for a few more seconds
    }
}

// Breathing activity
public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Breathe();
    }

    private void Breathe()
    {
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000); // Pause for a second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000); // Pause for a second
        }
    }
}

// Reflection activity
public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Reflect();
    }

    private void Reflect()
    {
        Random random = new Random();

        for (int i = 0; i < Duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(2000); // Pause for a few seconds, showing spinner

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000); // Pause for a few seconds, showing spinner
            }
        }
    }
}

// Listing activity
public class ListingActivity : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        ListItems();
    }

    private void ListItems()
    {
        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Countdown to begin thinking about the prompt

        Console.WriteLine("Start listing items...");
        Thread.Sleep(Duration * 1000); // Simulate user listing items for the specified duration

        Console.WriteLine($"Number of items entered: {Duration}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Relaxation Program!");

        // Example usage:
        BreathingActivity breathingActivity = new BreathingActivity(5);
        breathingActivity.Start();
        breathingActivity.End();

        ReflectionActivity reflectionActivity = new ReflectionActivity(8);
        reflectionActivity.Start();
        reflectionActivity.End();

        ListingActivity listingActivity = new ListingActivity(10);
        listingActivity.Start();
        listingActivity.End();
    }
}
