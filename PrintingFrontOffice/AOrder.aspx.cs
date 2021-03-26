using PrintingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AOrder : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            if (OrderNo != -1)
            {
                //DisplayOrders();
            }
        }
     }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the OrderClass
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;

        Boolean Found = false;
        //variable to store the result of the Find
        OrderNo = Convert.ToInt32( txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDeliveryDate.Text = AnOrder.DeliveryDate.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtPartNo.Text = AnOrder.PartNo.ToString();
        }
    }

    void Add()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        String Error = Orders.ThisOrder.Vaild(txtDeliveryDate.Text, txtOrderDate.Text, txtPartNo.Text);

        if (Error == "")
        {
            Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            Orders.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
            Orders.ThisOrder.PartNo = Convert.ToInt32(txtPartNo);

            Orders.Add();
               
        }
        else
        {
            lblError.Text = "error with the data that you entered" + Error;
        }
    }



    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();

        string OrderDate = txtOrderDate.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string PartNo = txtPartNo.Text;

        string Error = "";

        Error = AOrder.Vaild(OrderDate, DeliveryDate, PartNo);
        if (Error == "")
        {
            AOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            AOrder.PartNo = Convert.ToInt32(PartNo);

            Session["AOrder"] = AOrder;

            Response.Write("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        if (OrderNo == -1)
        {
            Add();

            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            Update();

            Response.Redirect("OrderDefault.aspx");
        }
    }

    void Update()
    {
        clsCustomerCollection Orders = new clsCustomerCollection();

        String Error = Orders.ThisOrder.Vaild(txtDeliveryDate.Text, txtOrderDate.Text, txtPartNo.Text);

        if (Error == "")
        {

            Orders.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            Orders.ThisOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
            Orders.ThisOrder.PartNo = Convert.ToInt32(txtPartNo.Text);

            Orders.Update();

            Response.Redirect("OrderDefault.aspx");
        }
        else
        {
            lblError.Text = "problem with the data entered" + Error;
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ThisOrder.Find(OrderNo);

        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        txtDeliveryDate.Text = Orders.ThisOrder.DeliveryDate.ToString();
        txtPartNo.Text = Orders.ThisOrder.PartNo.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }
}