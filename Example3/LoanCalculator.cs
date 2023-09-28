using System;

// Program to calculate loan payments
namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for principal amount
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            // Prompt user for annual interest rate
            Console.Write("Enter the annual interest rate (in percentage): ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            // Prompt user for loan duration in years
            Console.Write("Enter the loan duration (in years): ");
            int years = Convert.ToInt32(Console.ReadLine());

            // Calculate monthly interest rate
            double monthlyInterestRate = (annualInterestRate / 100) / 12;

            // Calculate number of monthly payments
            int numberOfPayments = years * 12;

            // Calculate monthly payment using formula
            double monthlyPayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            // Calculate total payment over loan term
            double totalPayment = monthlyPayment * numberOfPayments;

            // Display the calculated monthly and total payments
            Console.WriteLine($"Monthly Payment: {monthlyPayment:F2}");
            Console.WriteLine($"Total Payment: {totalPayment:F2}");
        }
    }
}
