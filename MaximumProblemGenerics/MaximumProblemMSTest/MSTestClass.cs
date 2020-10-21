using MaximumProblemGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MaximumProblemMSTest
{
    [TestClass]
    public class MSTestClass
    {
        [TestCategory("Maximum Check For Integer")]
        // TC 1.1- Giving the maximum number at first position and comparing with the max number returned from maximum function
        [DataRow(30, 20, 10)]
        // TC 1.2- Giving the maximum number at second position and comparing with the max number returned from maximum function
        [DataRow(20, 30, 10)]
        // TC 1.3- Giving the maximum number at third position and comparing with the max number returned from maximum function
        [DataRow(20, 10, 30)]
        [TestMethod]
        public void TestMethodForIntegralInputs(int first, int second, int third)
        {
            if (first == 30)
            {
                //Arrange
                MaximumClass<int> maximumClass = new MaximumClass<int>();
                //Act
                int expected = first;
                int actual = MaximumClass<int>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == 30)
            {
                //Arrange
                MaximumClass<int> maximumClass = new MaximumClass<int>();
                //Act
                int expected = second;
                int actual = MaximumClass<int>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                MaximumClass<int> maximumClass = new MaximumClass<int>();
                //Act
                int expected = third;
                int actual = MaximumClass<int>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCategory("Maximum Check For Floating Point Values")]
        // TC 2.1- Giving the maximum number at first position and comparing with the max number returned from maximum function
        [DataRow(30.5f, 20.5f, 10.5f)]
        // TC 2.2- Giving the maximum number at second position and comparing with the max number returned from maximum function
        [DataRow(20.5f, 30.5f, 10.5f)]
        // TC 2.3- Giving the maximum number at third position and comparing with the max number returned from maximum function
        [DataRow(10.5f, 20.5f, 30.5f)]
        [TestMethod]
        public void TestMethodForFloatInputs(float first, float second, float third)
        {
            if (first == 30.5)
            {
                //Arrange
                MaximumClass<float> maximumClass = new MaximumClass<float>();
                //Act
                float expected = first;
                float actual = MaximumClass<float>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == 30.5)
            {
                //Arrange
                MaximumClass<float> maximumClass = new MaximumClass<float>();
                //Act
                float expected = second;
                float actual = MaximumClass<float>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                MaximumClass<float> maximumClass = new MaximumClass<float>();
                //Act
                float expected = third;
                float actual = MaximumClass<float>.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestCategory("Maximum Check For String Values")]
        // TC 2.1- Giving the maximum number at first position and comparing with the max value returned from maximum function
        [DataRow("Peach", "Apple", "Banana")]
        // TC 2.2- Giving the maximum number at second position and comparing with the max value returned from maximum function
        [DataRow("Apple", "Peach", "Banana")]
        // TC 2.3- Giving the maximum number at third position and comparing with the max value returned from maximum function
        [DataRow("Apple", "Banana", "Peach")]
        [TestMethod]
        public void TestMethodForStringInputs(string first, string second, string third)
        {
            if (first == "Peach")
            {
                //Arrange
                MaximumClass<string> maximumClass = new MaximumClass<string>();
                //Act
                string expected = first;
                string actual = MaximumClass<string>.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == "Peach")
            {
                //Arrange
                MaximumClass<string> maximumClass = new MaximumClass<string>();
                //Act
                string expected = second;
                string actual = MaximumClass<string>.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                MaximumClass<string> maximumClass = new MaximumClass<string>();
                //Act
                string expected = third;
                string actual = MaximumClass<string>.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
