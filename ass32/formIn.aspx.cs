using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ass32
{
    public partial class formIn : System.Web.UI.Page
    {
        Operation op = new Operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string name=txtname.Text;
            //string age=txtage.Text;
            //string phone=txtphone.Text;
            //string email=txtemail.Text;

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            op.Getcon();
            op.insertdb("insert into employee values ('" + txtname.Text + "','" + txtemail.Text + "','" + txtphone.Text + "','" + txtage.Text + "')");
        }
    }
}