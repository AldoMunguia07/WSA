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
    public partial class FrmMiUsuario : Form
    {
        Usuario usuario = new Usuario();
        private string username = "";
        public FrmMiUsuario()
        {
            InitializeComponent();
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            usuario.BuscarUsuarioPorId(VariablesGlobales.Usuario.UsuarioId, usuario);
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtUsuario.Text = usuario.UsuarioD;
            txtContrasena.Text = usuario.Contrasena;
            txtConfirmarContrasena.Text = usuario.Contrasena;
            txtTipoUsuario.Text = usuario.TipoUsuario;
            if(usuario.Activo)
            {
                btnActivo.BackColor = Color.Green;
                btnActivo.Text = "Activo";
            }
            else
            {
                btnActivo.BackColor = Color.Red;
                btnActivo.Text = "Inactivo";
            }
            username = VariablesGlobales.Usuario.UsuarioD;

        }

        private void chbVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if(chbVerContraseña.Checked)
            {
                txtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void chbVerCContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerCContraseña.Checked)
            {
                txtConfirmarContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmarContrasena.UseSystemPasswordChar = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                            VariablesGlobales.Usuario = usuario;
                            
                            MessageBox.Show("Información actualizada", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("El usuario ya existe", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe contener al menos 8 caracteres", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void getValues()
        {
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.UsuarioD = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            usuario.TipoUsuarioId = VariablesGlobales.Usuario.TipoUsuarioId;
            usuario.Activo = VariablesGlobales.Usuario.Activo;


        }

        private bool camposLlenos()
        {
            if (txtNombreUsuario.Text != "" && txtUsuario.Text != "" && txtContrasena.Text != "" && txtConfirmarContrasena.Text != "")
                return true;
            else
                return false;
        }

    }
}
