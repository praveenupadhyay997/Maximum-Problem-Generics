using MaximumProblemGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumProblemMSTest
{
    [TestClass]
    public class MSTestClass
    {
        MaximumClass maximumClass = null;
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
                maximumClass = new MaximumClass();
                //Act
                int expected = first;
                int actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == 30)
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                int expected = second;
                int actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                int expected = third;
                int actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
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
                maximumClass = new MaximumClass();
                //Act
                float expected = first;
                float actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == 30.5)
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                float expected = second;
                float actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                float expected = third;
                float actual = MaximumClass.MaximumNumberAmongThree(first, second, third);
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
                maximumClass = new MaximumClass();
                //Act
                string expected = first;
                string actual = MaximumClass.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else if (second == "Peach")
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                string expected = second;
                string actual = MaximumClass.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            else
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                string expected = third;
                string actual = MaximumClass.MaximumAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
