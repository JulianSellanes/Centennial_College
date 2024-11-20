using System;

//Julian Sellanes (301494667)

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales = GetSales();

            double commission = GetCommission(sales);

            Console.WriteLine($"The commission for daily sales of {sales:C} is {commission:C}");
        }

        static double GetSales()
        {
            double sales = -1;

            while (sales < 0)
            {
                Console.Write("Enter the dollar value of daily sales: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double value))
                {
                    if(value >= 0)
                    {
                        sales = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }
            }

            return sales;
        }

        static double GetCommission(double _sales)
        {
            double commissionRate = 1;

            if (_sales < 1000)
            {
                commissionRate = 0.03;
            }
            else if (_sales < 3000)
            {
                commissionRate = 0.04;
            }
            else
            {
                commissionRate = 0.05;
            }

            return _sales * commissionRate;
        }
    }
}