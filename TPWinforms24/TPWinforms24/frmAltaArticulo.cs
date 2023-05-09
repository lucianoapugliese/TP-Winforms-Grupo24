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
        List<string> imagenes = new List<string>();
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
            int idAux;
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articuloNegocio.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                idAux = articuloNegocio.consultarUltimoId();

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
    }
}
