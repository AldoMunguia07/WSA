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
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            database.RealizarBackup();



        }
    }
}
