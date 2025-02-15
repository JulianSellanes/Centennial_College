using System;

//Julian Sellanes (301494667)

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ticket prices
            double adultTicketPrice = 3.75;
            double childTicketPrice = 2.25;

            //Prompt user for number of adult tickets
            Console.Write("Enter adult tickets: ");
            int adultTickets = Convert.ToInt32(Console.ReadLine());

            //Prompt user for number of child tickets
            Console.Write("Enter child tickets: ");
            int childTickets = Convert.ToInt32(Console.ReadLine());

            //Calculate total cost
            double totalCost = (adultTickets * adultTicketPrice) + (childTickets * childTicketPrice);

            //Display the result
            Console.WriteLine($"\nYou got {adultTickets} adult ticket(s) and {childTickets} child ticket(s)");
            Console.WriteLine($"The total cost is {totalCost:C}");
        }
    }
}
