using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;
using System.Collections.Generic;

namespace Printing_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Title = "Mr";
            TestItem.ForeName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "JohnSmith123@hotmail.com";
            TestItem.PhoneNo = 0123456789;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to test test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties of the test object
            TestCustomer.Active = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.Title = "Mr";
            TestCustomer.ForeName = "John";
            TestCustomer.LastName = "Smith";
            TestCustomer.Email = "JohnSmith123@hotmail.com";
            TestCustomer.PhoneNo = 0123456789;
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Title = "Mr";
            TestItem.ForeName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "JohnSmith123@hotmail.com";
            TestItem.PhoneNo = 0123456789;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to test test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Title = "Mr";
            TestItem.ForeName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "JohnSmith123@hotmail.com";
            TestItem.PhoneNo = 0123456789;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Title = "Mr";
            TestItem.ForeName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "JohnSmith123@hotmail.com";
            TestItem.PhoneNo = 0123456789;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Title = "Mr";
            TestItem.ForeName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "JohnSmith123@hotmail.com";
            TestItem.PhoneNo = 0123456789;
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerNo = 2;
            TestItem.Title = "Mrs";
            TestItem.ForeName = "Jennifer";
            TestItem.LastName = "Smith";
            TestItem.Email = "JenSmith123@hotmail.com";
            TestItem.PhoneNo = 0123459999;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string 
            FilteredCustomers.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string 
            FilteredCustomers.ReportByLastName("xxxxxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

    }
}
