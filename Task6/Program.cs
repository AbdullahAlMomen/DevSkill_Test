using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
       static int fibSeries(int n)
        {
            if(n <= 1)
                return n;
            return fibSeries(n - 1) + fibSeries(n - 2);
        }
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 15)
            {
                Console.WriteLine(fibSeries(N));
            }
            else
            {
                Console.WriteLine("Value of N shouldbe less than 15");
            }

            Console.ReadLine();


        }
    }
}
