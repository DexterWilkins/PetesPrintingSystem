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

       


    }
}
