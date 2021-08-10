using System;


namespace TaxCalculator
{
    public interface ITax
    {


        
        //This is also one way of doing this app with using interface.
        //In this case, I made all the methods we need and I will implement them in conrete class Tax

        public double TaxCal(double input);

        public double Superannuation(double input);

        public double Medicare(double input);

        public double BudgetRepair(double input);

        public double PayFrequency(double input, string w);
    }
}
