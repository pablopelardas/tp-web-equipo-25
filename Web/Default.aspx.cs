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
        public List<Imagen> ListaImagenes { get; set; }
        public string ImgSeleccionada { get; set; }

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
            if (Session["listaArticulos"] == null)
            {
                ArticulosNegocio articuloNegocio = new ArticulosNegocio();
                Session.Add("listaArticulos", articuloNegocio.ListarArticulosConSP());
            }
            if (Session["listaImagenes"] == null)
            {
                ImagenNegocio imgNegocio = new ImagenNegocio();
                Session.Add("listaImagenes", imgNegocio.ListarImagenesConSP());
            }

            ListaArticulos = (List<Articulo>)Session["listaArticulos"];
            ListaImagenes = (List<Imagen>)Session["listaImagenes"];

            ddlMarca.DataSource = Session["listaMarcas"];
            ddlMarca.DataBind();
            ddlCategoria.DataSource = Session["listaCategorias"];
            ddlCategoria.DataBind();
        }
    }
}