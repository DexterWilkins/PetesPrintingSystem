using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Stock : System.Web.UI.Page
{
    Int32 StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostBack == false)
        {
            //populate the list
            DisplayStockDiscriptions();
            if (StockNo != -1)
            {
                DisplayStockDiscriptions();
            }
        }
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
    
    //function for adding new records
    void Add()
    {
        //create an instance of the Stock
        clsStockCollection stock = new clsStockCollection();
        //validate the data on the web forms
        String Error = stock.ThisStock.Valid(txtStockNo.Text, txtDescription.Text, txtLocation.Text, txtDateAdded.Text);
        //if the data is OK then addit to the object
        if (Error ==  "")
        {
            stock.ThisStock.StockDescription = txtDescription.Text;
            stock.ThisStock.StockLocation = txtLocation.Text;
            stock.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            stock.ThisStock.InStock = chkInStock.Checked;
            //add the record
            stock.Add();
            //all donw sp redirect to the main page
            Response.Redirect("StockDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void Update ()
    {
        //create an instance of stock
        PrintingClasses.clsStockCollection stock = new PrintingClasses.clsStockCollection();
        //validate the data on the web form
        String Error = stock.ThisStock.Valid(txtStockNo.Text, txtDescription.Text, txtLocation.Text, txtDateAdded.Text);
        //if the data is okay then add it to the object
        if (Error == "")
        {
            //find the record to update
            stock.ThisStock.Find(StockNo);
            //get the data entered by the user
            stock.ThisStock.StockDescription = txtDescription.Text;
            stock.ThisStock.StockLocation = txtLocation.Text;
            stock.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            stock.ThisStock.InStock = chkInStock.Checked;
            //update the record
            stock.Update();
            Response.Redirect("StockDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    void DisplayStockDiscriptions()
    {
        clsStockCollection stock = new clsStockCollection();
        //find the record to update
        stock.ThisStock.Find(StockNo);
        //display the data of this record
        txtDescription.Text = stock.ThisStock.StockDescription;
        txtLocation.Text = stock.ThisStock.StockLocation;
        txtDateAdded.Text = stock.ThisStock.DateAdded.ToString();
        chkInStock.Checked = stock.ThisStock.InStock;
    }
}