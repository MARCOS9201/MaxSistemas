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
    public partial class txtCadProfessorMatriculaCEP : Form
    {
        public txtCadProfessorMatriculaCEP(int aba = 0)
        {
            InitializeComponent();
            tbcCadastroProfessor.SelectTab(aba);
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            frmTelaPrincipal newForm2 = new frmTelaPrincipal(); //Chama tela de menu principal
            newForm2.ShowDialog();
            Close();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
