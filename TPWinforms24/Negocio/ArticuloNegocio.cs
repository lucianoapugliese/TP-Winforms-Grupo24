﻿using dominio;
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
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.Imagenes = imagen.listar(articulo.Id);
                    articulos.Add(articulo);
                }
                return articulos;
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
