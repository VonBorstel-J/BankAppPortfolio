// BankAccount class to model a simple bank account
public class BankAccount
{
    // Properties for the account owner and balance
    public string Owner { get; set; }
    public decimal Balance { get; private set; }

    // Constructor to initialize a new bank account
    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }

    // Method to withdraw money from the account
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

    // Method to transfer money to another account
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
