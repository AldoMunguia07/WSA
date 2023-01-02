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
    public partial class FrmRealizarBackup : Form
    {
        Database database = new Database();
        public FrmRealizarBackup()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(VariablesGlobales.rgbBotones[0], VariablesGlobales.rgbBotones[1], VariablesGlobales.rgbBotones[2]);
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            database.RealizarBackup();



        }
    }
}
