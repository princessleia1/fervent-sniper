using System;

namespace TaxPayer
{
    class Program
    {
        /* Create a class named Taxpayer. Data fields for Taxpayer objects include Social Security Number, Yearly
         * Gross Income, and Tax Owed. Include a property with get and set accessors for the first two data fields.
         * But make Tax Owed a read-only property. Tax should be calculated 15% whenever the income is under $30,000
         * and 28% for $30,000 or higher. Declares an array of ten Taxpayer objects. Prompt for data for each object
         * Display the ten objects.
         */
        static void Main(string[] args)
        {
            Taxpayer[] payers = new Taxpayer[10];
            for(int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayer();
                Console.WriteLine("Enter Payer #{0} SSN: ", i + 1);
                payers[i].SocialSecNumber = Console.ReadLine();
                Console.WriteLine("Enter Payer #{0} Yearly Income: ", i + 1);
                payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());
            }

            // Print info
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine("Tax Payer # {0}, SSN = {1}, Income = {2}, Tax Owed = {3}", i + 1, payers[i].SocialSecNumber, payers[i].YearlyGrossIncome, payers[i].TaxOwed);
            }

            // Expected output like:
            //Enter Payer #1 SSN:
            //111
            //Enter Payer #1 Yearly Income:
            //10000
            //Enter Payer #2 SSN:
            //222
            //Enter Payer #2 Yearly Income:
            //20000
            //Enter Payer #3 SSN:
            //333
            //Enter Payer #3 Yearly Income:
            //100000
            //Enter Payer #4 SSN:
            //444
            //Enter Payer #4 Yearly Income:
            //55999
            //Enter Payer #5 SSN:
            //234
            //Enter Payer #5 Yearly Income:
            //43000
            //Enter Payer #6 SSN:
            //098
            //Enter Payer #6 Yearly Income:
            //50000
            //Enter Payer #7 SSN:
            //987
            //Enter Payer #7 Yearly Income:
            //39000
            //Enter Payer #8 SSN:
            //000
            //Enter Payer #8 Yearly Income:
            //10000
            //Enter Payer #9 SSN:
            //324
            //Enter Payer #9 Yearly Income:
            //29999
            //Enter Payer #10 SSN:
            //987
            //Enter Payer #10 Yearly Income:
            //79000
            //Tax Payer # 1, SSN = 111, Income = 10000, Tax Owed = 1500
            //Tax Payer # 2, SSN = 222, Income = 20000, Tax Owed = 3000
            //Tax Payer # 3, SSN = 333, Income = 100000, Tax Owed = 28000
            //Tax Payer # 4, SSN = 444, Income = 55999, Tax Owed = 15679.72
            //Tax Payer # 5, SSN = 234, Income = 43000, Tax Owed = 12040
            //Tax Payer # 6, SSN = 098, Income = 50000, Tax Owed = 14000
            //Tax Payer # 7, SSN = 987, Income = 39000, Tax Owed = 10920
            //Tax Payer # 8, SSN = 000, Income = 10000, Tax Owed = 1500
            //Tax Payer # 9, SSN = 324, Income = 29999, Tax Owed = 4499.85
            //Tax Payer # 10, SSN = 987, Income = 79000, Tax Owed = 22120
        }
    }
}
