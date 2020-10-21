// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaximumGenericClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MaximumProblemGenerics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MaximumGenericClass<T> where T : IComparable
    {
        /// <summary>
        /// Member variable defined for three inputs
        /// </summary>
        public T first, second, third;

        /// <summary>
        /// Parameterised constructor for thr generic inputs
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public MaximumGenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;            
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
        /// <summary>
        /// Internally calling the function that returns the maximum value after comparison
        /// </summary>
        /// <returns></returns>
        public T MaximumMethod()
        {
            T maximumValue = MaximumGenericClass<T>.MaximumAmongThreeGenericInput(this.first, this.second, this.third);
            //REturning the generic output
            return maximumValue;
        }
    }
}
