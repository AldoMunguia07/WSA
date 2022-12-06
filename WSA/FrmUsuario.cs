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
    public partial class FrmUsuario : Form
    {
        Usuario usuario = new Usuario();
        private bool seleccionado = false, activo = true;
        private string username = "";
        public FrmUsuario()
        {
            InitializeComponent();
            cargarDatos();

        }

        private void cargarDatos()
        {
            usuario.MostrarUsuario(dgvUsuarios);
            usuario.CargarComboBoxEstado(cmbTipoUsuario);
            dgvUsuarios.Columns[5].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;

        }

        private void getValues()
        {
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.UsuarioD = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            usuario.TipoUsuario = (int)cmbTipoUsuario.SelectedValue;
            usuario.Activo = activo;


        }

        private void refresh()
        {
            txtNombreUsuario.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            cmbTipoUsuario.SelectedIndex = 0;
            activo = true;
            btnActivo.Text = "Activo";
            btnActivo.BackColor = Color.Green;
            username = "";

            seleccionado = false;
            btnGuardar.Enabled = true;
            cargarDatos();
        }

        private bool camposLlenos()
        {
            if (txtNombreUsuario.Text != "" && txtUsuario.Text != "" && txtContrasena.Text != "" && txtConfirmarContrasena.Text != "")
                return true;
            else
                return false;
        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            if(activo)
            {
                activo = false;
                btnActivo.Text = "Inactivo";
                btnActivo.BackColor = Color.Red;
            }
            else
            {
                activo = true;
                btnActivo.Text = "Activo";
                btnActivo.BackColor = Color.Green;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposLlenos())
            {
                if(txtContrasena.TextLength >= 8)
                {
                    if (txtContrasena.Text == txtConfirmarContrasena.Text)
                    {
                        if(!usuario.ExisteUsuario(txtUsuario.Text))
                        {
                            getValues();
                            usuario.AgregarUsuario(usuario);
                            MessageBox.Show("Usuario agregado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();

                        }
                        else
                        {
                            MessageBox.Show("El usuario ya existe", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe contener al menos 8 caracteres", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            usuario.BuscarUsuario(dgvUsuarios, txtBuscar.Text);
     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(seleccionado)
            {
                if (camposLlenos())
                {
                    if (txtContrasena.TextLength >= 8)
                    {
                        if (txtContrasena.Text == txtConfirmarContrasena.Text)
                        {
                            if (!usuario.ExisteUsuario(txtUsuario.Text) || txtUsuario.Text == username)
                            {
                                getValues();
                                usuario.ModificarUsuario(usuario);
                                MessageBox.Show("Usuario modificado", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refresh();

                            }
                            else
                            {
                                MessageBox.Show("El usuario ya existe", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe contener al menos 8 caracteres", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Seleccione usuario a modificar", "WAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void dgvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                usuario.UsuarioId = int.Parse(row.Cells[0].Value.ToString());
                txtNombreUsuario.Text = row.Cells[1].Value.ToString();
                txtUsuario.Text = row.Cells[2].Value.ToString();
                username = row.Cells[2].Value.ToString();
                cmbTipoUsuario.SelectedValue = int.Parse(row.Cells[6].Value.ToString());
                txtContrasena.Text = row.Cells[5].Value.ToString();
                txtConfirmarContrasena.Text = row.Cells[5].Value.ToString();

                activo = Convert.ToBoolean(row.Cells[4].Value);
                if(activo)
                {
                    activo = true;
                    btnActivo.Text = "Activo";
                    btnActivo.BackColor = Color.Green;
                }
                else
                {
                    activo = false;
                    btnActivo.Text = "Inactivo";
                    btnActivo.BackColor = Color.Red;
                }

                seleccionado = true;
                btnGuardar.Enabled = false;
            }
        }
    }
}
