using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class GlobalSavingsAccount : SavingsAccount , IExchangeable
    {
        public GlobalSavingsAccount(double balance, double rate) : base(balance, rate){ }

        public double USValue(double usdRate)
        {
            double usdBalance = (currentBalance * usdRate);
            return usdBalance;
        }
    }
}
