﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaximumClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MaximumProblemGenerics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MaximumClass <T> where T: IComparable
    {
        /// <summary>
        /// Function to find the maximum number number among passed three integral values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static int MaximumNumberAmongThree(int first, int second, int third)
        {
            //Use of Compare to function so as to compute the maximum values
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            //Returning zero in case user has passed same number for all three
            else
                return 0;
        }

        /// <summary>
        /// Function to find the maximum number number among passed three floating point values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static float MaximumNumberAmongThree(float first, float second, float third)
        {
            //Use of Compare to function so as to compute the maximum values
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            //Returning zero in case user has passed same number for all three
            else
                return 0;
        }

        /// <summary>
        /// Function to find the maximum among passed three string values lexicographically
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static string MaximumAmongThree(string first, string second, string third)
        {
            //Use of Compare to function so as to compute the maximum values on basis of difference lexicographically
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            //Returning zero in case user has passed same number for all three
            else
                return "Same";
        }

        /// <summary>
        /// Function to find the maximum among passed three generic values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static T MaximumAmongThreeGenericInput(T first, T second, T third)
        {
            //Use of Compare to function so as to compute the maximum values on basis of difference lexicographically
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            //Returning zero in case user has passed same number for all three
            else
                return default(T);
        }
    }
}
