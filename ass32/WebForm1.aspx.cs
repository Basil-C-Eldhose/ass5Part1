using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ass32
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Operation op=new Operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = op.selectemp("SELECT * from employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            GridView1.DataSource = op.selectemp("SELECT * from employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = op.selectemp("SELECT * from employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //  string id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();

            //GridViewRow row = GridView1.Rows[e.RowIndex];

            TextBox tname = new TextBox();
            tname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox tage = new TextBox();
            tage = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            //tage = (TextBox)(row.Cells[1].Controls[0]);
            TextBox temail = new TextBox();

            //temail = (TextBox)(row.Cells[2].Controls[0]);
            temail = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox tphone = new TextBox();
            //tphone = (TextBox)(row.Cells[3].Controls[0]);
            tphone = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

            //string nname=tname.Text;
            //string nemail = temail.Text;
            //string nage=tage.Text;
            //string nphone=tphone.Text;


            //op.Getcon();
            // string s = "update employee set name='" + tname.Text + "',email='" + temail.Text + "',phone='" + tphone.Text + "',age='" + tage.Text + "' where empid='" + id+ "'";
            op.insertdb("update employee set name = '" + tname.Text + "', email = '" + temail.Text + "', phone = '" + tphone.Text + "', age = '" + tage.Text + "' where empid = '" + id+ "'");
            GridView1.EditIndex = -1;
            GridView1.DataSource = op.selectemp("SELECT * from employee");
            GridView1.DataBind();
        }
    }
}