using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;

namespace Printing_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void StockInstanceOK()
        {
            //create an instance of the class
            clsStock stock = new clsStock();
            //test that it exists
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void StockDateAddedPropertyOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //create test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            stock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.DateAdded, TestData);
        }

        [TestMethod]
        public void StockNoPropertyOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //create test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            stock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.StockNo, TestData);
        }

        [TestMethod]
        public void StockDescriptionOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //create test data to assign to the property
            string TestData = "Part";
            //assign the data to the property
            stock.StockDescription = TestData;
            Assert.AreEqual(stock.StockDescription, TestData);
        }

        [TestMethod]
        public void StockLocationOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //create test data to assign to the property
            string TestData = "Warehouse";
            //assign the data tp the property
            stock.StockLocation = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.StockLocation, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //create test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            stock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.InStock, TestData);
        }
    }
}
