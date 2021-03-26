using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class OrderDefult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            //DisplayOrders("");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;

        Response.Redirect("AnOrder.aspx");
    }

    void Add()
    {
       // clsOrderCollection OrderBook = new clsOrderCollection();

       // string Error = OrderBook.ThisOrder;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;

        if (lstDisplay.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstDisplay.SelectedIndex);

            Session["OrderNo"] = OrderNo;

            Response.Redirect("CustomerDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to be deleted from this list";
        }
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;

        if (lstDisplay.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstDisplay.SelectedIndex);

            Session["OrderNo"] = OrderNo;

            Response.Redirect("AOrder.aspx");
        }
        else
        {
            lblError.Text = "please select a record to Edit from the list";
        }
    }


    //protected void btnDisplay_Click(object sender, EventArgs e)
    //{
        //DisplayOrders("");
    //}

    //protected void btnApply_Click(object sender, EventArgs e)
    //{
        //DisplayOrders(txtPartNoFilter.text);
    //}

    //Int32 DisplayOrders(Int32 PartNo)
    //{
      //  Int32 OrderNo;
      //  DateTime DeliveryDate;
    //}