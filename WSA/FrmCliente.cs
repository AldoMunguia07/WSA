﻿using System;
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
        private bool isIncome = false;
        public FrmCliente(bool esIngreso)
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Visible = false;
            btnModificar.Visible = false;
            btnCancelar.Visible = false;

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

            if (VariablesGlobales.Usuario.TipoUsuarioId == 3)
            {
                btnGuardar.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardar.Visible = true;
                btnModificar.Visible = true;
                btnCancelar.Visible = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(camposLlenos())
            {
                getValues();
                cliente.AgregarCliente(cliente);
                MessageBox.Show("Cliente agregado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getValues()
        {
            cliente.ClienteD = txtDescCliente.Text;
        }

        private void cargarDatos()
        {
            cliente.MostrarCliente(dgvClientes);
        }

        private void refresh()
        {
            txtDescCliente.Clear();
            seleccionado = false;
           // btnGuardar.Enabled = true;
            cargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cliente.BuscarCliente(dgvClientes, txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(seleccionado)
            {
                if (camposLlenos())
                {
                    getValues();
                    cliente.ModificarCliente(cliente);
                    MessageBox.Show("Cliente modificado", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                cliente.ClienteId = int.Parse(row.Cells[0].Value.ToString());
                txtDescCliente.Text = row.Cells[1].Value.ToString();
                cliente.ClienteD = row.Cells[1].Value.ToString();

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
                    VariablesGlobales.Cliente = cliente;
                    this.Close();
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

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            if(isIncome)
            {
                VariablesGlobales.Cliente = null;
                this.Close();
            }
            else
            {
                refresh();
            }
            
        }
    }
}
