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
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaMarcas"] == null)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Session.Add("listaMarcas", marcaNegocio.ListarMarcas());
            }
            if (Session["listaCategorias"] == null)
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Session.Add("listaCategorias", categoriaNegocio.ListarCategorias());
            }
            if (Session["listaArticulos"] == null)
            {
                ArticulosNegocio articuloNegocio = new ArticulosNegocio();
                Session.Add("listaArticulos", articuloNegocio.ListarArticulos());
            }
            if (Session["listaCarrito"] == null)
            {
                List<ArticuloDeseado> ListaCarrito = new List<ArticuloDeseado>();
                Session.Add("listaCarrito", ListaCarrito);
            }
        }
    }
}