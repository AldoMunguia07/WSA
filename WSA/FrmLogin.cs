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
    public partial class FrmLogin : Form
    {
        Usuario usuario = new Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            usuario.BuscarUsuario(txtUsuario.Text.ToUpper(), usuario);
           

            if (usuario.UsuarioD != null)
            {
                if (usuario.UsuarioD == txtUsuario.Text.ToUpper() && usuario.Contrasena == txtContrasena.Text && usuario.Activo)
                {
                    MessageBox.Show(string.Format("¡Bienvenido {0}!", usuario.NombreUsuario), VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VariablesGlobales.Usuario = usuario;
                    usuario.BitacoraInicioSesion(usuario);
                    FrmPrincipal frmPrincipal = new FrmPrincipal(usuario);
                    frmPrincipal.Show();
                    frmPrincipal.FormClosed += cerrarSesion;                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario y/o la contraseña no es correcta o el usuario está inactivo. Favor verificar.", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("El usuario y/o la contraseña no es correcta o el usuario está inactivo. Favor verificar.", VariablesGlobales.TitleMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            VariablesGlobales.Usuario = null;
            usuario.BitacoraCierreSesion(usuario);
            txtUsuario.Text = "";
            txtContrasena.Text = "";            
            this.Show();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnInicioSesion.PerformClick();

            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnInicioSesion.PerformClick();
            }
        }
    }
}
