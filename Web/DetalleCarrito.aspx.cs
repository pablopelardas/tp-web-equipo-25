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
        public List<Carrito> ListaCarrito { get; set; }
        public Carrito Carrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaCarrito"] == null)
            {
                ListaCarrito = new List<Carrito>();
                Session.Add("listaCarrito", ListaCarrito);
            }

            if (ListaCarrito == null)
            {
                ListaCarrito = (List<Carrito>)Session["ListaCarrito"];
            }
        }

        protected void ImagBtnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            
        }
    }
}