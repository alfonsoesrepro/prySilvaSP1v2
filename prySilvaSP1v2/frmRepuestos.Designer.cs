namespace prySilvaSP1v2
{
    partial class frmRepuestos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.gbRepuestos = new System.Windows.Forms.GroupBox();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.gbRepuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRepuestos
            // 
            this.gbRepuestos.Controls.Add(this.optImportado);
            this.gbRepuestos.Controls.Add(this.lblOrigen);
            this.gbRepuestos.Controls.Add(this.optNacional);
            this.gbRepuestos.Controls.Add(this.txtPrecio);
            this.gbRepuestos.Controls.Add(this.lblPrecio);
            this.gbRepuestos.Controls.Add(this.cmbMarca);
            this.gbRepuestos.Controls.Add(this.lblMarca);
            this.gbRepuestos.Controls.Add(this.txtNombre);
            this.gbRepuestos.Controls.Add(this.lblNombre);
            this.gbRepuestos.Controls.Add(this.txtCodigo);
            this.gbRepuestos.Controls.Add(this.lblCodigo);
            this.gbRepuestos.Location = new System.Drawing.Point(12, 12);
            this.gbRepuestos.Name = "gbRepuestos";
            this.gbRepuestos.Size = new System.Drawing.Size(343, 254);
            this.gbRepuestos.TabIndex = 0;
            this.gbRepuestos.TabStop = false;
            this.gbRepuestos.Text = "Repuestos";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(209, 211);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 10;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(24, 213);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 8;
            this.lblOrigen.Text = "Origen";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(121, 211);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 9;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(121, 164);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(84, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(24, 171);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(121, 119);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(183, 21);
            this.cmbMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(24, 127);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(121, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(121, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(381, 36);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(95, 38);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "&Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(381, 86);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(95, 38);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "&Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(381, 139);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(95, 38);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "&Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(381, 188);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(95, 38);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 283);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.gbRepuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOCOR - Repuestos";
            this.Load += new System.EventHandler(this.frmRepuestos_Load);
            this.gbRepuestos.ResumeLayout(false);
            this.gbRepuestos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRepuestos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
    }
}

