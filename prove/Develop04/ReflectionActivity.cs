
class ReflectionActivity : Activity
{
    private readonly List<string> promptsList = new([
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    ]);
    private readonly List<string> questionsList = new([
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    ]);

    public ReflectionActivity() : base() {
        this.name = "Reflection Activity";
        this.description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DisplayPrompt() {
        Random random = new();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"    {promptsList[random.Next(promptsList.Count)]}");
        base.WaitingAnimation(1200, 6000);
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter: ");
        Console.ReadLine();
    }

    public void QuestionsLoop() {
        DateTime startTime = DateTime.Now;
        Random random = new();

        while (DateTime.Now < startTime.AddSeconds(seconds)) {
            Console.WriteLine(questionsList[random.Next(promptsList.Count)]);
            base.WaitingAnimation(1200, 6000);
            // only add extra lines if still in loop:
            if (DateTime.Now < startTime.AddSeconds(seconds)) {
                Console.WriteLine();
            }
        }
    }
}