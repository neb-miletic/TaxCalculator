using System;


namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your salary package amount:");

            var inp = Console.ReadLine();

            double input;

            while (!double.TryParse(inp,out input))
            {
                Console.WriteLine("This is not a number. Please try again");
                inp = Console.ReadLine();
            }

           



                Tax amount = new Tax();
                double super = amount.Superannuation(input);
                double taxable = Math.Round((input - super), 2);
                double medicare = amount.Medicare(taxable);
                double budgetRep = amount.BudgetRepair(taxable);
                double incomeTax = Math.Round(amount.TaxCal(taxable), 2);
                double netIncome = Math.Round((taxable - medicare - incomeTax - budgetRep), 2);



                Console.WriteLine("Enter your pay frequency (W for weekly, F for fortnightly, M for monthly): ");
                string frequency = Console.ReadLine();
                double payPacket = amount.PayFrequency(netIncome, frequency);



                Console.WriteLine("Calculating salary details... \n");

                Console.WriteLine("Gross package {0}", input.ToString("C"));
                Console.WriteLine("Superannuation: {0} \n", super.ToString("C"));


                Console.WriteLine("Taxable income: {0} \n", taxable.ToString("C"));

                Console.WriteLine("Deductions: ");
                Console.WriteLine("Medicare Levy: {0}", medicare.ToString("C"));
                Console.WriteLine("Budget Repair Levy: {0}", budgetRep.ToString("C"));
                Console.WriteLine("Income Tax: {0} \n", incomeTax.ToString("C"));


                Console.WriteLine("Net income: {0}", netIncome.ToString("C"));

                Console.WriteLine("Pay packet: {0}\n", payPacket.ToString("C"));

                Console.WriteLine("Press any key to end...");
                Console.ReadKey();
          
        }
    }
}
