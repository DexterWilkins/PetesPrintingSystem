using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrintingClasses;

public partial class CustomerDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first appearnace of the form
        if (IsPostBack == false)
        {
            //display all the customer
            DisplayCustomers("");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //add the new record
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 CustomerNo;
        //if a reocrd has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key
        Int32 CustomerNo;
        //if a reocrd has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the delete page
            Response.Redirect("ACustomer.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //Display all customers
        DisplayCustomers("");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display only customers matching the text in the last name text box
        DisplayCustomers(txtLastNameFilter.Text);
                
    }

    Int32 DisplayCustomers(string LastNameFilter)
    {
        Int32 CustomerNo; //var to store the primary key
        String ForeName; //var to store the first name
        String LastName; //var to store the last name
        clsCustomerCollection Customers = new clsCustomerCollection(); //create an instance of the customer collection class
        Customers.ReportByLastName(LastNameFilter);
        Int32 RecordCount; //var to store the count of records
        Int32 Index = 0; //var to store the index for the loop
        RecordCount = Customers.Count; //get the count of records
        lstCustomers.Items.Clear(); //clear the list box
        while (Index < RecordCount) //while there are records to process
        {
            CustomerNo = Customers.CustomerList[Index].CustomerNo; //get the primary key
            ForeName = Customers.CustomerList[Index].ForeName; //get the first name
            LastName = Customers.CustomerList[Index].LastName; //get the last name
            ListItem NewEntry = new ListItem(ForeName + " " + LastName, CustomerNo.ToString()); //create a new entry for the list box
            lstCustomers.Items.Add(NewEntry);//add the customer to the list
            Index++;//move the index to the next record
        }
        return RecordCount; //return the count of records found

    }
}