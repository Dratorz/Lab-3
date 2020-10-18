using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface IAccount
    {
        void MakeWithdraw(double amount);
        void MakeDeposit(double amount);
        void CalculateInterest();
        String CloseAndReport();
    }
}
