using CustomerData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Author: Rebecca Allan
 * Date: January 2022
 * Purpose: Unit tests to test the CalculateCharge method
 */

namespace CustomerDataTests
{
    [TestClass()]
    public class AccountTests
    {
        // positive usage test
        [TestMethod()]
        public void CalculateChargePositiveTest()
        {
            // arrange
            Customer cust = new Customer("John", "Smith", 102);
            decimal expectedCharge = 19.14m;
            decimal actualCharge;

            // act
            actualCharge = cust.CalculateCharge();

            // assert
            Assert.AreEqual((double)expectedCharge, (double)actualCharge);
        }

        // negative usage test
        [TestMethod()]
        public void CalculateChargeNegativeTest()
        {
            // arrange
            Customer cust = new Customer("John", "Smith", -413);
            decimal expectedCharge = 0m;
            decimal actualCharge;

            // act
            actualCharge = cust.CalculateCharge();

            // assert
            Assert.AreEqual((double)expectedCharge, (double)actualCharge);
        }

        // test for zero usage
        [TestMethod()]
        public void CalculateChargeZeroTest()
        {
            // arrange
            Customer cust = new Customer("John", "Smith", 0);
            decimal expectedCharge = 0m;
            decimal actualCharge;

            // act
            actualCharge = cust.CalculateCharge();

            // assert
            Assert.AreEqual((double)expectedCharge, (double)actualCharge);
        }
    }
}
