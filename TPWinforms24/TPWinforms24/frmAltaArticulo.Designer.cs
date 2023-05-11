namespace TPWinforms24
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblImagenArticulo = new System.Windows.Forms.Label();
            this.cboImagenesArticulo = new System.Windows.Forms.ComboBox();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCodigo.Location = new System.Drawing.Point(57, 40);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(52, 73);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrecio.Location = new System.Drawing.Point(61, 106);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 218);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblMarca.Location = new System.Drawing.Point(62, 132);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCategoria.Location = new System.Drawing.Point(44, 165);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 40);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 73);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(132, 106);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(132, 218);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(140, 77);
            this.txtDescripcion.TabIndex = 7;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(132, 132);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(140, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(132, 165);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(140, 21);
            this.cboCategoria.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptar.Location = new System.Drawing.Point(175, 413);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Location = new System.Drawing.Point(299, 413);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblImagen.Location = new System.Drawing.Point(22, 320);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(91, 13);
            this.lblImagen.TabIndex = 8;
            this.lblImagen.Text = "Imagen nueva:";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarImagen.Location = new System.Drawing.Point(299, 310);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(88, 23);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(132, 313);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(140, 20);
            this.txtImagen.TabIndex = 8;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarMarca.Location = new System.Drawing.Point(288, 132);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(26, 20);
            this.btnAgregarMarca.TabIndex = 4;
            this.btnAgregarMarca.Text = "+";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(288, 164);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(26, 20);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "+";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // lblImagenArticulo
            // 
            this.lblImagenArticulo.AutoSize = true;
            this.lblImagenArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblImagenArticulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblImagenArticulo.Location = new System.Drawing.Point(22, 365);
            this.lblImagenArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenArticulo.Name = "lblImagenArticulo";
            this.lblImagenArticulo.Size = new System.Drawing.Size(65, 13);
            this.lblImagenArticulo.TabIndex = 10;
            this.lblImagenArticulo.Text = "Imagenes:";
            // 
            // cboImagenesArticulo
            // 
            this.cboImagenesArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImagenesArticulo.FormattingEnabled = true;
            this.cboImagenesArticulo.Location = new System.Drawing.Point(132, 365);
            this.cboImagenesArticulo.Name = "cboImagenesArticulo";
            this.cboImagenesArticulo.Size = new System.Drawing.Size(140, 21);
            this.cboImagenesArticulo.TabIndex = 11;
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarImagen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarImagen.Location = new System.Drawing.Point(299, 365);
            this.btnEliminarImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(88, 23);
            this.btnEliminarImagen.TabIndex = 12;
            this.btnEliminarImagen.Text = "Eliminar";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(355, 40);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(207, 230);
            this.pbImagenArticulo.TabIndex = 13;
            this.pbImagenArticulo.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 483);
            this.Controls.Add(this.pbImagenArticulo);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.cboImagenesArticulo);
            this.Controls.Add(this.lblImagenArticulo);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo artículo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblImagenArticulo;
        private System.Windows.Forms.ComboBox cboImagenesArticulo;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
    }
}