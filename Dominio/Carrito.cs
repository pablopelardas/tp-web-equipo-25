using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        private readonly List<ArticuloDeseado> Articulos;
        public float Total { get; set; }
        public Carrito()
        {
            Articulos = new List<ArticuloDeseado>();
        }

        public void AgregarArticulo(Articulo articulo, int cantidad)
        {
            ArticuloDeseado articuloDeseado = new ArticuloDeseado(articulo, cantidad);
            Articulos.Add(articuloDeseado);
            Total += articuloDeseado.Subtotal;
        }

        public bool EliminarArticulo(int Id)
        {
            ArticuloDeseado articuloDeseado = Articulos.Find(a => a.Articulo.Id == Id);
            if (articuloDeseado == null) return false;
            Articulos.Remove(articuloDeseado);
            Total -= articuloDeseado.Subtotal;
            return true;
        }

        public bool ModificarCantidad(int Id, int cantidad)
        {
            ArticuloDeseado articuloDeseado = Articulos.Find(a => a.Articulo.Id == Id);
            if (articuloDeseado == null) return false;
            Total -= articuloDeseado.Subtotal;
            articuloDeseado.Cantidad = cantidad;
            Total += articuloDeseado.Subtotal;
            return true;
        }

        public int GetCantidadArticulos()
        {
            return Articulos.Count;
        }

        public List<ArticuloDeseado> GetArticulosDeseados()
        {
            return Articulos;
        }
    }
}
