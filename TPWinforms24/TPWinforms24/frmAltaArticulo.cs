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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPWinforms24
{
    public partial class frmAltaArticulo : Form
    {
        private List<string> imagenes = new List<string>();
        private Articulo articulo = null;
        private ImagenNegocio imagenesAux = new ImagenNegocio();
        private Imagen imagen = new Imagen();
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
                cargarImagen("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPFc3VTd9s2JUvf60H5XrNb0nl9Fr2Krfd3v-37M5MiAdEqO9T");
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                lblImagenArticulo.Visible = false;
                cboImagenesArticulo.Visible = false;
                btnEliminarImagen.Visible = false;

                if (articulo != null)
                {
                    ImagenNegocio imagenesAux = new ImagenNegocio();
                    Imagen imagen = new Imagen();
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cargarImagenCbo();
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
                if (validarCargaTxt())
                    return;
                if (validarCargaCbo())
                    return;
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

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagen = new ImagenNegocio();
            Imagen imagenAux = null;

            try
            {
                if ((cboImagenesArticulo.Items != null && cboImagenesArticulo.SelectedItem != null))
                {
                    imagenAux = (Imagen)cboImagenesArticulo.SelectedItem;
                    imagen.eliminarImagen(imagenAux.Id);
                }
                cargarImagenCbo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            if (txtImagen.Text == string.Empty) cargarImagen("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPFc3VTd9s2JUvf60H5XrNb0nl9Fr2Krfd3v-37M5MiAdEqO9T");
            else cargarImagen(txtImagen.Text);
        }
        private void cargarImagen(string url)
        {
            try
            {
                pbImagenArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbImagenArticulo.Load("https://www.redeszone.net/app/uploads-redeszone.net/2021/09/Error-404-01-e1633683457508.jpg");
            }
        }

        private void cboImagenesArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            imagen = (Imagen)cboImagenesArticulo.SelectedItem;
            cargarImagen(imagen.ImagenUrl);
        }
        private void cargarImagenCbo()
        {
            cboImagenesArticulo.DataSource = imagenesAux.listar(articulo.Id);
            cboImagenesArticulo.ValueMember = "Id";
            cboImagenesArticulo.DisplayMember = "ImagenUrl";
            lblImagenArticulo.Visible = true;
            cboImagenesArticulo.Visible = true;
            btnEliminarImagen.Visible = true;

            if (cboImagenesArticulo.SelectedItem != null)
            {
                imagen = (Imagen)cboImagenesArticulo.SelectedItem;
                cargarImagen(imagen.ImagenUrl);
            }
            else
            {
                btnEliminarImagen.Enabled = false;
                pbImagenArticulo.Visible = false;
            }
        }

        public bool validarCargaCbo()
        {
            if(cboCategoria.SelectedIndex < 1)
            {
                MessageBox.Show("Seleccione una categoría.");
                return true;
            }            
            if(cboMarca.SelectedIndex < 1)
            {
                MessageBox.Show("Seleccione una Marca.");
                return true;
            }
            return false;
        }

        public bool validarCargaTxt()
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.BackColor = Color.FromArgb(255, 255, 128, 128);
                return true;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.FromArgb(255, 255, 128, 128);
                return true;
            }
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.FromArgb(255, 255, 128, 128);
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                txtPrecio.BackColor = Color.FromArgb(255, 255, 128, 128);
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Por favor escriba solo números para el precio");
                return true;
            }
            txtCodigo.BackColor = System.Drawing.SystemColors.Control;
            txtNombre.BackColor = System.Drawing.SystemColors.Control;
            txtDescripcion.BackColor = System.Drawing.SystemColors.Control; 
            txtPrecio.BackColor = System.Drawing.SystemColors.Control;
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
    }
}
