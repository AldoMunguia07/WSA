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
    public partial class FrmCliente : Form
    {
        Cliente cliente = new Cliente();
        private bool seleccionado = false;
        public FrmCliente()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                getValues();
                cliente.AgregarCliente(cliente);
                MessageBox.Show("Cliente agregado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getValues()
        {
            cliente.ClienteD = txtDescCliente.Text;
        }

        private void cargarDatos()
        {
            cliente.MostrarCliente(dgvBarcos);
        }

        private void refresh()
        {
            txtDescCliente.Clear();
            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cliente.BuscarCliente(dgvBarcos, txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(seleccionado)
            {
                if (camposLlenos())
                {
                    getValues();
                    cliente.ModificarCliente(cliente);
                    MessageBox.Show("Cliente modificado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el cliente", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private bool camposLlenos()
        {
            if (txtDescCliente.Text != "")
                return true;
            else
                return false;
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBarcos.Rows[e.RowIndex];

                cliente.ClienteId = int.Parse(row.Cells[0].Value.ToString());
                txtDescCliente.Text = row.Cells[1].Value.ToString();
      
                seleccionado = true;
                btnGuardar.Enabled = false;
            }
        }
    }
}
