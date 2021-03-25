using System;

namespace PrintingClasses
{
    public class clsStock
    {

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

        //InStock private member variable
        private bool mInStock;
        //InStock public property
        public bool InStock
        {
            get
            {
                //this line of code sends data out of the property
                return mInStock;
            }
            set
            {
                //this line of code allows data into the property
                mInStock = value;
            }
        }

        public bool Find(int stockNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StockNo to search for
            DB.AddParameter("@StockNo", stockNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the data base to the private data members
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockLocation = Convert.ToString(DB.DataTable.Rows[0]["StockLocation"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything is okay
                return true;
            }
            //if no record was found
            else
            {
                //return false
                return false;
            }
        }

        public bool Find(string stockDescription)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StockNo to search for
            DB.AddParameter("@StockDescription", stockDescription);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockDescription");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the data base to the private data members
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockLocation = Convert.ToString(DB.DataTable.Rows[0]["StockLocation"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                //return that everything is okay
                return true;
            }
            //if no record was found
            else
            {
                //return false
                return false;
            }
        }
    } 
}