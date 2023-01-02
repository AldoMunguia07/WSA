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
        private bool isIncome = false;
        private string descripcionProducto = "";
        public FrmProducto(bool esIngreso)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            panel2.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            cargarDatos();
            isIncome = esIngreso;
            if (esIngreso)
            {
                btnSeleccionar.Visible = true;
            }
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
            numPrecio.Value = 0;
            cargarDatos();
            descripcionProducto = "";
        }

        private bool camposLlenos()
        {
            if (txtDescProducto.Text != "" && numPrecio.Text != "")
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
                if (!producto.ExisteProducto(txtDescProducto.Text))
                {
                    getValues();
                    producto.AgregarProducto(producto);
                    MessageBox.Show("Producto agregado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("El producto ya existe", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

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
                    if (!producto.ExisteProducto(txtDescProducto.Text) || txtDescProducto.Text.ToUpper() == descripcionProducto)
                    {
                        getValues();
                        producto.ModificarProducto(producto);
                        MessageBox.Show("Producto modificado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();
                    }
                    else
                    {
                        MessageBox.Show("El producto ya existe", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                producto.ProductoId = int.Parse(row.Cells[0].Value.ToString());
                txtDescProducto.Text = row.Cells[1].Value.ToString();
                descripcionProducto = row.Cells[1].Value.ToString();
                numPrecio.Text = row.Cells[2].Value.ToString();

                numPrecio.Value = decimal.Parse(row.Cells[2].Value.ToString());
                producto.Descripcion = row.Cells[1].Value.ToString();

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
                    VariablesGlobales.Producto = producto;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            if (isIncome)
            {
                VariablesGlobales.Producto = null;
                this.Close();
            }
            else
            {
                refresh();
            }
        }

        private void numPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/


        }
    }
}
