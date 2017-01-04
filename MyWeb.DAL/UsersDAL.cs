using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyWeb.DAL
{
    public class UsersDAL
    {
        public DataSet get_users(string str_where)
        {
            string con = "Data Source=.;Initial Catalog=MySchool; User ID=sa;Pwd=123";
            SqlConnection conn = new SqlConnection(con);
            string sql = "select * from users where isstatus=1 " + str_where;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dapter.Fill(ds);
            return ds;
        }
    }
}
