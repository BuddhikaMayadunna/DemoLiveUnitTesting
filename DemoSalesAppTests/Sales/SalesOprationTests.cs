using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoSalesApp.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSalesApp.Sales.Tests
{
    [TestClass()]
    public class SalesOprationTests
    {
        [TestMethod()]
        public void CalculateTaxIncludedTotalTest_EmptySubTotal_return0()
        {
            var salesOparation = new SalesOpration();
            double expected = 112;
            double subTotal = 100;
            double taxPercentage = 12;

            var TaxIncludedSubTotal = salesOparation.CalculateTaxIncludedTotal(subTotal, taxPercentage);
            Assert.AreEqual(expected, TaxIncludedSubTotal);
        }
    }
}