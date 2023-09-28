
public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");
    }

    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds for transfer.");
            return;
        }

        Withdraw(amount);
        targetAccount.Deposit(amount);
        Console.WriteLine($"Transferred {amount} to {targetAccount.Owner}. Your new balance: {Balance}");
    }
}
