using System;

namespace WorkshopDayMonth
{
    /// <summary>
    /// Class for Finding Day and for Main method
    /// </summary>
    public class Program
    {
        //Driver method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Day month year problem");

            //For User Arguments
            Console.WriteLine("Please enter the Month in the format of (1-12)");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Year");
            int y=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Day");
            int d=int.Parse(Console.ReadLine());

           //Variable
            int yy = 0;
            int xx = 0;
            int mm = 0;
            int dd;

            //Main Logic (Gregorian calendar)
            yy = y - (14 - m) / 12;
            xx = yy + yy / 4 - yy / 100 + yy / 400;
            mm = m + 12 * ((14 - m) / 12) - 2;
            dd = (d + xx + 31 * mm / 12) % 7;

            //Switch case for Finding particular weekday
            switch (dd)
            {
                case 0:
                    Console.WriteLine("That particular day is SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("That particular day is MONDAY");
                    break ;
                case 2:
                    Console.WriteLine("That particular day is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("That particular day is WEDNESSDAY");
                    break;
                case 4:
                    Console.WriteLine("That particular day is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("That particular day is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("That particular day is SATURDAY");
                    break;
               //Default case 
               default:
                    Console.WriteLine("Please enter the perfect value ");
                    break;
            }
        }
    }
}
