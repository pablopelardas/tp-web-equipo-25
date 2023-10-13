using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class DetalleCarrito : System.Web.UI.Page
    {
        public List<ArticuloDeseado> ListaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (Session["listaCarrito"] == null)
                {
                    ListaCarrito = new List<ArticuloDeseado>();
                    Session.Add("listaCarrito", ListaCarrito);
                }
                ListaCarrito = (List<ArticuloDeseado>)Session["listaCarrito"];
            if (ListaCarrito.Count == 0)
            {
                Response.Redirect("Default.aspx");
            }

            
            //ImagBtnEliminar_Click.Click += new ImageClickEventHandler(ImagBtnEliminar_Click);
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            repRepetidor.DataSource = ListaCarrito;
            repRepetidor.DataBind();
        }

        protected void ImagBtnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            try
            {
                int id = int.Parse(btn.CommandArgument.ToString());
                ArticuloDeseado articulo = ListaCarrito.Find(a => a.Articulo.Id == id);
                ListaCarrito.Remove(articulo);
                Session["listaCarrito"] = ListaCarrito;
                Response.Redirect("DetalleCarrito.aspx");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}