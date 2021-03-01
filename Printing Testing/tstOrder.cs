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
        public void ActivePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean TestData = true;

            AnOrder.Active = TestData;

            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.DeliveryDate = TestData;

            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }
    }
}
