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
    public partial class frmPesquisaAluno : Form
    {
        public frmPesquisaAluno()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal objfrmPesquisaAluno = new frmTelaPrincipal();
            objfrmPesquisaAluno.Show();
            Close(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
