using System;
using System.Collections.Generic;

namespace MethodOverloadingPractice
{
    class Program
    {
        //TODO Create a method that takes two string names in the parameter. Have the method tell you which name is longer.
        public static void Names(string a, string b)
        {
            if(a.Length > b.Length)
			{
                Console.WriteLine($"{a} is longer.");
			}
			else if (a.Length < b.Length) 
			{
                Console.WriteLine($"{b} is longer.");
            }
			else
			{
                Console.WriteLine($"{a} and {b} are the same.");
            }

        }
        //TODO Create an overload method that takes a list of string names and an integer. The method will look for the first name that matches the length of the integer.
        public static void Names(List<string> nameList, int length)
		{
            bool nameExists = false;
            foreach (string name in nameList)
			{
                if(name.Length == length)
				{
                    Console.WriteLine($"{name} is the first name that is {length} letters long.");
                    nameExists = true;
                    break;
				}
			}

            if (nameExists == false)
			{
                Console.WriteLine($"Could not find name that is {length} letters long.");
			}
		}
        static void Main(string[] args)
        {
            List<string> listOfNames = new List<string>();
            listOfNames.Add("Chuck");
            listOfNames.Add("Mary");
            listOfNames.Add("Richard");

            //TODO Call both methods here. Use a break point and watch as the code jumps to the different method overloads.
            Names("abcdefg", "abcdejg");
            Names(listOfNames, 4);
        }

     
    }
}
