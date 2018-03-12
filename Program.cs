using System;
using static System.Console;

namespace CalculateProfits
{
    class Program
    {
        public static string inputValue { get; private set; }

        static void Main(string[] args)
        {
            DisplayInstructions();
            

            double pricePerBar = GettingPrice();
            double casesSold = GettingCases();

            //Doing the math
 
            double grossSales = casesSold * pricePerBar * 12;
            double costOfCases = 5.00 * casesSold;
            double netSales = grossSales - costOfCases;
            double studentFees = netSales * .10;
            double profit = netSales - studentFees;
            double wholesale = (5.00 / 12);

            PrintResults(pricePerBar,casesSold,grossSales,costOfCases,netSales,studentFees,profit,wholesale);
            
           ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("\tCalculate Profit From Candy Sales Application\n"+
                "\nThis application shows how much is made on the granola sales project.\n"+
                "First you will be asked to enter the sale price per bar.\n"+
                "Then you will be asked to enter the number of cases of granola bars sold.\n" +
                "\nThe amount of profit made on the granola sales will be displayed.\n"+
                "\n\t...Press any key when you are ready to begin...");
           
            ReadKey();
            Clear();

        }

        static double GettingPrice()
        {
            WriteLine("\tCalculate Profit From Candy Sales Application\n" +
                "\nPlease enter the price per bar - i.e. 0.75: ");
            inputValue = ReadLine();
            double salePrice = double.Parse(inputValue);

            return salePrice;
        }

        static double GettingCases()
        {
            WriteLine("Please enter the number of cases sold: ");
            inputValue = ReadLine();
            double casesSold = double.Parse(inputValue);

            return casesSold;
        }

       static void PrintResults(double pricePerBar, double casesSold, double grossSales, double costOfCases, double netSales, 
                                double studentFees, double profit, double wholesale)
        {
            WriteLine("\tSummary of Candy Sales\n");
            WriteLine("Number of Cases Sold:\t\t{0,6}\nNumber of Bars Per Case:\t{1,6}\nNumber of Bars Sold:\t\t{2,6}",casesSold,12,(casesSold * 12));
            WriteLine();
            WriteLine("Wholesale Cost per bar:\t\t{0,6:c}",wholesale);
            WriteLine("Selling Price Per Bar\t\t{0,6:c}",(pricePerBar));
            WriteLine("\nGross Sales:\t\t\t{0,6:c}\nCost of Candy:\t\t\t{1,6:c}\nNet Sales:\t\t\t{2,6:c}\nStudent Fees:\t\t\t{3,6:c}",grossSales,costOfCases,netSales,studentFees);
            WriteLine();
            WriteLine("\n******Profit:\t\t\t{0:c}*",profit);
            ReadKey();

        }


    }
}
