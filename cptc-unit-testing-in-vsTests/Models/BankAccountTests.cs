using Microsoft.VisualStudio.TestTools.UnitTesting;
using cptc_unit_testing_in_vs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace cptc_unit_testing_in_vs.Models.Tests
{
    [TestClass()]
    public class BankAccountTests
    {

        private BankAccount ba; // Global variable

        [TestInitialize]
        public void CreateDefaultAccount() // needs to be public, not private
        {
            // Arrange
            ba = new BankAccount("Mr. Bryan Walton", 11.99m);
        }


        [TestMethod()]
        [DataRow(5.77)]
        [DataRow(0.73)]
        [DataRow(23.47)]
        [DataRow(6.57)]
        public void Deposit_PositiveAmt_ReturnsCorrectBalance(double data) {

            // Arrange
            decimal currentBalance = ba.Balance;

            // Act
           decimal returnedBalance = ba.Deposit((decimal)data);

            // Assert
            //Assert.AreEqual(currentBalance  + (decimal)data, ba.Balance);
            Assert.AreEqual(returnedBalance, ba.Balance);
        }

        [TestMethod()]
        [DataRow(5.77)]
        [DataRow(0.73)]
        [DataRow(23.47)]
        [DataRow(6.57)]
        public void Deposit_PositiveAmt_ActuallyUpdatesTheInternalBalance(double data)
        {

            // Arrange
            decimal currentBalance = ba.Balance;

            // Act
            ba.Deposit((decimal)data);

            // Assert
            Assert.AreEqual(currentBalance  + (decimal)data, ba.Balance);
        }




        [TestMethod()]
        public void Deposit_NegativeAmt_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            // Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ba.Deposit(-1));
        }

        [TestMethod()]
        public void Withdraw_PositiveAmt_ReturnsCorrectBalance()
        {
            // Arrange
            // Act
            decimal returnedBalance = ba.Withdraw(5.77m);
            // Assert
            Assert.AreEqual(ba.Balance, returnedBalance);
        }

        [TestMethod()]
        public void Withdraw_NegativeAmt_ThrowsArgumentOutOfRangeException()
        {
           Assert.ThrowsException<ArgumentOutOfRangeException>(() => ba.Withdraw(-1));
        }

        [TestMethod()]
        public void Withdraw_Overdraft_ThrowsInvalidOperationException()
        {

            Assert.AreEqual(11.99m, ba.Balance); // Assuming the balance is 11.99m

            Assert.ThrowsException<InvalidOperationException>(() => ba.Withdraw(100));
        }

        [TestMethod()]
        public void Balance_IsPrivateField_WouldThrowException()
        {
            // Arrange
            var balanceProperty = typeof(BankAccount).GetProperty("Balance");

            // Act
            var setter = balanceProperty?.GetSetMethod(true);

            // Assert
            Assert.IsTrue(setter == null || setter.IsPrivate, "The Balance setter is not private.");
        }


        [TestMethod()]
        public void Owner_SetFromOutside_ThrowsException()
        {
            // Arrange
            var OwnerProperty = typeof(BankAccount).GetProperty("Owner");

            // Act
            var setter = OwnerProperty?.GetSetMethod(true);

            // Assert
            Assert.IsTrue(setter == null || setter.IsPrivate, "The Owner setter is not private.");
        }

   
    }
}