namespace prySilvaSP1v2
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.gbOrigen = new System.Windows.Forms.GroupBox();
            this.optAmbos = new System.Windows.Forms.RadioButton();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrigen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(69, 29);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(183, 21);
            this.cmbMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(22, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(98, 29);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 13;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(10, 29);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 12;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // gbOrigen
            // 
            this.gbOrigen.Controls.Add(this.optAmbos);
            this.gbOrigen.Controls.Add(this.optImportado);
            this.gbOrigen.Controls.Add(this.optNacional);
            this.gbOrigen.Location = new System.Drawing.Point(25, 67);
            this.gbOrigen.Name = "gbOrigen";
            this.gbOrigen.Size = new System.Drawing.Size(269, 68);
            this.gbOrigen.TabIndex = 14;
            this.gbOrigen.TabStop = false;
            this.gbOrigen.Text = "Origen";
            // 
            // optAmbos
            // 
            this.optAmbos.AutoSize = true;
            this.optAmbos.Location = new System.Drawing.Point(192, 29);
            this.optAmbos.Name = "optAmbos";
            this.optAmbos.Size = new System.Drawing.Size(57, 17);
            this.optAmbos.TabIndex = 14;
            this.optAmbos.TabStop = true;
            this.optAmbos.Text = "Ambos";
            this.optAmbos.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(432, 66);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(95, 33);
            this.cmdSalir.TabIndex = 16;
            this.cmdSalir.Text = "&Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(432, 17);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(95, 33);
            this.cmdConsultar.TabIndex = 15;
            this.cmdConsultar.Text = "&Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmMarca,
            this.clmOrigen,
            this.clmPrecio});
            this.dgvConsulta.Location = new System.Drawing.Point(25, 161);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.Size = new System.Drawing.Size(502, 211);
            this.dgvConsulta.TabIndex = 17;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmMarca
            // 
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            // 
            // clmOrigen
            // 
            this.clmOrigen.HeaderText = "Origen";
            this.clmOrigen.Name = "clmOrigen";
            this.clmOrigen.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 384);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.gbOrigen);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOCOR - Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.gbOrigen.ResumeLayout(false);
            this.gbOrigen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.GroupBox gbOrigen;
        private System.Windows.Forms.RadioButton optAmbos;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
    }
}