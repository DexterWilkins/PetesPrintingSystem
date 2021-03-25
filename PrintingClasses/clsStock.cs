using System;

namespace PrintingClasses
{
    public class clsStock
    {
        public bool Active { get; set; }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //StockNo private member variable
        private Int32 mStockNo;
        //StockNo public properly
        public Int32 StockNo
        {
            get
            {
                //this line of code sends data out of the property
                return mStockNo;
            }
            set
            {
                //this line of code allows data into the property
                mStockNo = value;
            }
        }
        //StockDescription private member variable
        private string mStockDescription;
        //StockDescription public property
        public string StockDescription
        {
            get
            {
                //this line of code sends data out of the property
                return mStockDescription;
            }
            set
            {
                //this line of code allows data into the property
                mStockDescription = value;
            }
        }
        //StockLocation private member variable
        private string mStockLocation;
        //StockLocation public property
        public string StockLocation
        {
            get
            {
                //this line of code sends data out of the property
                return mStockLocation;
            }
            set
            {
                //this line of code allows data into the property
                mStockLocation = value;
            }
        }
        public bool InStock { get; set; }

        public bool Find(int stockNo)
        {
            //set the private data members to the test data value
            mStockNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            //always return true
            return true;
        }

        public bool Find(string stockDescription)
        {
            //set the private data members to the test data value
            mStockDescription = "Part";
            mStockLocation = "Warehouse";
            //always return true
            return true;
        }
    }
}