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
            int maximumNumber = MaximumClass<int>.MaximumAmongThreeGenericInput(10, 30, 20);
            //Exception condition when all equal numbers are passed
            if (maximumNumber == 0)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximumNumber);
            //Calling to get the floating point maximum value
            float maximum = MaximumClass<float>.MaximumAmongThreeGenericInput(10.5f, 15.5f, 20.6f);
            //Exception condition when all equal numbers are passed
            if (maximumNumber == 0)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximum);
            //Calling to get the string maximum value
            string maximumWordLexicographically = MaximumClass<string>.MaximumAmongThreeGenericInput("Apple","Peach", "Banana");
            //Exception condition when all equal numbers are passed
            if (maximumWordLexicographically == "Same")
                Console.WriteLine("All three Words are Same");
            else
                Console.WriteLine("Maximum Word Lexicographically=" + maximumWordLexicographically);

            Console.WriteLine("=============================================");
            Console.WriteLine("Using the Maximum Generic Class Functionality");
            Console.WriteLine("=============================================");
            //Calling to get the integral maximum value
            int maximumValue = MaximumGenericClass<int>.MaximumAmongThreeGenericInput(10, 30, 20);
            //Exception condition when all equal numbers are passed
            if (maximumValue == default)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximumValue);
            //Calling to get the floating point maximum value
            float maximumFloatValue = MaximumGenericClass<float>.MaximumAmongThreeGenericInput(10.5f, 15.5f, 20.6f);
            //Exception condition when all equal numbers are passed
            if (maximumFloatValue == default)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximumFloatValue);
            //Calling to get the string maximum value
            string maximumStringValue = MaximumGenericClass<string>.MaximumAmongThreeGenericInput("Apple", "Peach", "Banana");
            //Exception condition when all equal numbers are passed
            if (maximumStringValue == default)
                Console.WriteLine("All three Words are Same");
            else
                Console.WriteLine("Maximum Word Lexicographically=" + maximumStringValue);

            Console.WriteLine("===================================================");
            Console.WriteLine("Using the Maximum Generic Array Class Functionality");
            Console.WriteLine("===================================================");
            //Initialising an array to pass to the parameterised constructor
            int[] array = { 105, 203, 122, 432 };
            // Creating instance of the Maximum Generic Class for array and passing an array parameter
            MaximumGenericClassArrays<int> maximumGeneric = new MaximumGenericClassArrays<int>(array);
            // Calling the maximum method to get the largest value based on sorting
            maximumGeneric.PrintMaximumValue();
        }
    }
}
