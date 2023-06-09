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
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
            cargardgv();
        }

        private void cargardgv()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articulos = articuloNegocio.listar();
            dgvArticulos.DataSource = articulos;
            //dgvArticulos.Columns[""]
            dgvArticulos.Columns["Descripcion"].Visible = false;
            btnAnterior.Enabled = false;
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            btnSiguiente.Enabled = seleccionado.Imagenes.Count > 1 ? true : false;
        }

        private void pbArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articulo.Imagenes[0].ImagenUrl);
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
            txtDescripcion.Text = seleccionado.Descripcion.ToString();
            //foreach (Imagen item in seleccionado.Imagenes)
            //{
            //    cargarImagen(item.ImagenUrl);

            //}
            btnSiguiente.Enabled = seleccionado.Imagenes.Count > 1 ? true : false;
            if(seleccionado.Imagenes.Count > 0 )
            cargarImagen(seleccionado.Imagenes[0].ImagenUrl);
            //if (seleccionado.Imagenes.Count > 0)
            //    btnSiguiente.Enabled = true;
            //else btnSiguiente.Enabled = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if (pbArticulo.ImageLocation != seleccionado.Imagenes[0].ImagenUrl)
            {
                string urlACargar = seleccionado.Imagenes[seleccionado.Imagenes.FindIndex(x => x.ImagenUrl == pbArticulo.ImageLocation) - 1].ImagenUrl;
                if (pbArticulo.ImageLocation == seleccionado.Imagenes[1].ImagenUrl)
                    btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
                cargarImagen(urlACargar);
            }
            //else
            //    btnAnterior.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            if (pbArticulo.ImageLocation != seleccionado.Imagenes[seleccionado.Imagenes.Count - 1].ImagenUrl)
            {
                string urlACargar = seleccionado.Imagenes[seleccionado.Imagenes.FindIndex(x => x.ImagenUrl == pbArticulo.ImageLocation) + 1].ImagenUrl;
                btnAnterior.Enabled = true;
                if (pbArticulo.ImageLocation == seleccionado.Imagenes[seleccionado.Imagenes.Count - 2].ImagenUrl)
                    btnSiguiente.Enabled = false;
                cargarImagen(urlACargar);
            }
            //else
            //    btnSiguiente.Enabled = false;
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvArticulos.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null)
                {
                    decimal aux = (decimal)e.Value;
                    string precio = aux.ToString();
                    precio = "$ " + precio;
                    e.Value = precio;

                    //decimal DosDecimal;
                    //DosDecimal = (decimal)datos.Lector["precio"];
                    //aux.Precio = Decimal.Parse(DosDecimal.ToString("0.00"));
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                //punto de control
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length > 2)
            {
                listaFiltrada = articulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = articulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargardgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo seleccionado;
            int id;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                articuloNegocio.eliminar(seleccionado.Id);
                id = seleccionado.Id;
                imagenNegocio.eliminar(id);
                cargardgv();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargardgv();
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el campo a filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el criterio a filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El precio no puede estar vacío");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor escriba solo números");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }


        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
