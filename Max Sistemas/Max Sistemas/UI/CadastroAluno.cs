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
    public partial class frmCadastroAluno : Form
    {
 
        public frmCadastroAluno(int aba = 0)
        {
            InitializeComponent();
            tbcLayout.SelectTab(aba);
        }
        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide(); //esconde a tela de menu principal
            frmTelaPrincipal newForm2 = new frmTelaPrincipal(); //Chama tela de menu principal
            newForm2.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc"); //Metodo para chamar a calculadora no menu principal
        }

        private void notasAdesivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Simnet\\Simple Sticky Notes\\ssn.exe"); //Metodo para chamar a notas adesivas no menu principal
        }

        private void capturaDeTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\PrtScr\\PrtScr.exe"); //Metodo para chamar a captura de tela no menu principal 
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { }
        }

        private void tbcEditarCadastro_Click(object sender, EventArgs e)
        {
          
        }
    }
}
