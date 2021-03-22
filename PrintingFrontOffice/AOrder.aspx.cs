using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the OrderClass
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the Find
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDeliveryDate.Text = AnOrder.DeliveryDate;
            txtDateDelivered.Text = AnOrder.DateDelivered;
            txtPartNo.Text = AnOrder.PartNo;
        }


    }
}