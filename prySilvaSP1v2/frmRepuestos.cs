using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaSP1v2
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private const string PATH_ARCHIVO = "Repuestos.txt";

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";

            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;

            optNacional.Checked = true;
        }

        private bool ValidarDatos()
        {
            bool resultado = false;

            if (txtCodigo.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        Archivo RepuestosForm = new Archivo();
                        RepuestosForm.NombreArchivo = PATH_ARCHIVO;
                        // controla que no se repita el codigo del repuesto
                        if (RepuestosForm.BuscarCodigoRepuesto(txtCodigo.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }

        private Repuesto CrearRepuesto()
        {   
            Repuesto nuevoRep = new Repuesto();
            
            nuevoRep.Codigo = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.Precio = decimal.Parse(txtPrecio.Text);

            if (optNacional.Checked)
            {
                nuevoRep.Origen = "Nacional";
            }
            else
            {
                nuevoRep.Origen = "Importado";
            }

            return nuevoRep;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if(!Char.IsNumber(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (int)Keys.Back )
            {
                e.Handled = true;
            }

            if(e.KeyChar == ',' && txtPrecio.Text.Contains (",") )
            {
                e.Handled = true;
            } 
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Repuesto nuevoRep = CrearRepuesto();         
                
                Archivo RepuestosForm = new Archivo();         
                RepuestosForm.NombreArchivo = PATH_ARCHIVO;         
                RepuestosForm.GrabarRepuesto(nuevoRep);         
                
                Inicializar();                                                    
            }     
            else
            {         
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
            } 
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            // se crea un objeto de tipo Form2 pasando el path al archivo de repuestos
            frmConsulta x = new frmConsulta(PATH_ARCHIVO);
            x.ShowDialog();
        }
    }
}