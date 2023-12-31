﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public Carrito Carrito { get; set; }

        public int ActiveImageIndex { get; set; }


        private void Load_Articulo()
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Id = int.Parse(Request.QueryString["id"]);
                    if (Session["listaArticulos"] != null)
                    {
                        Carrito = (Carrito)Session["carrito"];
                        Articulo = ((List<Articulo>)Session["listaArticulos"]).Find(a => a.Id == Id);
                    }
                    else
                    {
                        ArticulosNegocio negocio = new ArticulosNegocio();
                        Articulo = negocio.BuscarArticulo(Id);
                    }
                }
                else
                {
                    //Response.Redirect("Error.aspx"); 404 not found
                }
                if (Articulo == null)
                {
                    Session.Add("error", "Articulo no encontrado");
                    Session.Add("errorStatus", "404");
                    Response.Redirect("Error.aspx");
                }
                else
                {
                    Session.Add("currentArt", Articulo);
                    tBoxCantidad.Text = "1";
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_Articulo();
            ActiveImageIndex = 0;
        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(tBoxCantidad.Text);
            ((Carrito)Session["carrito"]).AgregarArticulo((Articulo)Session["currentArt"], cantidad);
            Response.Redirect("Default.aspx", false);
        }
    }
}