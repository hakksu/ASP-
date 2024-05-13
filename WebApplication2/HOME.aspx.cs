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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               string config =
               System.Web.Configuration.WebConfigurationManager.ConnectionStrings["testConnectionString"].ConnectionString; //從config找到資料庫位置

               SqlConnection connection = new SqlConnection(config); //與資料庫做連結的大門

               SqlCommand command = new SqlCommand(@"SELECT [id], [header], [name],[initDate] ,(select count(*) from [re] where floor=[mes].id)as 回應 FROM [mes]", connection);//對資料庫下令的SQL語法

               SqlDataAdapter dataAdapter = new SqlDataAdapter(command);//取得command資料
              
               DataSet dataset = new DataSet();//創立一個dataset的記憶體資料庫

               dataAdapter.Fill(dataset);//將上面抓到的資料存入dataset內


               GridView1.DataSource = dataset;//DataSource的資料來源是dataset or datatable

               GridView1.DataBind();//資料與欄位合在一起
        }

      
    }
}