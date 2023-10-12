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
        public Articulo Articulo { get; set; }
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
                // buscar articulo en ListaArticulo
                if (ListaArticulos != null)
                {
                    Articulo = ListaArticulos.Find(a => a.Id == Id);
                }
                // si no lo encuentra, buscar en la base de datos
                if (Articulo == null)
                {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    Articulo = negocio.BuscarArticulo(Id);
                }

                // si no lo encuentra en la base de datos, redireccionar a la pagina de error
                if (Articulo == null)
                {
                    //Response.Redirect("Error.aspx"); 404 not found
                }
            }
            else
            {
                //Response.Redirect("Error.aspx"); 404 not found
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
                aux.Imagen = art.Imagenes[0].ToString();

                aux.Cantidad = int.Parse(tBoxCantidad.Text);
                aux.Precio = art.Precio;

                ((List<Carrito>)Session["ListaCarrito"]).Add(aux);
            }

            Response.Redirect("Default.aspx", false);
        }
    }
}