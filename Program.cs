using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Sermon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks, max=0, min=100, sum = 0,b;
            b = Convert.ToInt16((Console.ReadLine()));
            double avg;


            for(int x = b; b>x; x++)
            {
                Console.Write("Enter Mark " + x + " :");
                marks = Convert.ToInt16(Console.ReadLine());
                sum += marks;
                if (marks < min)
                    min = marks;
                if (marks > max)
                    max = marks;

            }
            Console.WriteLine();

            avg =sum /7.0;
            Console.WriteLine("Sum of marks = " + sum);
            Console.WriteLine("Highest mark= " + max);
            Console.WriteLine("lowest mark = " + min);
            Console.WriteLine("Average mark = " + avg);
            
            Console.ReadLine();


        }
    }
}
