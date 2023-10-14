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

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            if (Session["listaArticulosFiltrada"] == null) return;
            List<Articulo> listaArticulos = (List<Articulo>)Session["listaArticulosFiltrada"];
            List<Articulo> listaFiltrada = new List<Articulo>();

            string cat = "";
            string mrc = "";

            if (filtroCategoria.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Categoria.Nombre.Contains(filtroCategoria.Text));
                cat = "&cat=" + filtroCategoria.Text;
            }
            
            if(filtroMarca.Text != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Marca.Nombre.Contains(filtroMarca.Text));
                mrc = "&mrc=" + filtroMarca.Text;
            } 

            Session.Add("listaArticulosFiltrada", listaFiltrada);
            Response.Redirect("Resultados.aspx?search=" + Request.QueryString["search"].ToString() + cat + mrc);


        }
    }
}