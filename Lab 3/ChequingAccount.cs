using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class ChequingAccount : Account
    {
        public ChequingAccount(double balance, double rate) : base(balance, rate) { }

        public override void MakeWithdraw(double amount)
        {
            if ((currentBalance - amount) < 0)
            {
                serviceCharge += 15;
            }
            else
            {
                base.MakeWithdraw(amount);
            }
        }

        public override string CloseAndReport()
        {
            serviceCharge += 5;
            serviceCharge += (0.1 * numWithdrawl);

            string report = base.CloseAndReport();
            return report;
        }
    }


}
