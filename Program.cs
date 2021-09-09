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
                
                // Linq query 
                // var nums = subs.Select(CharUnicodeInfo).ToArray;

                // Some notes on Linq
                // Linq is a bunch of methods on arrays that makes working with arrays simpler
                // Can inspect and manipulate arrays (collections of elements)

                // Sample Linq query
                // Take all instances of "nigel" and change to "Nigel"

                // var names = new List<string>()
                // {
                //     "nigel",
                //     "luke",
                //     "bob",
                //     "nigel"
                // };
                // {} allows you to call a constructor and initialise the class with values

                // var newNames = names.Where(x => x == "nigel").Select(x => $"{x[0].ToString().ToUpper()}{x.Substring(1)}");
                // returns a filtered collection with two "nigels"
                // have access to every Linq query on the filtered list
                // left with a list <"N", "N">
                // use string interpolation to join the "N" with the substring "igel"
                // returns a Linq object which is a lightweight list not an actual list
            
                // list<list> has more functionality built into it
                // look up documentation methods

                
            }
        }       
    }
}
