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

        public string Valid(string StockNo, string StockDescription, string StockLocation, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the StockNo is blank
            if (StockNo.Length == 0)
            {
                //record the error
                Error = Error + "The Stock no may not be blank : ";
            }
            //if the Stock no is greater than 6 characters
            if (StockNo.Length > 6)
            {
                //record the error
                Error = Error + "The Stock no must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
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
            //is the StockDescription blank
            if (StockDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Stock Description may not be blank : ";
            }
            //if the StockDescription is too long
            if (StockDescription.Length > 50)
            {
                //record the error
                Error = Error + "The Stock Description must be less than 50 characters : ";
            }
            //is the StockLocation blank
            if (StockLocation.Length == 0)
            {
                //record the error
                Error = Error + "The Stock Location may not be blank : ";
            }
            //if the StockLocation is too long
            if (StockLocation.Length > 50)
            {
                //record the error
                Error = Error + "The Stock Location must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }


    }
}