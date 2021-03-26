using System;
using System.Collections.Generic;

namespace PrintingClasses
{
    public class clsStockCollection
    {
        private List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //
            }
        }

        private clsStock mThisStock = new clsStock();
        public clsStock ThisStock
        {
            get
            {
                //return private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock stock = new clsStock();
                //read in the fields from the current record
                stock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                stock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                stock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                stock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                stock.StockLocation = Convert.ToString(DB.DataTable.Rows[Index]["StockLocation"]);
                //add the record to the private data member
                mStockList.Add(stock);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for stored procedures
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockLocation", mThisStock.StockLocation);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@InStock", mThisStock.InStock);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            //execute the procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for stored procedures
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockLocation", mThisStock.StockLocation);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@InStock", mThisStock.InStock);
            //execute the procedure
            DB.Execute("sproc_tblStock_Update");
        }
    }
}