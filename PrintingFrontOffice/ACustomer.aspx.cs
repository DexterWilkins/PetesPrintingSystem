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
            //populate the list of customers
            //DisplayCustomers();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
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
        //create an instance of the address book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtForeName.Text, txtCustomerEmail.Text, txtPhoneNo.Text, txtDateAdded.Text);
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
        //create an instance of the address book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //validate the data on the web form
        String Error = Customers.ThisCustomer.Valid(txtTitle.Text, txtForeName.Text, txtCustomerEmail.Text, txtPhoneNo.Text, txtDateAdded.Text);
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



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }
}
