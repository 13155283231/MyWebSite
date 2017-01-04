using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MyWeb.DAL;

namespace MyWeb.BLL
{
    public class UsersBLL
    {
        public DataSet get_users(string str_where)
        {
            if (str_where == "")
            {

            }
            else
            {

                str_where += " and ";
            }
            //调用数据访问层
            UsersDAL userdal = new UsersDAL();
            DataSet ds = userdal.get_users(str_where);
            ds.Tables[0].Rows[0][1] = "zyh自己改的";
            return ds;
        }
    }
}
