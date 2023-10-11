using Dominio;
using Negocio;
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
        public List<Carrito> ListaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ListaArticulos == null)
            {
                ListaArticulos = (List<Articulo>)Session["listaArticulos"];
            }


            if (Request.QueryString["id"] != null)
            {
                Id = int.Parse(Request.QueryString["id"]);
            }

            if (Session["listaCarrito"] == null)
            {
                ListaCarrito = new List<Carrito>();
                Session.Add("listaCarrito", ListaCarrito);
            }

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            foreach (Articulo art in ListaArticulos.FindAll(a => a.Id == Id))
            {
                Carrito aux = new Carrito();

                aux.IdArticulo = art.Id;
                aux.Nombre = art.Nombre;
                aux.Descripcion = art.Descripcion;
                aux.Cantidad = int.Parse(tBoxCantidad.Text);
                aux.Precio = art.Precio;

                ((List<Carrito>)Session["ListaCarrito"]).Add(aux);
            }

            Response.Redirect("Default.aspx", false);
        }
    }
}