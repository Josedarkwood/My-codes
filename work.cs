using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Sermon
{
    class work
    {
        static void Main(string[] args)
        {
            //{
            //    int again = 1;  
            //    while(again==1)
            //    {
            //        int x = 1, marks, min = 100, max = 0, sum = 0;
            //        int option;
            //        double avg;
            //        Console.WriteLine("Enter number of scores you want to enter!!");
            //        option = Convert.ToInt16(Console.ReadLine());
            //        do
            //        {
            //            Console.Write("Enter Mark " + x + " :");
            //            marks = Convert.ToInt16(Console.ReadLine());
            //            sum += marks;
            //            if (marks < min)
            //                min = marks;
            //            if (marks > max)
            //                max = marks;
            //            x++;

            //        } while (x <= option);
            //        Console.WriteLine();

            //        avg = sum / option;
            //        Console.WriteLine("Sum of marks = " + sum);
            //        Console.WriteLine("Highest mark= " + max);
            //        Console.WriteLine("lowest mark = " + min);
            //        Console.WriteLine("Average mark = " + (avg.ToString("n3")));
            //        Console.WriteLine();
            //        Console.WriteLine("ENTER 1 TO RUN AGAIN");
            //        again = Convert.ToInt16(Console.ReadLine());


            //    }
            //    Console.ReadKey();
            int a;
            Console.WriteLine("Enter Only Even Number");
            a = Convert.ToInt16(Console.ReadLine());
            while (!(a%2==0))
            {
                Console.WriteLine("Enter only even number");
                a = Convert.ToInt16(Console.ReadLine());
            }    
        }
    }
}
