using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWeb.BLL;
using System.Data;

namespace MyWeb.UI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //把数据库中的用户显示出来
            UsersBLL usersBll = new UsersBLL();
            DataSet ds = usersBll.get_users("");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}
