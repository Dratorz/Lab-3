using System;
using Lab_3;

public static class myExtensions
{
    public static double getPercentageChange(this Account a)
    {
        double percentageChange = (a.CurrentBalance / a.StartingBalance) * 100;
        return percentageChange;
    }
}
