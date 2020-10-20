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
        [TestMethod]
        public void TestMethodForIntegralInputs(int first, int second, int third)
        {
            if (first == 30)
            {
                //Arrange
                maximumClass = new MaximumClass();
                //Act
                int expected = first;
                int actual = MaximumClass.MaximumIntegerNumberAmongThree(first, second, third);
                //Assert
                Assert.AreEqual(expected, actual);
            }
         }
    }
}
