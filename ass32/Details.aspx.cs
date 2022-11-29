using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ass32
{
    public partial class Details : System.Web.UI.Page
    {
        Operation ob = new Operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string _id=Request.QueryString["eid"].ToString();
                Label1.Text = _id;
                
            }
        }
    }
}