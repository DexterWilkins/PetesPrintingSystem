using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingClasses;

public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
           if (CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the title
        string Title = txtTitle.Text;
        //capture the forename
        string ForeName = txtForeName.Text;
        //capture the LastName
        string LastName = txtLastName.Text;
        //capture the email
        string Email = txtCustomerEmail.Text;
        //capture the phone no
        string PhoneNo = txtPhoneNo.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(Title, ForeName, LastName, Email, PhoneNo, DateAdded);
        if (Error == "")
        {
            //capture the title
            ACustomer.Title = Title;
            //capture the forename
            ACustomer.ForeName = ForeName;
            //capture the last name
            ACustomer.LastName = LastName;
            //capture the email
            ACustomer.Email = Email;
            //capture the phone no
            ACustomer.PhoneNo = Convert.ToInt32(PhoneNo);
            //capture the date added
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer oage
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        if (CustomerNo == -1)
        {
            //add the new record
            Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }
        else
        {
            //update the record
            Update();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault.aspx");
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create the instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        // Find the record
        Found = ACustomer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtTitle.Text = ACustomer.Title;
            txtForeName.Text = ACustomer.ForeName;
            txtLastName.Text = ACustomer.LastName;
            txtCustomerEmail.Text = ACustomer.Email;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();
            txtPhoneNo.Text = ACustomer.PhoneNo.ToString();
        }

        

     }

    void Add()
    {
        //create an instance of the customer class
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtForeName.Text, txtLastName.Text, txtCustomerEmail.Text, txtPhoneNo.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Customers.ThisCustomer.Title = txtTitle.Text;
            Customers.ThisCustomer.ForeName = txtForeName.Text;
            Customers.ThisCustomer.LastName = txtLastName.Text;
            Customers.ThisCustomer.Email = txtCustomerEmail.Text;
            Customers.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            Customers.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Customers.ThisCustomer.Active = checkboxActive.Checked;
            //add the record
            Customers.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    void Update()
    {
        //create an instance of the customer class
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtForeName.Text, txtLastName.Text, txtCustomerEmail.Text, txtPhoneNo.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            Customers.ThisCustomer.Title = txtTitle.Text;
            Customers.ThisCustomer.ForeName = txtForeName.Text;
            Customers.ThisCustomer.LastName = txtLastName.Text;
            Customers.ThisCustomer.Email = txtCustomerEmail.Text;
            Customers.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            Customers.ThisCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            Customers.ThisCustomer.Active = checkboxActive.Checked;
            //update the record
            Customers.Update();
            //all done so redirect back to the main page
            Response.Redirect("CustomerDefault");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customers list
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(CustomerNo);
        //display the data for the record
        txtTitle.Text = Customers.ThisCustomer.Title;
        txtForeName.Text = Customers.ThisCustomer.ForeName;
        txtLastName.Text = Customers.ThisCustomer.LastName;
        txtCustomerEmail.Text = Customers.ThisCustomer.Email;
        txtPhoneNo.Text = Customers.ThisCustomer.PhoneNo.ToString();
        txtDateAdded.Text = Customers.ThisCustomer.DateAdded.ToString();
        checkboxActive.Checked = Customers.ThisCustomer.Active;

    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }
}
