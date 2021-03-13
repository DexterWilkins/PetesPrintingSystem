using System;

namespace PrintingClasses
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int PartNo { get; set; }
        public object OrderNo { get; set; }
    }
}