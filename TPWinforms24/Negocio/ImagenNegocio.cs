﻿using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> imagenes = new List<Imagen>();
            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                acceso.ejecutarLectura();

                while (acceso.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Id = (int)acceso.Lector["Id"];
                    imagen.Articulo = new Articulo();
                    imagen.Articulo.Id = (int)acceso.Lector["IdArticulo"];
                    // Nombre del articulo
                    imagen.ImagenUrl = (string)acceso.Lector["ImagenUrl"];
                    imagenes.Add(imagen);

                }
                return imagenes;
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
    }
}
