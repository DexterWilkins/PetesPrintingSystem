using System.Collections.Generic;

namespace PrintingClasses
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }

        public clsOrderCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

           // PopulateArray(DB);
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@PartNo", mThisOrder.PartNo);

            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}