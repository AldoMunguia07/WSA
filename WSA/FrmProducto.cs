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
    public partial class FrmProducto : Form
    {
        Producto producto = new Producto();
        private bool seleccionado = false;

        public FrmProducto()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            producto.MostrarProducto(dgvProductos);
        }

        private void getValues()
        {
            producto.Descripcion = txtDescProducto.Text;
            producto.Precio = float.Parse(numPrecio.Value.ToString());
        }

        private void refresh()
        {
            txtDescProducto.Clear();
            numPrecio.Refresh();
            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private bool camposLlenos()
        {
            if (txtDescProducto.Text != "" && numPrecio.Value.ToString() != "")
                return true;
            else
                return false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            producto.BuscarProducto(dgvProductos, txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposLlenos())
            {
                getValues();
                producto.AgregarProducto(producto);
                MessageBox.Show("Producto agregado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    producto.ModificarProducto(producto);
                    MessageBox.Show("Producto modificado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                producto.ProductoId = int.Parse(row.Cells[0].Value.ToString());
                txtDescProducto.Text = row.Cells[1].Value.ToString();
                numPrecio.Value = decimal.Parse(row.Cells[2].Value.ToString());


                seleccionado = true;
                btnGuardar.Enabled = false;
            }
        }
    }
}
