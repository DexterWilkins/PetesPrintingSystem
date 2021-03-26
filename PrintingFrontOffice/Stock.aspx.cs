using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Stock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOkay_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock stock = new clsStock();
        //capture the StockNo
        stock.StockNo = int.Parse(txtStockNo.Text);
        //store the StockNo in the session object
        Session["stock"] = stock;
        //redirect to the viewer page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock stock = new clsStock();
        //variable to store the primary key
        Int32 StockNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockNo = Convert.ToInt32(txtStockNo.Text);
        //find the record
        Found = stock.Find(StockNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockNo.Text = stock.StockNo.ToString();
            txtDescription.Text = stock.StockDescription;
            txtLocation.Text = stock.StockLocation;
            txtDateAdded.Text = stock.DateAdded.ToString();
        }
    }
}