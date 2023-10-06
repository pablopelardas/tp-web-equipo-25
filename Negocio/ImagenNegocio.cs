using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using AccesoDatos;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> ListarImagenesConSP()
        {
            Database datos = new Database();
            List<Imagen> imagenes = new List<Imagen>();

            try
            {
                datos.SetProcedure("SP_ListarImagenes");
                datos.ReadData();

                while (datos.Reader.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)datos.Reader["Id"];
                    img.IdArticulo = (int)datos.Reader["IdArticulo"];
                    img.URL = (string)datos.Reader["ImagenURL"];

                    imagenes.Add(img);
                }

                return imagenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CloseConnection();
            }
        }
    }
}
