using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockDelete : System.Web.UI.Page
{
    void DeleteAddress()
    {
        //create a new instance of stock
        clsStockCollection stock = new clsStockCollection();
        stock.ThisStock.Find(StockNo);
        stock.Delete();
    }
    Int32 StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockNo = Convert.ToInt32(Session["StockNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteAddress();
        Response.Redirect("StockDefault.aspx");
    }
}