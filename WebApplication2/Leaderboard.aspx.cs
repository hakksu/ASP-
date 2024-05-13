using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Leaderboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string config = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;

            SqlConnection rconnection = new SqlConnection(config);        

            SqlCommand Rcommand = new SqlCommand($"SELECT id,s, range, name, main, initDate  FROM UIPWD )", rconnection);


            rconnection.Open();

            SqlDataReader reader = Rcommand.ExecuteReader();
            Repeater1.DataSource = reader;//repeater的資料來源是從rereader來
            Repeater1.DataBind();//執行繫結
        }
    }
}