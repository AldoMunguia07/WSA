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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        Usuario miUsuario = new Usuario();
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            miUsuario = usuario;
            FrmVehiculosEnTransito frmVehiculosEnTransito = new FrmVehiculosEnTransito();
            CargarFormulario(frmVehiculosEnTransito);
            tslbNombreUsuario.Text = String.Format("{0} - {1}", usuario.NombreUsuario, usuario.TipoUsuario);
            if (usuario.TipoUsuarioId == 2)
            {
                gestionToolStripMenuItem.Visible = false;
                administracinToolStripMenuItem.Visible = false;
                
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void vehículosEnTransitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculosEnTransito frmVehiculosEnTransito = new FrmVehiculosEnTransito();
            CerrarFormularios();
            CargarFormulario(frmVehiculosEnTransito);
        }

        private void CargarFormulario(Form form)
        {

            form.MdiParent = this;
            form.ControlBox = false;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void CerrarFormularios()
        {
            tslbNombreUsuario.Text = tslbNombreUsuario.Text = String.Format("{0} - {1}", VariablesGlobales.Usuario.NombreUsuario, VariablesGlobales.Usuario.TipoUsuario);
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(false);
            CerrarFormularios();
            CargarFormulario(frmCliente);
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConductor frmConductor = new FrmConductor(false);
            CerrarFormularios();
            CargarFormulario(frmConductor);
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto(false);
            CerrarFormularios();
            CargarFormulario(frmProducto);
        }

        private void barcosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarco frmBarco = new FrmBarco(false);
            CerrarFormularios();
            CargarFormulario(frmBarco);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            CerrarFormularios();
            CargarFormulario(frmUsuario);
        }

        private void boletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBoletas frmBoletas = new FrmBoletas();
            CerrarFormularios();
            CargarFormulario(frmBoletas);
        }

        private void respaldoDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRealizarBackup frmRealizarBackup = new FrmRealizarBackup();
            CerrarFormularios();
            CargarFormulario(frmRealizarBackup);
        }

        private void encabezadoBoletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEncabezadoBoleta frmEncabezadoBoleta = new FrmEncabezadoBoleta();
            CerrarFormularios();
            CargarFormulario(frmEncabezadoBoleta);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            CerrarFormularios();
            CargarFormulario(frmBitacora);
        }

        private void miUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMiUsuario frmMiUsuario = new FrmMiUsuario();
            CerrarFormularios();
            CargarFormulario(frmMiUsuario);
        }

        private void entradasAnuladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradasAnuladas frmEntradasAnuladas = new FrmEntradasAnuladas();
            CerrarFormularios();
            CargarFormulario(frmEntradasAnuladas);
            
        }

        private void configuraciónIndicadorDeBásculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIndicadorBascula frmIndicadorBascula = new FrmIndicadorBascula();
            CerrarFormularios();
            CargarFormulario(frmIndicadorBascula);
        }

        private void boletasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rFrmBoletas rFrmBoletas = new rFrmBoletas();
            CerrarFormularios();
            CargarFormulario(rFrmBoletas);
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFrmBitacora rFrmBitacora = new rFrmBitacora();
            CerrarFormularios();
            CargarFormulario(rFrmBitacora);
        }
    }
}
