
abstract class Activity
{
    private int seconds = 0;

    public Activity() {}

    public abstract void DisplayDescription();

    public void PromptSetSeconds() {
        Console.WriteLine("How many seconds should the activity last? ");
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

    protected void WaitingAnimation(int milliseconds = 3000) {
        DateTime startTime = DateTime.Now;
        List<char> charList = new(['&', '\\', '|', '/', '%', '~', '-', '~']);

        Console.CursorVisible = false;

        while (DateTime.Now < startTime.AddMilliseconds(milliseconds)) {
            foreach (char x in charList) {
                if (DateTime.Now > startTime.AddMilliseconds(milliseconds)) {
                    break;
                }
                Console.Write(x);
                Thread.Sleep((int)(500/charList.Count));
                Console.Write("\b");
            }
        }

        Console.CursorVisible = true;
    }

    public void DisplayEnd() {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You completed another {seconds} seconds of the activity.");
    }
}