using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
}