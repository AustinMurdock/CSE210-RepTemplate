
class ListingActivity : Activity
{
    private readonly List<string> promptsList = new([
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?"
    ]);
    private int listedCount = 0;

    public ListingActivity() : base() {
        this.name = "Listing Activity";
        this.description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void DisplayPrompt() {
        Random random = new();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"    {promptsList[random.Next(promptsList.Count)]}");
        base.WaitingAnimation(1200, 6000);
        Console.WriteLine();
        Console.Write("Listing starts in: ");
        base.Countdown(6);
        Console.WriteLine();
    }

    public void InputLoop() {
        DateTime startTime = DateTime.Now;

        while (DateTime.Now < startTime.AddSeconds(seconds)) {
            Console.Write("  > ");
            Console.ReadLine();
            listedCount++;
        }
    }

    public void DisplayCount() {
        Console.WriteLine($"You listed {listedCount} items.");
        base.WaitingAnimation();
    }
}