using System;
using Lab_3;

public static class MyExtensions
{
   
    /*
   public static double getPercentageChange(this object a)
   {
     double percentageChange = (a.CurrentBalance / a.StartingBalance) * 100;
     return percentageChange;
   }
    */
    public static string toNAMoneyFormat(this double dollar, bool round)
    {
        string str = "";

        if (round == true || dollar < 0)
        {
            str = "($" + Math.Round(dollar, 2).ToString() + ")";
        }
        else if (round == true)
        {
            str = "$" + Math.Round(dollar, 2).ToString() + "";
        }
        
        
        if (round == false || dollar < 0)
        {
            str = "($" + dollar + ")";
        }
        else if (round == false)
        {
            str = "$" + dollar;
        }

        return str;
    } 
   
    
}
