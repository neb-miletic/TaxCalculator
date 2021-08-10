using System;


namespace TaxCalculator
{
    public class Tax : ITax, IMedicare, ISuperannuation
    {
        // Due to finding out late that I need to do this app for interview, I did not use a abstract class.
        // My idea was to abstractise the class so that we could use the methods in other classes, and we could expand functionality
        // separate concerns and extend it if income rules change. 


        private readonly double LowBracket = 19;
        private readonly double MediumBracket = 32.5;
        private readonly double HighBracket = 37;
        private readonly double LuxBracket = 47;

        private readonly double BudgetBracket = 2;

        private readonly double MedicareLow = 10;
        private readonly double MedicareHigh = 2;

        private readonly double Super = 9.5;

        private readonly int noTax = 18200;
        private readonly int lowIncome = 37000;
        private readonly int mediumIncome = 87000;
        private readonly int highIncome = 180000;


        //I used non-static fields in this class so if the values change at some point, it is easier to trace and
        // replace them. They are also private and readonly for encapsulation purpose


        public double TaxCal(double input)
        {
           
            if (noTax < input && input < lowIncome)
            {
                return (input - noTax) * (LowBracket / 100);
            }
            else if (lowIncome < input && input < mediumIncome)
            {
                return 3572 + ((input - lowIncome) * (MediumBracket / 100));
            }
            else if (mediumIncome < input && input < highIncome)
            {
                return 19822 + ((input - mediumIncome) * (HighBracket / 100));
            }
            else if (input > highIncome)
            {
                return 54232 + ((input - highIncome) * (LuxBracket / 100));
            }

            return 0;
            
        }



        public double Superannuation (double input)
        {
            return Math.Round (input - (input / (Super + 100) * 100),2);
        }



        public double Medicare(double input)
        {
            int zeroTax = 21355;



            int lowMedicareIncome = 26668;
            

            if (zeroTax < input && input < lowIncome)
            {
                return Math.Round(input - lowIncome *(MedicareLow/100));
            }
            else if(input > lowMedicareIncome)
            {
                return Math.Round(input  * (MedicareHigh / 100));
            }

            return 0;
        }



        public double BudgetRepair(double input)
        {
            if (input < highIncome)
            {
                return 0;
            }
            else
            {
                return Math.Round ((input - highIncome) * (BudgetBracket/100));
            }
        }


        public double PayFrequency(double input, string payFreq)
        {
            string  week = "w";
            string fortnight = "f";
            string month = "m";

            if (week.Equals(payFreq, StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round((input / 52), 2);
            }
            else if (fortnight.Equals(payFreq, StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round((input / 26), 2);
            }
            else if (month.Equals(payFreq, StringComparison.OrdinalIgnoreCase))
            {
                return Math.Round((input / 12), 2);
            }


            return 0;
            
        }
    }
}
