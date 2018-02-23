using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());

        double adjTipPercent = Convert.ToDouble(tip_percent / 100.00);
        double adjTaxPercent = Convert.ToDouble(tax_percent / 100.00);


        double tip = meal_cost * adjTipPercent;
        double tax = meal_cost * adjTaxPercent;

        double totalCost = meal_cost + tip + tax;

        double roundedTotal = Math.Round(totalCost);

        Console.Write($"The total meal cost is {roundedTotal} dollars.");
        Console.ReadKey();





    }
}