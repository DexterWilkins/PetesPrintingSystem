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
        //capture the customer no
        //ACustomer.CustomerNo = txtCustomerNo.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;                  
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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