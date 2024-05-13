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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "你花了" + Request.QueryString["s"]+ "次找出了密碼";
            //取得config連接字串資訊

           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string getconfig = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString;

            //建立與資料庫建立起連接的通道，以getconfig內的連接字串連接所對應的資料庫

            SqlConnection Connection = new SqlConnection(getconfig);

            //要對SQL Server下達的SQL指令並且參數化

            SqlCommand command = new SqlCommand($"INSERT INTO UIPWD( range,name, s,main) VALUES(@range, @name, @s,@main)", Connection);

            //賦予參數資料型態與值
            command.Parameters.Add("@range", SqlDbType.NVarChar);//值必須是NVarChar的資料型態
            command.Parameters["@range"].Value = Request.QueryString["range"];

            command.Parameters.Add("@name", SqlDbType.NVarChar);
            command.Parameters["@name"].Value = TextBox1.Text;//給予的值是從Message_Name的Text來的

            command.Parameters.Add("@main", SqlDbType.NVarChar);
            command.Parameters["@main"].Value = TextBox2.Text;

            command.Parameters.Add("@s", SqlDbType.NVarChar);
            command.Parameters["@s"].Value = Request.QueryString["s"];

            Connection.Open();//開啟通道
            command.ExecuteNonQuery();//執行command的SQL語法，回傳受影響的資料數目
            Connection.Close();//關閉通道

            Response.Redirect("Record.aspx");//確認留言完後要跳轉回首頁Message_Index.aspx

        }
    }
}