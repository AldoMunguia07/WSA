using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSA.Clases;

namespace WSA
{
    public partial class FrmEncabezadoBoleta : Form
    {
        EncabezadoBoleta encabezadoBoleta = new EncabezadoBoleta();
        public FrmEncabezadoBoleta()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }
            encabezadoBoleta.CargarFormularioEncabezadoBoleta(txtEmpresa, txtDireccion, txtTelefono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                getValues();
                if (!encabezadoBoleta.ExisteEncabezado(encabezadoBoleta))
                {
                    encabezadoBoleta.AgregarEncabezadoBoleta(encabezadoBoleta);
                }
                else
                {
                    encabezadoBoleta.ModificarEncabezadoBoleta(encabezadoBoleta);
                }
                MessageBox.Show("Cambios guardados", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                encabezadoBoleta.CargarFormularioEncabezadoBoleta(txtEmpresa, txtDireccion, txtTelefono);

            }
           
            
        }

        private void getValues()
        {
            encabezadoBoleta.Empresa = txtEmpresa.Text;
            encabezadoBoleta.Direccion = txtDireccion.Text;
            encabezadoBoleta.Telefono = txtTelefono.Text;

        }

        private bool camposLlenos()
        {
            if (txtEmpresa.Text != string.Empty)
            {
                if (txtDireccion.Text != string.Empty)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ingrese la dirección de la empresa", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la empresa", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }
    }
}
