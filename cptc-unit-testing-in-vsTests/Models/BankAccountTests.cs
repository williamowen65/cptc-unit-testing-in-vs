using Microsoft.VisualStudio.TestTools.UnitTesting;
using cptc_unit_testing_in_vs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cptc_unit_testing_in_vs.Models.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void Deposit_PositiveAmt_ReturnsCorrectBalance()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Deposit_NegativeAmt_ThrowsArgumentException()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Withdraw_PositiveAmt_ReturnsCorrectBalance()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Withdraw_NegativeAmt_ThrowsArgumentException()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Withdraw_Overdraft_ThrowsInvalidOperationException()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Balance_SetFromOutside_ThrowsException()
        {
            Assert.Fail();
        }


        [TestMethod()]
        public void Owner_SetFromOutside_ThrowsException()
        {
            Assert.Fail();
        }

   
    }
}