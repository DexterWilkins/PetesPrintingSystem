using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock stock = new clsStock();
        //get the data from the session object
        stock = (clsStock)Session["stock"];
        //display the StockNo for this entry
        Response.Write(stock.StockNo);
    }
}