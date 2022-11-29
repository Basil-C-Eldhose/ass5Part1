using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ass32
{
    public partial class newGrid : System.Web.UI.Page
    {
        Operation obj=new Operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = obj.selectemp("select * from employee");
                GridView1.DataBind();
            }
           
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = obj.selectemp("select * from employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.selectemp("select * from employee");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            TextBox txtname = new TextBox();
            txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox txtemail = new TextBox();
            txtemail = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtphone = new TextBox();
            txtphone = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtage = new TextBox();
            txtage = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

            obj.insertdb("update employee set name='" + txtname.Text + "',email='" + txtemail.Text + "',phone='" + txtphone.Text + "',age='" + txtage.Text + "' where empid='" + id + "'");

            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.selectemp("select * from employee");
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            obj.deletedb(id);
            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.selectemp("select * from employee");
            GridView1.DataBind();
        }

        
    }
}