using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintingClasses;

namespace Printing_Testing
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
        }
    }
}
