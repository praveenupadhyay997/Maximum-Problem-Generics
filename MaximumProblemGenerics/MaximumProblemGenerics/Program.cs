// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MaximumProblemGenerics
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Welcome to Maximum Computation Problem");
            Console.WriteLine("======================================");
            //Calling to get the integral maximum value
            int maximumNumber = MaximumClass.MaximumNumberAmongThree(10, 30, 20);
            //Exception condition when all equal numbers are passed
            if (maximumNumber == 0)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximumNumber);
            //Calling to get the floating point maximum value
            float maximum = MaximumClass.MaximumNumberAmongThree(10.5f, 15.5f, 20.6f);
            //Exception condition when all equal numbers are passed
            if (maximumNumber == 0)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximum);
            //Calling to get the string maximum value
            string maximumWordLexicographically = MaximumClass.MaximumAmongThree("Apple","Peach", "Banana");
            //Exception condition when all equal numbers are passed
            if (maximumWordLexicographically == "Same")
                Console.WriteLine("All three Words are Same");
            else
                Console.WriteLine("Maximum Word Lexicographically=" + maximumWordLexicographically);
        }
    }
}
