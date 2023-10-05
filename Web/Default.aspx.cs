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
        protected void Page_Load(object sender, EventArgs e)
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

            ddlMarca.DataSource = Session["listaMarcas"];
            ddlMarca.DataBind();
            ddlCategoria.DataSource = Session["listaCategorias"];
            ddlCategoria.DataBind();
        }
    }
}