using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDelete : System.Web.UI.Page
{
    //store the primary Key
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    void DeleteOrder()
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteOrder();

        Response.Redirect("OrderDefault.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }
}