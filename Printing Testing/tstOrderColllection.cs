using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;
using System.Collections.Generic;

namespace Printing_Testing
{
    [TestClass]
    public class tstOrderColllection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //tests the connection
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be listed of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of testdata
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.PartNo = 1234567;
            //add the item to the Test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the propertise of the test object
            TestOrder.OrderNo = 1;
            TestOrder.DeliveryDate = DateTime.Now.Date;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.PartNo = 1234567;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCount()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the propert
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set it's properties
            TestItem.OrderNo = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.PartNo = 1234567;
            //add the items to that test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two vlaues are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //string variable to store
            clsOrder TestItems = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItems.OrderNo = 1;
            TestItems.DeliveryDate = DateTime.Now.Date;
            TestItems.OrderDate = DateTime.Now.Date;
            TestItems.PartNo = 12345;

            AllOrders.ThisOrder = TestItems; 

            //PrimaryKey.ThisOrder.Add();

            TestItems.OrderNo = PrimaryKey;

           AllOrders.ThisOrder.Find(PrimaryKey);
           //test to see that the result is correct
           Assert.AreEqual(AllOrders.ThisOrder, TestItems);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //string variable to store
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.OrderNo = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.PartNo = 1234567;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderDate = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNo = PrimaryKey;
            //modify the test data
            
            TestItem.DeliveryDate = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
