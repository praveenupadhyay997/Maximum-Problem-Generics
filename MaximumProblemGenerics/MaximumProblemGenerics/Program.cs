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
            int maximumNumber = MaximumClass.MaximumIntegerNumberAmongThree(10, 30, 20);
            if (maximumNumber == 0)
                Console.WriteLine("All three Numbers are equal");
            else
                Console.WriteLine("Maximum Number =" + maximumNumber);
        }
    }
}
