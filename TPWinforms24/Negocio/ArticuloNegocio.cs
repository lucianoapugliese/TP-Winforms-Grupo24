using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagen = new ImagenNegocio();

            try
            {
                datos.setearConsulta("SELECT DISTINCT A.Id, A.Nombre, A.Codigo, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.ID = A.IdMarca LEFT JOIN CATEGORIAS C ON C.ID = A.IdCategoria");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)datos.Lector["Id"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else articulo.Categoria.Descripcion = " ";
                    decimal DosDecimal;
                    DosDecimal = (decimal)datos.Lector["Precio"];

                    articulo.Precio = Math.Truncate(DosDecimal * 100) / 100;
                    articulo.Imagenes = imagen.listar(articulo.Id);
                    articulos.Add(articulo);
                }
                return articulos;
                //decimal DosDecimal;
                //DosDecimal = (decimal)datos.Lector["precio"];
                //aux.Precio = Decimal.Parse(DosDecimal.ToString("0.00"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.Precio + "," + articulo.Marca.Id + "," + articulo.Categoria.Id + ")");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
