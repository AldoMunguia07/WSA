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
    public partial class FrmConductor : Form
    {
        Conductor conductor = new Conductor();
        private bool seleccionado = false;
        private bool isIncome = false;
        public FrmConductor(bool esIngreso)
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }
            cargarDatos();
            isIncome = esIngreso;
            if (esIngreso)
            {
                btnSeleccionar.Visible = true;
            }
        }

        private void getValues()
        {
            conductor.ConductorD = txtDescConductor.Text;
        }

        private void cargarDatos()
        {
            conductor.MostrarConductor(dgvConductores);
        }

        private void refresh()
        {
            txtDescConductor.Clear();
            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private bool camposLlenos()
        {
            if (txtDescConductor.Text != "")
                return true;
            else
                return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposLlenos())
            {
                getValues();
                conductor.AgregarConductor(conductor);
                MessageBox.Show("Conductor agregado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                if (camposLlenos())
                {
                    getValues();
                    conductor.ModificarConductor(conductor);
                    MessageBox.Show("Conductor modificado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el conductor", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conductor.BuscarConductor(dgvConductores, txtBuscar.Text);
        }

        private void dgvConductores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvConductores.Rows[e.RowIndex];

                conductor.ConductorId = int.Parse(row.Cells[0].Value.ToString());
                txtDescConductor.Text = row.Cells[1].Value.ToString();
                conductor.ConductorD = row.Cells[1].Value.ToString();
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
                    VariablesGlobales.Conductor = conductor;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el conductor", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            if (isIncome)
            {
                VariablesGlobales.Conductor = null;
                this.Close();
            }
            else
            {
                refresh();
            }
        }
    }
}
