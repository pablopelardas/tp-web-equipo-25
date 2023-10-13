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
            }else
            {
                int count = ((List<ArticuloDeseado>)Session["listaCarrito"]).Count;
                if (count > 0)
                CarritoCounter.Text = count.ToString();
                else CarritoCounter.Text = "";
            }

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            if (Session["listaArticulos"] == null) return;
            if (SearchBox.Text == "" || SearchBox.Text.Length < 3) return;
            List<Articulo> listaArticulos = (List<Articulo>)Session["listaArticulos"];
            List<Articulo> listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(SearchBox.Text.ToLower()) || x.Descripcion.ToLower().Contains(SearchBox.Text.ToLower()));
            Session.Add("listaArticulosFiltrada", listaFiltrada);
            Response.Redirect("Resultados.aspx");
        }
    }
}