using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinforms24
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Categoria = new Categoria();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Marca marcaAux = new Marca();
            Categoria catAux = new Categoria();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                marcaAux = (Marca)cboMarca.SelectedItem;
                articulo.Marca.Id = marcaAux.Id;
                catAux = (Categoria)cboCategoria.SelectedItem;
                articulo.Categoria.Id = catAux.Id;
                articuloNegocio.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
