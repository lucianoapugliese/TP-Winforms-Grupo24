using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)acceso.Lector["Id"];
                    aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    marcas.Add(aux);
                }

                return marcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        /*
         * listar
         * editar
         * crear
         * eliminar
         */
    }
}
