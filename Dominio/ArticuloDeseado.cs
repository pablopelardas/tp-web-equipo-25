﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ArticuloDeseado
    {
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        public float Subtotal {
            get
            {
                return Articulo.Precio * Cantidad;
            }
        } 
            

        public ArticuloDeseado() { 
            Articulo = new Articulo();
        }

        public ArticuloDeseado(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
        }


    }
}
