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
        private DateTime mDeliveryDate;

        public DateTime DeliveryDate
        {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }

        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            } 
            set
            {
                mOrderDate = value;
            }
        }

        private Int32 mPartNo;

        public int PartNo
        {
            get
            {
                return mPartNo;
            }
            set
            {
                mPartNo = value;
            }
        }
        
        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record id found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mPartNo = Convert.ToInt32(DB.DataTable.Rows[0]["PartNo"]);
                //always reture true
                return true;
            }
            else
            {
                return false;

            }
           
        }


    }
}