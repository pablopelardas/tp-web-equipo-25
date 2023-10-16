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
                filtroCategoria.Items.Insert(0, "Seleccionar..");
                filtroMarca.DataSource = Session["listaMarcas"];
                filtroMarca.DataBind();
                filtroMarca.Items.Insert(0, "Seleccionar..");
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

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            if (Session["listaArticulosFiltrada"] == null) return;
            List<Articulo> listaArticulos = (List<Articulo>)Session["listaArticulos"];
            List<Articulo> listaArticulosFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(Request.QueryString["search"].ToString().ToLower()) || x.Descripcion.ToLower().Contains(Request.QueryString["search"].ToString().ToLower()));
            List<Articulo> listaFiltrada = new List<Articulo>();

            string cat = "";
            string mrc = "";

            divCat.Visible = false;
            divMrc.Visible = false;

            if (filtroCategoria.Text != "Seleccionar..")
            {
                listaFiltrada = listaArticulosFiltrada.FindAll(x => x.Categoria.Nombre.Contains(filtroCategoria.Text));
                cat = "&cat=" + filtroCategoria.Text;
                Session.Add("listaArticulosFiltrada", listaFiltrada);

                catBuscado.Text = filtroCategoria.Text;
                divCat.Visible = true;
            }
            
            if(filtroMarca.Text != "Seleccionar..")
            {
                listaFiltrada = listaArticulosFiltrada.FindAll(x => x.Marca.Nombre.Contains(filtroMarca.Text));
                mrc = "&mrc=" + filtroMarca.Text;
                Session.Add("listaArticulosFiltrada", listaFiltrada);

                mrcBuscado.Text = filtroCategoria.Text;
                divMrc.Visible = true;
            } 

            Response.Redirect("Resultados.aspx?search=" + Request.QueryString["search"].ToString() + cat + mrc);
        }
    }

}