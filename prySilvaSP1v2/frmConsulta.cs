using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySilvaSP1v2
{
    public partial class frmConsulta : Form
    {
        private string PATH_ARCHIVO;

        public frmConsulta(string Path)
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {   
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;     
            
            optNacional.Checked = true;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if(!File.Exists (Application.StartupPath + "\\" + PATH_ARCHIVO))     
            {         
                MessageBox.Show("No hay datos para mostrar", "Consulta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);         
                return;     
            }     
            
            Archivo RepuestosForm = new Archivo();     
            RepuestosForm.NombreArchivo = PATH_ARCHIVO;     
            List<Repuesto> listaRepuestos = RepuestosForm.ObtenerRepuestosOrdenados();      
            
            dgvConsulta.Rows.Clear();     
            
            foreach (Repuesto rep in listaRepuestos)     
            {
                if (rep.Marca == cmbMarca.SelectedItem.ToString())         
                {
                    // controlar el tipo de Origen
                    if (optImportado.Checked && rep.Origen == "Importado")             
                    {
                        dgvConsulta.Rows.Add(rep.Codigo, rep.Nombre,                     
                            rep.Marca, rep.Origen, rep.Precio.ToString());             
                    }             
                    else             
                    {                 
                        if (optNacional.Checked && rep.Origen == "Nacional")                 
                        {
                            dgvConsulta.Rows.Add(rep.Codigo, rep.Nombre,                         
                                rep.Marca, rep.Origen, rep.Precio.ToString());                 
                        }                 
                        else                 
                        {                     
                            if (optAmbos.Checked)                     
                            {
                                dgvConsulta.Rows.Add(rep.Codigo, rep.Nombre,                             
                                    rep.Marca, rep.Origen, rep.Precio.ToString());                     
                            }                 
                        }             
                    }         
                }     
            } 
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}