
abstract class Activity
{
    protected string name;
    protected string description;
    protected int seconds = 0;

    public Activity() {
        this.name = "Activity";
        this.description = "This is the default description of a generic activity.";
    }

    public void DisplayDescription() {
        Console.WriteLine($"Starting {name}:");
        Console.WriteLine();
        Console.WriteLine($"\"{description}\"");
        WaitingAnimation();
    }

    public void PromptSetSeconds() {
        Console.Write("How many seconds should the activity last? ");
        while (true) {
            try {
                this.seconds = Int32.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException notIntErr) {
                Console.WriteLine("Sorry, there was an error, not a valid response");
                Console.WriteLine($"\"{notIntErr.Message}\"");
                Console.WriteLine();
            }
        }
    }

    protected void WaitingAnimation(int spinMs = 600, int totalMs = 3000) {
        DateTime startTime = DateTime.Now;
        List<char> charList = new(['&', '\\', '|', '/', '%', '~', '-', '~']);

        Console.CursorVisible = false;

        while (DateTime.Now < startTime.AddMilliseconds(totalMs)) {
            foreach (char x in charList) {
                if (DateTime.Now > startTime.AddMilliseconds(totalMs)) {
                    break;
                }
                Console.Write(x);
                Thread.Sleep((int)(spinMs/charList.Count));
                Console.Write("\b \b");
            }
        }

        Console.CursorVisible = true;
    }

    protected void Countdown(int seconds) {
        for (int i=seconds; i>0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            foreach (char x in i.ToString()) {
                // to remove all when printing multiple digits
                Console.Write("\b \b");
            }
            // Console.Write(" \b");
        }
    }

    public void DisplayEnd() {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed another {seconds} seconds of the activity.");
        WaitingAnimation();
    }
}