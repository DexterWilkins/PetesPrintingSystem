using System;

namespace PrintingClasses
{
    public class clsOrder
    {
        private Int32 mOrderNo;

        public Int32 OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }

        //public bool Active { get; set; }

        public DateTime DeliveryDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int PartNo { get; set; }
        

        public bool Find(int orderNo)
        {
            mOrderNo = 21;

            return true;
        }


    }
}