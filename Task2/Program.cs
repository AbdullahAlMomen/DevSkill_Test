﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        
        static string PascalCase(string s)
        {
            
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static void Main(string[] args)
        {
            string s = PascalCase("birth_date");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
