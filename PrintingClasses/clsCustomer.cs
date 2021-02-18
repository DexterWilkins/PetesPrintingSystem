using System;

namespace PrintingClasses
{
    public class clsCustomer
    {
        //private data member for the customer no property
        private Int32 mCustomerNo;
        //CustomerNo Public property
        public Int32 CustomerNo
        {
            get
            {
                //this line of code send data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }

        //private data member for the customer no property
        private DateTime mDateAdded;
        //CustomerNo Public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code send data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the customer no property
        private string mForeName;
        //CustomerNo Public property
        public string ForeName
        {
            get
            {
                //this line of code send data out of the property
                return mForeName;
            }
            set
            {
                //this line of code allows data into the property
                mForeName = value;
            }
        }

        //private data member for the customer no property
        private string mLastName;
        //CustomerNo Public property
        public string LastName
        {
            get
            {
                //this line of code send data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        //private data member for the customer no property
        private string mTitle;
        //CustomerNo Public property
        public string Title
        {
            get
            {
                //this line of code send data out of the property
                return mTitle;
            }
            set
            {
                //this line of code allows data into the property
                mTitle = value;
            }
        }

        //private data member for the customer no property
        private string mEmail;
        //CustomerNo Public property
        public string Email
        {
            get
            {
                //this line of code send data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //private data member for the customer no property
        private Int32 mPhoneNo;
        //CustomerNo Public property
        public Int32 PhoneNo
        {
            get
            {
                //this line of code send data out of the property
                return mPhoneNo;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNo = value;
            }
        }

        //private data member for the customer no property
        private Boolean mActive;
        //CustomerNo Public property
        public Boolean Active
        {
            get
            {
                //this line of code send data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }



        public bool Find(int customerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramteter for the customer no to search for
            DB.AddParameter("@CustomerNo", customerNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mForeName = Convert.ToString(DB.DataTable.Rows[0]["ForeName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }
}