using System;
using System.Collections.Generic;
using System.Text;

namespace WattsLoan1
{
    public delegate double Add2Values(double Value, double Value2);
    class Program
    {
        static void Main(string[] args)
        {
            double Principal, IntRate, Period, AmountPaidAsInterest;
            int TypeOfPeriod = 0;
            double Periods = 0D;
            string PeriodName = null;
            LoanEvaluation loan = new LoanEvaluation();

            
            
            Console.WriteLine(
            "This program allows you to calculate the amount of money a ");
            Console.WriteLine(
            "customer will owe at the end of the lifetime of a loan\n");

            Console.WriteLine("Loan Processing\n");
            Principal = loan.GetPrincipal();
            IntRate = loan.GetInterestRate();
            Period = loan.GetPeriod(ref TypeOfPeriod, ref Periods);
            AmountPaidAsInterest = loan.InterestAmount(Principal, IntRate, Period);

            loan.GetPeriod(ref TypeOfPeriod, ref Periods);

            //Using Lamda Expression
            Add2Values Add = (double Value1, double Value2) =>
            {
                return Value1 + Value2;
            };

            if (TypeOfPeriod == 0)
            {
                
            }
            {
                PeriodName = "Unknown";
            }
            if (TypeOfPeriod == 1)
            {
                PeriodName = "days";
            }
            else if (TypeOfPeriod == 2)
            {
                PeriodName = "months";
            }
            else if (TypeOfPeriod == 3)
            {
                PeriodName = "years";
            }
            Console.WriteLine("================================");
            Console.WriteLine("Estimate Loan");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Principal: {0:C}", Principal);
            Console.WriteLine("Interest:  {0:P}", IntRate / 100);
            Console.WriteLine("Period:    {0} {1}", Periods,PeriodName);
            Console.WriteLine("================================");
            Console.WriteLine("Total Amount Paid:     {0}", Add);
            Console.WriteLine("Interest paid on Loan: {0}", AmountPaidAsInterest);

            
        }
    }
}
