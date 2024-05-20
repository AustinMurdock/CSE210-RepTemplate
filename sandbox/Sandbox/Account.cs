
class Account
{
    public float balance {get; private set; } = 12;

    public float Withdraw() {
        Console.WriteLine("How much to withdraw? \n>");
        float amount = float.Parse(Console.ReadLine());

        if (amount > this.balance) {
            return 0;
        }
        // if statement above can escape:
        this.balance -= amount;

        return amount;
    }

    public float GetBalance() {
        return this.balance;
    }
}