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
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DeliveryDateOk()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.DeliveryDate = TestData;

            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }

        [TestMethod]
        public void OrderDateOk()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.OrderDate = TestData;

            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderNoOk()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.OrderNo = TestData;

            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void PartNoOk()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.PartNo = TestData;

            Assert.AreEqual(AnOrder.PartNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderNo = 32;

            Found = AnOrder.Find(OrderNo);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderNo = 21;

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.OrderNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
