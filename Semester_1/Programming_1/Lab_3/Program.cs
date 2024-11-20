using System;

//Julian Sellanes (301494667)

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int day = 0; day < days.Length; day++)
            {
                Console.WriteLine($"{days[day]}");

                for (int hour = 0; hour < 24; hour++)
                {
                    string peak = "";

                    if (day == 5 || day == 6)
                    {
                        peak = "Off-peak";
                    }
                    else
                    {
                        if (hour >= 7 && hour < 11)
                        {
                            peak = "Mid-peak";
                        }
                        else if (hour >= 11 && hour < 17)
                        {
                            peak = "On-peak";
                        }
                        else if (hour >= 17 && hour < 19)
                        {
                            peak = "Mid-peak";
                        }
                        else
                        {
                            peak = "Off-peak";
                        }
                    }


                    int time = 12;

                    if (hour != 0 && hour != 12)
                    {
                        time = hour % 12;
                    }


                    string pm = "pm";

                    if(hour < 12)
                    {
                        pm = "am";
                    }


                    Console.WriteLine($"{time} {pm}: {peak}");
                }

                Console.WriteLine("");
            }
        }
    }
}
