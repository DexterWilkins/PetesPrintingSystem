using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;
using System.Collections.Generic;

namespace Printing_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class i want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            clsStock TestItem = new clsStock();
            //set properties
            TestItem.InStock = true;
            TestItem.StockNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Part";
            TestItem.StockLocation = "Warehouse";
            //add the item to the list
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of thte class I want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.StockNo = 2;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.StockDescription = "Part";
            TestStock.StockLocation = "Warehouse";
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            clsStock TestItem = new clsStock();
            //set it's properties
            TestItem.InStock = true;
            TestItem.StockNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Part";
            TestItem.StockLocation = "Warehouse";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //seet it's properties
            TestItem.InStock = true;
            TestItem.StockNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Part";
            TestItem.StockLocation = "Warehouse";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primaryKey of the test data
            TestItem.StockNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //seet it's properties
            TestItem.InStock = true;
            TestItem.StockNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Part";
            TestItem.StockLocation = "Warehouse";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primaryKey of the test data
            TestItem.StockNo = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class I want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //seet it's properties
            TestItem.InStock = true;
            TestItem.StockNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Part";
            TestItem.StockLocation = "Warehouse";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primaryKey of the test data
            TestItem.StockNo = PrimaryKey;
            //modify the test data
            TestItem.InStock = false;
            TestItem.StockNo = 3;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockDescription = "Tray";
            TestItem.StockLocation = "Store Front";
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
    }
}
