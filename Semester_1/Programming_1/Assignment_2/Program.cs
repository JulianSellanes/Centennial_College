using System;

//Julian Sellanes (301494667)

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                DisplayMenu();

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 3:
                            Console.WriteLine("==========================================");
                            Console.WriteLine("You chose the sum of X inputs. (5 by default)");
                            int result3 = CalculateSum(5);
                            Console.WriteLine($"The sum of your inputs is: {result3}");
                            Console.WriteLine("==========================================");
                            break;
                        case 4:
                            Console.WriteLine("==========================================");
                            Console.WriteLine("You chose the sum of squares of X inputs.");

                            bool ready = false;
                            while(ready == false)
                            {
                                Console.Write("Enter the amount of inputs: ");
                                if (int.TryParse(Console.ReadLine(), out int amountInputs) && amountInputs > 0)
                                {
                                    ready = true;
                                    int result4 = CalculateSumOfSquares(amountInputs);
                                    Console.WriteLine($"The sum of the squares of your inputs is: {result4}");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid amount of inputs. Next time enter a positive int.");
                                }
                            }

                            Console.WriteLine("==========================================");
                            break;
                        case 5:
                            Console.WriteLine("==========================================");
                            Console.WriteLine("You chose the sum of cubes of X inputs.");
                            int result5 = CalculateSumOfCubes();
                            Console.WriteLine($"The sum of the cubes of your inputs is: {result5}");
                            Console.WriteLine("==========================================");
                            break;
                        case 0:
                            exit = true;
                            Console.WriteLine("==========================================");
                            Console.WriteLine("Bye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            Console.WriteLine("==========================================");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid int number.");
                    Console.WriteLine("==========================================");
                }

            } while (exit == false);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("0) To Exit");

            Console.WriteLine("Enter the number of your choice: ");
        }

        static int CalculateSum(int _amountInputs)
        {
            int sum = 0;
            int pass = 0;

            if(_amountInputs <= 0)
                return sum;

            while (pass < _amountInputs)
            {
                Console.Write($"Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    sum += input;
                    pass++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid int number.");
                }
            }

            return sum;
        }

        static int CalculateSumOfSquares(int _amountInputs)
        {
            int sum = 0;
            int pass = 0;

            if (_amountInputs <= 0)
                return sum;

            while (pass < _amountInputs)
            {
                Console.Write($"Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    sum += input * input;
                    pass++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid int number.");
                }
            }

            return sum;
        }

        static int CalculateSumOfCubes()
        {
            while (true)
            {
                Console.Write("Enter the amount of inputs: ");
                if (int.TryParse(Console.ReadLine(), out int amountInputs) && amountInputs > 0)
                {
                    int sum = 0;
                    int pass = 0;

                    while (pass < amountInputs)
                    {
                        Console.Write($"Enter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int input))
                        {
                            sum += input * input * input;
                            pass++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid int number.");
                        }
                    }

                    return sum;
                }
                else
                {
                    Console.WriteLine("Invalid amount of inputs. Next time enter a positive int.");
                }
            }
        }
    }
}
