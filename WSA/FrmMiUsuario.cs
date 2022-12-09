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
    }
}
