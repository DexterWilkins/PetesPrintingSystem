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
}