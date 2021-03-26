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
        string StockNo = txtStockNo.Text;
        //capture the StockDescription
        string StockDescription = txtDescription.Text;
        //capture the StockLocation
        string StockLocation = txtLocation.Text;
        //capture the DateAdded
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = stock.Valid(StockNo, StockDescription, StockLocation, DateAdded);
        if (Error =="")
        {
            //capture the StockNo
            stock.StockNo = Convert.ToInt32(StockNo);
            //capture the StockDescription
            stock.StockDescription = StockDescription;
            //capture the StockLocation
            stock.StockLocation = StockLocation;
            //capture InStock
            stock.InStock = InStock;
            //capture DateAdded
            stock.DateAdded = Convert.ToDateTime(DateAdded);
            //store the stock in the session object
            Session["stock"] = stock;
            //redirect to the viewer page
            Response.Write("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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