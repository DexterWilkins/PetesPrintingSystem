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

        public string Valid(string title, string foreName, string lastName, string email, string PhoneNo, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Title is blank
            if (title.Length == 0)
            {
                //record the error
                Error = Error + "The Title may not be blank : ";
            }
            //if title is greater than 4 characters
            if (title.Length > 4)
            {
                //record the error
                Error = Error + "The title must be less than 5 characters : ";
            }
            //if phone no is blank
            if (PhoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }
            //if phone no is less than 10 characters
            if (PhoneNo.Length < 10)
            {
                //record the error
                Error = Error + "The phone number must be atleast 10 characters : ";
            }
            //if phone no is greater than 12 characters
            if (PhoneNo.Length > 12)
            {
                //record the error
                Error = Error + "The phone number must be less than 13 characters : ";
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

            // if the forename blank
            if (foreName.Length == 0)
            {
                //record the error
                Error = Error + "The fore name may not be blank : ";
            }

            // if the forename is too long
            if (foreName.Length > 25)
            {
                Error = Error + "The forename must be less than 25 characters : ";
            }

            // if the lastname blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The fore name may not be blank : ";
            }

            // if the lastname is too long
            if (lastName.Length > 25)
            {
                Error = Error + "The forename must be less than 25 characters : ";
            }

            // if the email blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }

            // if the email is too long
            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters : ";
            }



            //return any error message
            return Error;
        }


    }
}