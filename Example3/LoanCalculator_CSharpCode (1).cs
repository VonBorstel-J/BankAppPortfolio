
using System;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for Principal Amount
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            // Prompt for Annual Interest Rate
            Console.Write("Enter the annual interest rate (in percentage): ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            // Prompt for Loan Duration in Years
            Console.Write("Enter the loan duration (in years): ");
            int years = Convert.ToInt32(Console.ReadLine());

            // Monthly Interest Rate
            double monthlyInterestRate = (annualInterestRate / 100) / 12;

            // Number of Monthly Payments
            int numberOfPayments = years * 12;

            // Calculate Monthly Payment using the formula
            // M = P [ r(1+r)^n ] / [ (1+r)^n - 1 ]
            double monthlyPayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, numberOfPayments)) / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1);

            // Calculate Total Payment
            double totalPayment = monthlyPayment * numberOfPayments;

            // Output the Results
            Console.WriteLine($"Monthly Payment: {monthlyPayment:F2}");
            Console.WriteLine($"Total Payment: {totalPayment:F2}");
        }
    }
}
