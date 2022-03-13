using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first Number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Second Number");
            string input2 = Console.ReadLine();

            a = Convert.ToInt16(input1);
            b = Convert.ToInt16(input2);
            c = a + b;

            Console.WriteLine("First number = " + a);
            Console.WriteLine("Second Number = " + b);
            Console.WriteLine(a+ " + " + b +  " = " + c);
            Console.ReadLine();

        }
    }
}
