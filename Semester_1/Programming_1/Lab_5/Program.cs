using System;

//Julian Sellanes (301494667)

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Menu();

                Console.Write("Enter the letter of your choice: ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "a":
                        Console.WriteLine("==========================================");
                        Console.WriteLine("You chose option A");
                        Console.WriteLine("");
                        OptionA();
                        Console.WriteLine("");
                        Console.WriteLine("==========================================");
                        break;
                    case "b":
                        Console.WriteLine("==========================================");
                        Console.WriteLine("You chose option B");
                        Console.WriteLine("");
                        OptionB();
                        Console.WriteLine("");
                        Console.WriteLine("==========================================");
                        break;
                    case "x":
                        exit = true;
                        Console.WriteLine("==========================================");
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid letter.");
                        Console.WriteLine("");
                        Console.WriteLine("==========================================");
                        break;
                }
            } while (exit == false);
        }

        static void Menu()
        {
            Console.WriteLine("A - Convert Pounds to Kilograms");
            Console.WriteLine("B - Convert Miles to Kilometers");
            Console.WriteLine("X - Exit");
        }

        static void OptionA()
        {
            Console.WriteLine("{0, -15} {1, 0}", "Pounds", "Kilograms");

            for (double pounds = 200; pounds >= 50; pounds -= 5)
            {
                double kilograms = PoundsToKilograms(pounds);
                Console.WriteLine("{0, -15} {1, 0}", $"{pounds}", $"{kilograms:F2}");
            }
        }

        static double PoundsToKilograms(double _pounds)
        {
            return _pounds * 0.453592;
        }

        static void OptionB()
        {
            Console.WriteLine("{0, -15} {1, 0}", "Miles", "Kilometers");

            for (double miles = 10; miles <= 100; miles += 10)
            {
                MilesToKilometers(miles, out double kilometers);
                Console.WriteLine("{0, -15} {1, 0}", $"{miles}", $"{kilometers:F2}");
            }
        }

        static void MilesToKilometers(double _miles, out double _kilometers)
        {
            _kilometers = _miles * 1.60934;
        }
    }
}