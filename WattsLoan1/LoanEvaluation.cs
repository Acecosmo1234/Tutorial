using System;
using System.Collections.Generic;
using System.Text;

namespace WattsLoan1
{
   public class LoanEvaluation
    {
        public double GetPrincipal()
        {
            Console.WriteLine("Enter the principal:  $");
            double p = double.Parse(Console.ReadLine());
 
            return p;
        }
        public double GetInterestRate()
        {
            Console.WriteLine("Enter the interest rate (%):  ");
            double r = double.Parse(Console.ReadLine());

            return r;
        }

        public double GetPeriod(ref int TypeOfPeriod, ref double periods)
        {
            Console.WriteLine("How do you want to enter the length of time?");
            Console.WriteLine("1 - In Days");
            Console.WriteLine("2 - In Months");
            Console.WriteLine("3 - In Years");
            Console.Write("Your Choice: ");
            TypeOfPeriod = int.Parse(Console.ReadLine());

            if (TypeOfPeriod == 1)
            {
                Console.Write("Enter the number of days: ");
               double Periods = double.Parse(Console.ReadLine());
                return Periods / 360;
            }
            else if (TypeOfPeriod == 2)
            {
                Console.Write("Enter the number of months: ");
               double Periods = double.Parse(Console.ReadLine());
                return Periods / 12;
            }
            else if (TypeOfPeriod == 3)
            {
                Console.Write("Enter the number of years: ");
               double Periods = double.Parse(Console.ReadLine());
                return Periods;
            }
            else
            {
                TypeOfPeriod = 0;
                // The user made an invalid selection. So, we will give up
                return 0.00;
            }
        }
        public double InterestAmount(double P, double r, double t)
        {
            return P * (r / 100) * t;
        }
    }
}
