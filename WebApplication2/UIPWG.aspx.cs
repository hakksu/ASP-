using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UIPWG : System.Web.UI.Page
    {
        /*private int times
        {
            get
            {
                return (int)ViewState["a"];
            }
            set
            {
                ViewState["a"] = 0;
            }
        }*/
         string c;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            c = Request.QueryString["range"];
             Label3.Text = "範圍: 0~" + Request.QueryString["range"];
           // Label3.Text = a + "i" + i;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
  
            Random random = new Random();
            ViewState["a"] = random.Next(0, int.Parse(Request.QueryString["range"]));
            //Label2.Text = (int)ViewState["a"] + "RRRRR" + int.Parse(Request.QueryString["range"]);
            Label4.Text = "已產生密碼";
            min.Text = "" + 0;
            Label6.Text = "~";
            max.Text = Request.QueryString["range"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n,x;
            if(Label4.Text =="")
            {
                Label2.Text = "請先產生密碼";
            }
            else if (string.IsNullOrEmpty(TextBox1.Text) || !(int.TryParse(TextBox1.Text, out n)))
            {
                Label2.Text = "請填入數字";
            }
            else if(int.Parse(TextBox1.Text)< int.Parse(min.Text) || int.Parse(TextBox1.Text)> int.Parse(max.Text))
            {
                Label2.Text = "超出範圍";
            }
            else 
            {
                x = int.Parse(Label5.Text);
                x++;
                Label5.Text = ""+x;
                x = int.Parse(TextBox1.Text);
                if ((int)ViewState["a"] > x)
                {
                    min.Text = ""+x;
                }
                else if ((int)ViewState["a"] < x)
                {
                    max.Text = "" + x;
                }
                else
                {
                    Response.Redirect("gamereport.aspx?s="+ Label5.Text + "&range=" + Request.QueryString["range"]);
                }
                Label2.Text = "";
            }
          

        }
    }
}