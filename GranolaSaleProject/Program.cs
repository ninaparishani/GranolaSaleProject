using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double barPrice = 1.50;
        int barsPerCase = 100;
        double caseCost = 100.00;
        double studentGovernmentSharePercentage = 0.10;

        int numCases = 29;  // Number of cases sold

       
        int totalBars = numCases * barsPerCase;
        double grossSales = totalBars * barPrice;
        double productCost = numCases * caseCost;
        double grossProfit = grossSales - productCost;
        double govFee = grossProfit * studentGovernmentSharePercentage;
        double netProfit = grossProfit - govFee;

        // Display results
        Console.WriteLine("Granola Bar Sales:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("{0, -15}{1,10:d}", "Cases sold:", numCases);
        Console.WriteLine("{0, -15}{1,10:d}", "Total bars:", totalBars);
        Console.WriteLine("{0, -15}{1,10:c}", "Gross sales:", grossSales);
        Console.WriteLine("{0, -15}{1,10:c}", "Product costs:", productCost);
        Console.WriteLine("{0, -15}{1,10:c}", "Gross Profit:", grossProfit);
        Console.WriteLine("{0, -15}{1,10:c}", "Government fee:", govFee);
        Console.WriteLine("{0, -15}{1,10:c}", "Net Proceeds:", netProfit.ToString("c", CultureInfo.CurrentCulture));


        Console.ReadKey();
    }
}

