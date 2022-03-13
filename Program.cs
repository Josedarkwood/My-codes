using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 1;
            while( a ==1)
            {

                double salary, taxrelief, taxableincome, ssnit, tax, total, net;
                const double ssnitrate = 0.035;
                Console.WriteLine("Enter your Salary");
                salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Tax Relief");
                taxrelief = Convert.ToDouble(Console.ReadLine());

                ssnit = salary * ssnitrate;


                taxableincome = salary - (taxrelief + ssnit);

                if (taxableincome <= 365)
                {
                    tax = 365 * 0;
                }

                else
                    if (taxableincome <= 475)
                {
                    tax = 0 + ((taxableincome - 365) * 0.05);
                }
                else
                    if (taxableincome <= 605)
                {
                    tax = 0 + 5.5 + ((taxableincome - 475) * 0.1);

                }

                else
                    if (taxableincome <= 3605)
                {
                    tax = 0 + 5.5 + 13.00 + ((taxableincome - 605) * 0.175);


                }

                else
                    if (taxableincome <= 20000)
                {
                    tax = 0 + 5.5 + 13.00 + 525 + ((taxableincome - 3605) * 0.25);


                }

                else
                {
                    tax = 0 + 5.5 + 13.00 + 525 + 4098.75 + ((taxableincome - 20000) * 0.30);


                }
                total = ssnit + tax;
                net = salary - total;

                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Basic Salary = " + (salary).ToString("c") + "\nTax Relief =  " + (taxrelief).ToString("c") + "\nSSNIT = " + (ssnit).ToString("c") +"\nTaxable Income = " +taxableincome.ToString("c")  +"\nIncome Tax = " + (tax).ToString("c") + "\nTotal Deduction = " + (total).ToString("c") + "\nNet Salary = " + (net).ToString("c"));

                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Enter 1 to Continue");
                    a = Convert.ToInt16(Console.ReadLine());
            }
            
            
               
        }

      
    }
}
