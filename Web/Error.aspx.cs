using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["error"] == null)
            {
                Session.Add("error", "");
            }
            if (Session["errorStatus"] == null)
            {
                Session.Add("errorStatus", "");
            }
            Message.Text = ((string)Session["error"]).Length > 0 ? (string)Session["error"] : "Hubo un error inesperado";
            Status.Text = ((string)Session["errorStatus"]).Length > 0 ? (string)Session["errorStatus"] : "500";
        }
    }
}