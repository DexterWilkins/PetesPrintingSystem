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
        public void StockDateAddedOK()
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
        public void StockNoOK()
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

        [TestMethod]
        public void StockFindMethodOK()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockNo = 1;
            //invoke the method
            Found = stock.Find(StockNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void StockNoFound()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with thte method
            Int32 StockNo = 1;
            //invoke the method
            Found = stock.Find(StockNo);
            //check the StockNo
            if (stock.StockNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockDateAddedFound()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 1;
            //invoke the method
            Found = stock.Find(StockNo);
            //check the property
            if (stock.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StockDescriptionFound()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            //create some test data to use with the method
            string StockDescription = "Part";
            //invoke the method
            Found = stock.Find(StockDescription);
            //check the property
            if (stock.StockDescription !="Part")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}