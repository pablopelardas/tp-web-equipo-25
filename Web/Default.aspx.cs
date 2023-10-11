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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["listaMarcas"] == null)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    Session.Add("listaMarcas", marcaNegocio.ListarMarcasConSP());
                }
                if (Session["listaCategorias"] == null)
                {
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    Session.Add("listaCategorias", categoriaNegocio.ListarCategoriaConSP());
                }
                if (Session["listaArticulos"] == null)
                {
                    ArticulosNegocio articuloNegocio = new ArticulosNegocio();
                    Session.Add("listaArticulos", articuloNegocio.ListarArticulosConSP());
                }

                ListaArticulos = (List<Articulo>)Session["listaArticulos"];
                ListaCategorias = (List<Categoria>)Session["listaCategorias"];
            }

           
        }


    }
}