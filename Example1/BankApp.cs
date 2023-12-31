using System;

// Main Program for Basic Banking Application
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create initial bank accounts
            BankAccount account1 = new BankAccount("Jordan", 1000);
            BankAccount account2 = new BankAccount("Friend", 500);

            // Main loop to handle user choices
            while (true)
            {
                // Display menu options
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");

                // Get user choice
                string choice = Console.ReadLine();

                // Perform action based on user choice
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Your balance is: {account1.Balance}");
                        break;

                    case "2":
                        Console.Write("Enter amount to deposit: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        account1.Deposit(depositAmount);
                        break;

                    case "3":
                        Console.Write("Enter amount to withdraw: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        account1.Withdraw(withdrawAmount);
                        break;

                    case "4":
                        Console.Write("Enter amount to transfer: ");
                        decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                        account1.Transfer(account2, transferAmount);
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
