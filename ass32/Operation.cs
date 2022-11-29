using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ass32
{
    public class Operation
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public string name;


        public Operation()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=Ass3Emp;Integrated Security=True;pooling=false";
            cmd.Connection = con;

        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void insertdb(string Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.ExecuteNonQuery();
        }
        public DataSet selectemp(string sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void updatedb(string Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.ExecuteNonQuery();
        }
        public void deletedb(string id)
        {
            Getcon();
            cmd.CommandType=CommandType.Text;
            string Sql = "delete from employee where empid='" + id + "'";
            cmd.CommandText = Sql;
            cmd.ExecuteNonQuery();

        }

    }
}