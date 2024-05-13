using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class UIPSW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n;
            if (string.IsNullOrEmpty(range.Text) || !(int.TryParse(range.Text, out n)))
            {
                Label2.Text = "請填入數字";
            }
            else
            {
                Response.Redirect("~/UIPWG.aspx?range=" + range.Text);
            }
        }
    }
}