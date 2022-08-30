using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        public static void Print(Dictionary<string, int> dict)
        {
            foreach (KeyValuePair<string, int> entry in dict)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }

        public static void insert(Dictionary<string, int> dict)
        {
            Console.WriteLine("Enter the Number of inputs");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Name " + i + 1 + " : ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Age " + i + 1 + " : ");
                int Age = Convert.ToInt32(Console.ReadLine());
                dict.Add(Name, Age);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            insert(dict);
            Print(dict);
            Console.ReadLine();        
        }
    }
}
