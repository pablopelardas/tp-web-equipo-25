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
    public partial class _Default : Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        public List<Categoria> ListaCategorias { get; set; }

        protected void Page_PreRender(object sender, EventArgs e)
        {
                ListaArticulos = (List<Articulo>)Session["listaArticulos"];
                ListaCategorias = (List<Categoria>)Session["listaCategorias"];
        }


    }
}