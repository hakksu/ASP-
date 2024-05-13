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
    public partial class RRE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Reply_Main.Text) && string.IsNullOrEmpty(Reply_Name.Text))
            {
                Message.Text = "請填名字跟內容";
            }

            else if (string.IsNullOrEmpty(Reply_Name.Text))
            {
                Message.Text = "請填名字";
            }
            else if (string.IsNullOrEmpty(Reply_Main.Text))
            {
                Message.Text = "請填內容";
            }

            else
            {
                string config = System.Web.Configuration.WebConfigurationManager
                    .ConnectionStrings["testConnectionString"].ConnectionString; //取得config的.ConnectionStrings資料

                SqlConnection Connection = new SqlConnection(config); //與資料庫做連接的通道

                SqlCommand command = new SqlCommand($" INSERT INTO re(name,main,floor) VALUES(@name, @main,@id)", Connection);//下達要執行的SQL指令,將加入存進資料表內
                //因為標題本來預設就會顯示文字所以不用新增進回應資料表內

                
                //參數化的資料型態與值
                command.Parameters.Add("@name", SqlDbType.NVarChar);
                command.Parameters["@name"].Value = Reply_Name.Text;
                command.Parameters.Add("@main", SqlDbType.NVarChar);
                command.Parameters["@main"].Value = Reply_Main.Text;
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = int.Parse(Request.QueryString["id"]);//將取得的值轉成int*/
                /*Response.Write("RRRRRRRRR"+Request.QueryString["id"]);
                Reply_Name.Text = "e04"+ int.Parse(Request.QueryString["id"]);//*/

                Connection.Open(); //開啟通道
                
                command.ExecuteNonQuery(); //執行SQL並回傳影響的項目

                Connection.Close(); //關閉通道

                Response.Redirect("article.aspx?id=" + Request.QueryString["id"]);//跳轉至回應的留言內容區(用id來抓取)
            }
        }
    }
}