using System;

namespace Practice;

public class ParkingBillCalc
{
    public int Solution(string E, string L)
    {
        TimeSpan entryTime = TimeSpan.Parse(E);
        TimeSpan exitTime = TimeSpan.Parse(L);

        decimal entranceFee = 2.00m;
        decimal firstHourFee = 3.00m;
        decimal additionalHourFee = 4.00m;

        int totalTimeInMinutes = (int)(exitTime - entryTime).TotalMinutes;
        int totalTimeInHours = (int)Math.Ceiling(totalTimeInMinutes / 60.0);

        decimal totalCostToPark = entranceFee + firstHourFee;
        if (totalTimeInHours > 1)
        {
            totalCostToPark += (totalTimeInHours - 1) * additionalHourFee;
        }

        return (int)totalCostToPark;

    }
}
