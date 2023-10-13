using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class DetalleCarrito : System.Web.UI.Page
    {
        private Carrito _carrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["carrito"] == null)
            {
                _carrito = new Carrito();
            }
            else
            {
                _carrito = (Carrito)Session["carrito"];
            }
            if (_carrito.GetCantidadArticulos() == 0)
            {
                Response.Redirect("Default.aspx");
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            repRepetidor.DataSource = _carrito.GetArticulosDeseados();
            repRepetidor.DataBind();
            // format carrito total to currency
            totalLiteral.Text = String.Format("{0:C}", _carrito.Total);
        }

        protected void ImagBtnEliminar_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            try
            {
                int id = int.Parse(btn.CommandArgument.ToString());
                if (_carrito.EliminarArticulo(id))
                {
                    Session["carrito"] = _carrito;
                    Response.Redirect("DetalleCarrito.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Cantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            RepeaterItem rpt = (RepeaterItem)txt.NamingContainer;
            try
            {
                int id = int.Parse(((HiddenField)rpt.FindControl("hfId")).Value);
                int cantidad = int.Parse(txt.Text);
                if (_carrito.ModificarCantidad(id, cantidad))
                {
                    
                    Session["carrito"] = _carrito;
                    

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}