using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;

namespace Printing_Testing
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //create some test data to pass to the method
        string StockNo = "2";
        string StockDescription = "Part";
        string StockLocation = "Warehouse";
        string DateAdded = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class i want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void StockNoMin()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "a"; //this should be ok
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "aa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMax()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "aaaaaaa"; //this should fail
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoExtremeMax()
        {
            //create an instance of the class I want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "";
            StockNo = StockNo.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMid()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StockNo = "aaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockDescription = "";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMin()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockDescription = "a";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockDescription = "aa";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(49, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMax()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(50, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockDescription = "";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMid()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(25, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMinLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockLocation = "";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLocationMin()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockLocation = "a";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLocationMinPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockLocation = "aa";
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockLocationMaxLessOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(49, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLocationMax()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(50, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockLocationMaxPlusOne()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(51, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockLocationMid()
        {
            //create an instance of the class I want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(25, 'a');
            //invoke the method
            Error = Stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}