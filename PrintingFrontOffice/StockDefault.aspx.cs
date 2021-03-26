using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockDefault : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("Stock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockNo = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object
            Session["StockNo"] = StockNo;
            //redirect to the delete page
            Response.Redirect("StockDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockNo = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object
            Session["StockNo"] = StockNo;
            //redirect to the delete page
            Response.Redirect("Stock.aspx");
        }
    }
}