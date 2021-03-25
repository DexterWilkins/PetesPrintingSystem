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
}