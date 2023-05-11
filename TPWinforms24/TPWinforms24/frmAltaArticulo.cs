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
        private List<string> imagenes = new List<string>();
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
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
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            int idAux;
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                if (cboMarca.SelectedIndex == 0) articulo.Marca = null;
                else
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                if (cboCategoria.SelectedIndex == 0) articulo.Categoria = null;
                else
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    idAux = articulo.Id;
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                    idAux = articuloNegocio.consultarUltimoId();
                }

                if (imagenes.Count > 0)
                {
                    Imagen imagenAux = new Imagen();
                    ImagenNegocio imagenNegocio = new ImagenNegocio();
                    foreach (string imagen in imagenes)
                    {
                        imagenAux.IdArticulo = idAux;
                        imagenAux.ImagenUrl = imagen;
                        imagenNegocio.agregar(imagenAux);
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            imagenes.Add(txtImagen.Text);
            txtImagen.Clear();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            frmAltaMarca frmAltaMarca = new frmAltaMarca();
            frmAltaMarca.ShowDialog();
            cboMarca.DataSource = marcaNegocio.listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio marcaNegocio = new CategoriaNegocio();
            frmAltaCategoria frmAltaCategoria = new frmAltaCategoria();
            frmAltaCategoria.ShowDialog();
            cboCategoria.DataSource = marcaNegocio.listar();
        }
    }
}
