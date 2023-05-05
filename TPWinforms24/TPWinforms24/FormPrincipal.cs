﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinforms24
{
    public partial class FormPrincipal : Form
    {
        private List<Articulo> articulos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articulos = articuloNegocio.listar();
            dgvArticulos.DataSource = articulos;
            //dgvArticulos.Columns[""]

        }

        private void pbArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            foreach (Imagen item in articulo.Imagenes)
            {
                cargarImagen(item.ImagenUrl);

            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbArticulo.Load(url);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://www.redeszone.net/app/uploads-redeszone.net/2021/09/Error-404-01-e1633683457508.jpg");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //foreach (Imagen item in seleccionado.Imagenes)
            //{
            //    cargarImagen(item.ImagenUrl);

            //}
            cargarImagen(seleccionado.Imagenes[0].ImagenUrl);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if (pbArticulo.ImageLocation != seleccionado.Imagenes[0].ImagenUrl)
            {
                string urlACargar = seleccionado.Imagenes[seleccionado.Imagenes.FindIndex(x => x.ImagenUrl == pbArticulo.ImageLocation) - 1].ImagenUrl;
                cargarImagen(urlACargar);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if (pbArticulo.ImageLocation != seleccionado.Imagenes[seleccionado.Imagenes.Count - 1].ImagenUrl)
            {
                string urlACargar = seleccionado.Imagenes[seleccionado.Imagenes.FindIndex(x => x.ImagenUrl == pbArticulo.ImageLocation) + 1].ImagenUrl;
                cargarImagen(urlACargar);
            }
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if (this.dgvArticulos.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null)
                {
                    decimal aux = (decimal)e.Value;
                    string precio = aux.ToString();
                    precio = "$ " + precio;
                    e.Value = precio;
                }
            }
        }
    }
}
