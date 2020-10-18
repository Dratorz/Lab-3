using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Account : IAccount
    {
        protected double startingBalance;
        protected double currentBalance;
        protected double totalDeposit;
        protected double totalWithdrawl;
        protected int numDeposit;
        protected int numWithdrawl;
        protected double interestRate;
        protected double serviceCharge;
        protected AccountStatus status;
        public double StartingBalance { get; }
        public double CurrentBalance { get; }

        public Account(double balance, double rate)
        {
            startingBalance = balance;
            currentBalance = balance;
            interestRate = rate;
        }

        public virtual void MakeDeposit(double amount)
        {
            currentBalance += amount;
            numDeposit++;
        }

        public virtual void MakeWithdraw(double amount)
        {
            currentBalance -= amount;
            numWithdrawl++;
        }

        public void CalculateInterest()
        {
            double monthlyRate = interestRate / 12;
            currentBalance += currentBalance * monthlyRate;
        }

        public virtual string CloseAndReport()
        {
            currentBalance -= serviceCharge;
            CalculateInterest();
            numWithdrawl = 0;
            numDeposit = 0;
            serviceCharge = 0;

            double percentageChange = (currentBalance / startingBalance) * 100;

            string report = "Previous balance: " + startingBalance +
                            "\n New balance: " + currentBalance +
                            "\n Balance change: " + percentageChange + "%";
            return report;
        }
    }
}
