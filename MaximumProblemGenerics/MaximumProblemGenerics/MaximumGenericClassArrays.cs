// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaximumGenericClassArrays.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace MaximumProblemGenerics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MaximumGenericClassArrays<T> where T: IComparable
    {
        /// <summary>
        /// Member variable as array to take in multiple inputs
        /// </summary>
        public T[] arrayValue;

        /// <summary>
        /// PArameterise constructor to instantinate the object of the class with array variable
        /// </summary>
        /// <param name="arrayValue"></param>
        public MaximumGenericClassArrays(T[] arrayValue)
        {
            this.arrayValue = arrayValue;
        }

        /// <summary>
        /// Sorting the passed array in ascending order to get the maximum value easily
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public T[] SortingTheArray(T[] array)
        {
            Array.Sort(array);
            return array;
        }

        /// <summary>
        /// Getting the maximum value peresent at Length-1 position
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public T MaximumValue(T[] array)
        {
            var SortedArray = SortingTheArray(array);
            //Returning the n-1 the position of the array
            return SortedArray[^1];
        }
        /// <summary>
        /// Method for internal calling the Max Value Method
        /// </summary>
        /// <returns></returns>
        public T MaximumMethod()
        {
            var maximumValue = MaximumValue(this.arrayValue);
            return maximumValue;
        }
        /// <summary>
        /// UC-5 Printing the maximum value on basis of internal calling of maximum method
        /// </summary>
        public void PrintMaximumValue()
        {
            var maximumValue = MaximumValue(this.arrayValue);
            Console.WriteLine("Maximum Value in the Array = " + maximumValue);
        }

    }
}
