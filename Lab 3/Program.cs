using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {      
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter interest rate for Savings Account");
                double savingsRate = Convert.ToDouble(Console.ReadLine());
                SavingsAccount a = new SavingsAccount(5, savingsRate);

                Console.WriteLine("Enter interest rate for Chequing Account");
                double chequingRate = Convert.ToDouble(Console.ReadLine());
                ChequingAccount b = new ChequingAccount(5, chequingRate);

                Console.WriteLine("Enter interest rate for Global Savings Account");
                double globalRate = Convert.ToDouble(Console.ReadLine());
                GlobalSavingsAccount c = new GlobalSavingsAccount(5, globalRate);

                Menus.BankMenu(a, b, c);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
