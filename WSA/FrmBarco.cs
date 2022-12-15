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
    public partial class FrmBarco : Form
    {
        Barco barco = new Barco();
        private bool seleccionado = false;
        public FrmBarco(bool esIngreso)
        {
            InitializeComponent();
            cargarDatos();
            if (esIngreso)
            {
                btnSeleccionar.Visible = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposLlenos())
            {
                getValues();
                barco.AgregarBarco(barco);
                MessageBox.Show("Barco agregado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getValues()
        {
            barco.Descripcion = txtDescBarco.Text;
        }

        private void cargarDatos()
        {
            barco.MostrarBarcos(dgvBarcos);
        }

        private void refresh()
        {
            txtDescBarco.Clear();
            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private bool camposLlenos()
        {
            if (txtDescBarco.Text != "")
                return true;
            else
                return false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                if (camposLlenos())
                {
                    getValues();
                    barco.ModificarBarco(barco);
                    MessageBox.Show("Barco modificado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvBarcos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBarcos.Rows[e.RowIndex];

                barco.BarcoId = int.Parse(row.Cells[0].Value.ToString());
                txtDescBarco.Text = row.Cells[1].Value.ToString();
                barco.Descripcion = row.Cells[1].Value.ToString();
                row.Selected = true;
                seleccionado = true;
                btnGuardar.Enabled = false;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                if (camposLlenos())
                {
                    VariablesGlobales.Barco = barco;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el barco", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            barco.BuscarBarco(dgvBarcos, txtBuscar.Text);
        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
