using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class SavingsAccount : Account
    {
        public SavingsAccount(double balance, double rate) : base(balance, rate) { }

        public override void MakeWithdraw(double amount)
        {

            if (currentBalance < 25)
            {
                status = AccountStatus.inactive;
                Console.WriteLine("Your acount is inactive");
            }
            else if ((currentBalance + amount) > 25)
            {
                status = AccountStatus.active;

                base.MakeWithdraw(amount);

                if(currentBalance < 25)
                {
                    status = AccountStatus.inactive;
                }
            }
        }

        public override void MakeDeposit(double amount)
        {
            if ((currentBalance + amount )> 25)
            {
                status = AccountStatus.active;
            }

            base.MakeDeposit(amount);
        }

        public override string CloseAndReport()
        {
            if (numWithdrawl > 4)
            {
                serviceCharge += (numWithdrawl - 4);
            }

            string report = base.CloseAndReport();

            return report;
        }
    }
}
