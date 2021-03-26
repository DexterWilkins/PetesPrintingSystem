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
        public clsStock ThisStock { get; set; }

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
    }
}