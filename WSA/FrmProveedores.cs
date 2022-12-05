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
    public partial class FrmProveedores : Form
    {
        Proveedor proveedor = new Proveedor();
        private bool seleccionado = false;
        public FrmProveedores()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void getValues()
        {
            proveedor.ProveedorD = txtDescProveedor.Text;
        }

        private void cargarDatos()
        {
            proveedor.MostrarProveedor(dgvProveedores);
        }

        private void refresh()
        {
            txtDescProveedor.Clear();
            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private bool camposLlenos()
        {
            if (txtDescProveedor.Text != "")
                return true;
            else
                return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposLlenos())
            {
                getValues();
                proveedor.AgregarProveedor(proveedor);
                MessageBox.Show("Proveedor agregado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                if (camposLlenos())
                {
                    getValues();
                    proveedor.ModificarProveedor(proveedor);
                    MessageBox.Show("Proveedor modificado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el proveedor", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvProveedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];

                proveedor.ProveedorId = int.Parse(row.Cells[0].Value.ToString());
                txtDescProveedor.Text = row.Cells[1].Value.ToString();

                seleccionado = true;
                btnGuardar.Enabled = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            proveedor.BuscarProveedor(dgvProveedores, txtBuscar.Text);
        }
    }
}
