using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Detalle : System.Web.UI.Page
    {
        public int Id { get; set; }
        public List<Articulo> ListaArticulos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ListaArticulos = (List<Articulo>)Session["listaArticulos"];

            if (Request.QueryString["id"] != null)
            {
                Id = int.Parse(Request.QueryString["id"]);
            }
        }
    }
}