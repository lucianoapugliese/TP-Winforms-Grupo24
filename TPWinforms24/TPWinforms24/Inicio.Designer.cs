namespace TPWinforms24
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnInicio = new System.Windows.Forms.Button();
            this.tbBienvenida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInicio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInicio.Location = new System.Drawing.Point(174, 254);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(141, 51);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // tbBienvenida
            // 
            this.tbBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBienvenida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBienvenida.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbBienvenida.Location = new System.Drawing.Point(111, 92);
            this.tbBienvenida.Name = "tbBienvenida";
            this.tbBienvenida.Size = new System.Drawing.Size(258, 35);
            this.tbBienvenida.TabIndex = 1;
            this.tbBienvenida.Text = "Bienvenidos al Sistema";
            this.tbBienvenida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnInicio;
            this.ClientSize = new System.Drawing.Size(485, 369);
            this.Controls.Add(this.tbBienvenida);
            this.Controls.Add(this.btnInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox tbBienvenida;
    }
}