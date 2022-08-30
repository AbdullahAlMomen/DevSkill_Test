using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        public static void listInput(List<int>templist)
        {
            Console.WriteLine("Enter number of value in list : ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value in list : ");
            for (var i = 0; i < n; i++)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                templist.Add(val);
            }
           
        }
        public static void filter(List<int> templist)
        {
            List<int> FilterList = templist.FindAll(x => x > 50 ? true : false);
            Console.WriteLine("Value greater than 50  in the templist are : ");
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int i = 0;
            List<int> templist = new List<int>();
            listInput(templist);
            filter(templist);

           
            
            
        }
    }
}
