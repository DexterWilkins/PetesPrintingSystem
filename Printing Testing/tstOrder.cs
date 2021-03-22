using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;

namespace Printing_Testing
{
    [TestClass]
    public class tstOrder
    {
        
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see if the result is true
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DeliveryDateOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.DeliveryDate = TestData;
            //test to see if the result is true
            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.OrderDate = TestData;
            //test to see if the result is true
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderNoOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.OrderNo = TestData;
            //test to see if the result is true
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void PartNoOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.PartNo = TestData;
            //test to see if the result is true
            Assert.AreEqual(AnOrder.PartNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderNo = 32;

            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderNo = 21;

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.OrderNo != 21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderNo = 21;

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.DeliveryDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderNo = 21;

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPartNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderNo = 21;

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.PartNo != 13)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void VaildMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store
            string Error = "";
            //invoke the method
            Error = AnOrder.Vaild(DeliveryDate, DateDeilvered, PartNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
