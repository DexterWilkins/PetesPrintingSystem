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

       public string Vaild(string deliveryDate, string OrderDate, string partNo)
       {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
           // if (PartNo.Length == 0)
            {
                //record the error
                Error = Error + "The part no may not be blank : ";
            }
            //if the house no is greater than 6 characters
           // if (PartNo.Length > 6)
            {
                //record the error
                Error = Error + "The part no must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DeliveryDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;

        }
    }
}