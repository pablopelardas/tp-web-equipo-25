using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Web
{
    public partial class Resultados : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulosFiltrada { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                filtroCategoria.DataSource = Session["listaCategorias"];
                filtroCategoria.DataBind();
                filtroMarca.DataSource = Session["listaMarcas"];
                filtroMarca.DataBind();
            }
            
            if (Session["listaArticulosFiltrada"] == null)
            {
                ListaArticulosFiltrada = (List<Articulo>)Session["listaArticulos"];
                divBuscado.Visible = false;
            } else
            {
                ListaArticulosFiltrada = (List<Articulo>)Session["listaArticulosFiltrada"];
                textoBuscado.Text = Request.QueryString["search"].ToString();
                divBuscado.Visible = true;
            }


            

            


        }

        public List<Categoria> ListaCategorias { get; set; }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            rptArticulosFiltrados.DataSource = ListaArticulosFiltrada;
            rptArticulosFiltrados.DataBind();
        }
    }
}