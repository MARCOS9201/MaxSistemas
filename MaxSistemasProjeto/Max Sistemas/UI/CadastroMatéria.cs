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
    public partial class frmCadastroMatéria : Form
    {
        public frmCadastroMatéria(int aba = 0)
        {
            InitializeComponent();
            tbcCadastroMatéria.SelectTab(aba);

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal objfrmCadastroMateria = new frmTelaPrincipal();
            objfrmCadastroMateria.Show();
            Close();
        }
    }
}
