using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public static class TestClass
    {
        public static Tuple<string,int, double> Calulate()
        {
            
                string name="x";
                int age=11;
                double weight=2.0;
           
            try
            {

                Tuple<string, int, double> t= Tuple.Create(name,age,weight);
                return t;
               

            }
            catch(Exception e)
            {
                throw new NotImplementedException("TODO", e);
            }
            
            
            //Creating an object of Tuple class by calling the static Create method
            
            //Returning the tuple instance
            
        }
    }
}
