using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;

namespace Printing_Testing
{
    [TestClass]
    public class tstCustomer1
    {

        //good test data
        //create some test data to pass to the method
        string Title = "MR";
        string ForeName = "Jon";
        string LastName = "Jonathon";
        string Email = "JonJonathon@hotmail.com";
        string PhoneNo = "0123456789";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerForeNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Jon";
            //Assign the data to the property
            ACustomer.ForeName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ForeName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Smith";
            //Assign the data to the property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void CustomerTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Mr";
            //Assign the data to the property
            ACustomer.Title = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Title, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "JonSmith@hotmail.com";
            //Assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);           
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);                 
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.DateAdded != Convert.ToDateTime("16/02/2021"))
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestForeNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.ForeName != "Jon")
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.LastName != "Jonathan")
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Title != "Mr")
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Email != "JonJonathan@hotmail.com")
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.PhoneNo != 1234567891)
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
        }

        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "M"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "Mr"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "Mrs"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "Miss"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "Ms"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusone()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "Misss"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
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
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
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
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
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
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "a"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "aa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "aaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ForenameMaxPlusone()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ForenameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ForeName = "";
            ForeName = ForeName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxPlusone()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusone()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
            
                
    }
}
