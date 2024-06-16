
class BreathingActivity : Activity
{
    public BreathingActivity() : base() {
        this.name = "Breathing Activity";
        this.description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BreatheLoop() {
        DateTime startTime = DateTime.Now;

        while (DateTime.Now < startTime.AddSeconds(seconds)) {
            Console.Write("Breathe in ... ");
            base.Countdown(5);
            Console.WriteLine("\n");
            if (DateTime.Now > startTime.AddSeconds(seconds)) {
                break;
            }
            Console.Write("Breathe out ... ");
            base.Countdown(5);
            Console.WriteLine("\n");
        }
        Console.WriteLine("Time to relax, activity complete ... ");
        base.WaitingAnimation();
    }
}