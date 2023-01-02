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
            panel1.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
            panel2.BackColor = Color.FromArgb(VariablesGlobales.rgbPanel[0], VariablesGlobales.rgbPanel[1], VariablesGlobales.rgbPanel[2]);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            database.RealizarBackup();



        }
    }
}
