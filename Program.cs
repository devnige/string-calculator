using System.Transactions;
using System.Reflection.PortableExecutable;
using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace string_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the string calculator!");
        }
    }

    public class StringCalculator
    {
        public int Add(string str)
        {
            if (str == null || str == string.Empty)
            {
                return 0;
            }
            else if (str.Length == 1)
            {
                return Int32.Parse(str);
            }
            else 
            {
                var sum = 0;
                // Need to split the string using delimiter ","
                
                var charSeparators = new char[] { ' ', ',' };
                var subs = str.Split(charSeparators).ToList();
                var numsList = subs.Select(s => int.Parse(s)).ToList();
                // Add up the int for each element
                foreach (var num in numsList)
                    {
                        sum += num;
                    }
                return sum;
                
                
            }
        }       
    }
}
