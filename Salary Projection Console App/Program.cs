using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Projection_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                //decimal CPL;
                decimal CP;
                decimal r;
                int n;
                string total;
                double interest;
                double price;

                Console.WriteLine("Dalveer Car Loan Financing\n ");
                Console.Write("Please enter original Car Price (decimal): ");
                CP = decimal.Parse(Console.ReadLine());
                Console.Write("Please enter annual rate of interest (decimal): ");
                r = decimal.Parse(Console.ReadLine());
                Console.Write("Please enter the loan period, starting at 2 yrs (integer - years): ");
                n = int.Parse(Console.ReadLine());

                interest = (double)r;
                price = (double)CP;
               

                total = "$" + (price * Math.Pow(1 + (interest / 100 / 365), n * 365)).ToString("n2");

                Console.WriteLine("\nYour car price over a loan period of 2 years is " + total);
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("\nError while calculating the Car loan Price\nPlease check your input");
                Console.ReadKey();
            }
        }
    }
}
