using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Menus
    {
        public static void BankMenu(SavingsAccount a, ChequingAccount b, GlobalSavingsAccount c)
        {

            string input;

            Console.WriteLine("Bank Menu" +
                "\n");
            Console.WriteLine(" A: Savings" +
                "\n B: Chequing" +
                "\n C: GlobalSavings" +
                "\n Q: Exit");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "a":
                    SavingsMenu(a, b, c);
                    break;

                case "b":
                    ChequingMenu(a, b, c);
                    break;

                case "c":
                    GlobalSavingsMenu(a, b, c);
                    break;

                case "q":
                    Console.WriteLine("Exiting");
                    break;

                default:
                    throw new Exception("You did not enter a valid option");
                    
            }
        }
        public static void SavingsMenu(SavingsAccount a, ChequingAccount b, GlobalSavingsAccount c)
        {

            string input;

            Console.WriteLine("Savings Menu" +
                "\n");
            Console.WriteLine(" A: Deposit" +
                "\n B: Withdrawal" +
                "\n C: Close + Report" +
                "\n R: Return to Bank Menu");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "a":
                    double depositAmount;

                    Console.WriteLine("Enter the amount you would like to deposit");
                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    a.MakeDeposit(depositAmount);
                    SavingsMenu(a, b, c);
                    break;

                case "b":
                    double chequingAmount;

                    Console.WriteLine("Enter the amount you would like to withdraw");
                    chequingAmount = Convert.ToDouble(Console.ReadLine());
                    a.MakeWithdraw(chequingAmount);
                    SavingsMenu(a, b, c);
                    break;

                case "c":
                    Console.WriteLine(a.CloseAndReport());
                    SavingsMenu(a, b, c);
                    break;

                case "r":
                    BankMenu(a, b, c);
                    break;

                default:
                    throw new Exception("You did not enter a valid option");
                    
            }
        }

        public static void ChequingMenu(SavingsAccount a, ChequingAccount b, GlobalSavingsAccount c)
        {
            string input;

            Console.WriteLine("Chequing Menu" +
                "\n");
            Console.WriteLine(" A: Deposit" +
                "\n B: Withdrawal" +
                "\n C: Close + Report" +
                "\n R: Return to Bank Menu");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "a":
                    double depositAmount;

                    Console.WriteLine("Enter the amount you would like to deposit");
                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    b.MakeDeposit(depositAmount);
                    ChequingMenu(a, b, c);
                    break;

                case "b":
                    double chequingAmount;

                    Console.WriteLine("Enter the amount you would like to withdraw");
                    chequingAmount = Convert.ToDouble(Console.ReadLine());
                    b.MakeWithdraw(chequingAmount);
                    ChequingMenu(a, b, c);
                    break;

                case "c":
                    Console.WriteLine(b.CloseAndReport());
                    ChequingMenu(a, b, c);
                    break;

                case "r":
                    BankMenu(a, b, c);
                    break;

                default:
                    throw new Exception("You did not enter a valid option");
                    
            }

        }

        public static void GlobalSavingsMenu(SavingsAccount a, ChequingAccount b, GlobalSavingsAccount c)
        {
            string input;

            Console.WriteLine("Global Savings Menu" +
                "\n");
            Console.WriteLine(" A: Deposit" +
                "\n B: Withdrawal" +
                "\n C: Close + Report" +
                "\n D: Report Balance in USD" +
                "\n R: Return to Bank Menu");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "a":
                    double depositAmount;

                    Console.WriteLine("Enter the amount you would like to deposit");
                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    c.MakeDeposit(depositAmount);
                    GlobalSavingsMenu(a, b, c);
                    break;

                case "b":
                    double chequingAmount;

                    Console.WriteLine("Enter the amount you would like to withdraw");
                    chequingAmount = Convert.ToDouble(Console.ReadLine());
                    c.MakeWithdraw(chequingAmount);
                    GlobalSavingsMenu(a, b, c);
                    break;

                case "c":
                    Console.WriteLine(c.CloseAndReport());
                    GlobalSavingsMenu(a, b, c);
                    break;

                case "d":
                    double usdRate;

                    Console.WriteLine("Enter the rate of CAD to US dollar");
                    usdRate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(c.USValue(usdRate));
                    GlobalSavingsMenu(a, b, c);
                    break;

                case "r":
                    BankMenu(a, b, c);
                    break;

                default:
                    throw new Exception("You did not enter a valid option");
                    
            }
        }
    }
}
