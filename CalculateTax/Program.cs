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
            //343
            //Enter Payer #1 Yearly Income:
            //25000
            //Enter Payer #2 SSN:
            //343
            //Enter Payer #2 Yearly Income:
            //30000
            //Enter Payer #3 SSN:
            //888
            //Enter Payer #3 Yearly Income:
            //40000
            //Enter Payer #4 SSN:
            //111
            //Enter Payer #4 Yearly Income:
            //10000
            //Enter Payer #5 SSN:
            //222
            //Enter Payer #5 Yearly Income:
            //20000
            //Enter Payer #6 SSN:
            //455
            //Enter Payer #6 Yearly Income:
            //45000
            //Enter Payer #7 SSN:
            //444
            //Enter Payer #7 Yearly Income:
            //666000
            //Enter Payer #8 SSN:
            //345
            //Enter Payer #8 Yearly Income:
            //90000
            //Enter Payer #9 SSN:
            //443
            //Enter Payer #9 Yearly Income:
            //10000
            //Enter Payer #10 SSN:
            //111
            //Enter Payer #10 Yearly Income:
            //60000
            //Tax Payer # 1, SSN = (1), Income = 25000, Tax Owed = 3750
            //Tax Payer # 2, SSN = (1), Income = 30000, Tax Owed = 8400
            //Tax Payer # 3, SSN = (1), Income = 40000, Tax Owed = 11200
            //Tax Payer # 4, SSN = (1), Income = 10000, Tax Owed = 1500
            //Tax Payer # 5, SSN = (1), Income = 20000, Tax Owed = 3000
            //Tax Payer # 6, SSN = (1), Income = 45000, Tax Owed = 12600
            //Tax Payer # 7, SSN = (1), Income = 666000, Tax Owed = 186480
            //Tax Payer # 8, SSN = (1), Income = 90000, Tax Owed = 25200
            //Tax Payer # 9, SSN = (1), Income = 10000, Tax Owed = 1500
            //Tax Payer # 10, SSN = (1), Income = 60000, Tax Owed = 16800
        }
    }
}
