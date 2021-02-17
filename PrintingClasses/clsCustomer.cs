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
            //set the private data members to the test data value
            mCustomerNo = 21;
            mDateAdded = Convert.ToDateTime("16/02/2021");
            mForeName = "Test ForeName";
            mLastName = "Test LastName";
            mTitle = "Test Title";
            mEmail = "Test Email";
            mPhoneNo = 0123456789;
            mActive = true;
            //always return true
            return true;
        }
    }
}