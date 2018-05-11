using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelegramNotifier
{
    public partial class login : System.Web.UI.Page
    {
        private const string AdminId = "admin";
        private const string AdminPass = "root";
        protected void Page_Load(object sender, EventArgs e)
        {
            ltlS.Text = "";

            if (!string.IsNullOrEmpty(Request["msg"]))
            {
                ltlS.Text = "<script>toastr.warning('" + Request["msg"] + "');</script>";

            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                ltlS.Text = "<script>toastr.error('Hey man , please fill all data !');</script>";
                return;
            }

            if (txtId.Text == AdminId && txtPass.Text == AdminPass)
            {

                Session["admin"] = txtId.Text;
                Session["admindisplay"] = "Administrator";
                Response.Redirect("dash.aspx");
            }
            else
            {
                ltlS.Text = "<script>toastr.error('You cant pass !');</script>";
                return;
            }
        }
    }
}
