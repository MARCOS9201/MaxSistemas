using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max_Sistemas
{
    public partial class frmCadastroFrequência : Form
    {
        public frmCadastroFrequência(int aba = 0)
        {
            InitializeComponent();
            tbCadastroFrequencia.SelectTab(aba);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal objfrmCadastroFrequencia = new frmTelaPrincipal();
            objfrmCadastroFrequencia.Show();
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
