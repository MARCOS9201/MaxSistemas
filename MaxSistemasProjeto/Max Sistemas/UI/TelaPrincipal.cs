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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Encerra o menu principal fechando todo o sistema
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc"); //Metodo para chamar a calculadora no menu principal
        }

        private void notasAdesivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Simnet\\Simple Sticky Notes\\ssn.exe"); //Metodo para chamar a notas adesivas no menu principal
        }

        private void ferramentaDeCapturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\PrtScr\\PrtScr.exe"); //Metodo para chamar a captura de tela no menu principal 
        }

        private void cadastroNovoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); //esconde a tela de menu principal
            FrmCadastroPerfil objfrmTelaPrincipal = new FrmCadastroPerfil(); //Chama tela de menu principal
            objfrmTelaPrincipal.Show();
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAluno objfrmTelaPrincipal = new frmCadastroAluno (); 
            objfrmTelaPrincipal.Show();
            Close();
            
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmTelaLogin objfrmTelaPrincipal = new frmTelaLogin(); 
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAluno objfrmTelaPrincipal = new frmCadastroAluno(1);
            objfrmTelaPrincipal.Show();
            Close();

        }

        private void novoCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtCadProfessorMatriculaCEP ObjfrmTelaPrincipal = new txtCadProfessorMatriculaCEP(0);
            ObjfrmTelaPrincipal.Show();
            Close();

        }

        private void cadastroMatériaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroMatéria objfrmTelaPrincipal = new frmCadastroMatéria(0);
            objfrmTelaPrincipal.Show();
            Close();    
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaAluno objfrmTelaPrincipal = new frmPesquisaAluno();
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void editarMatériaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMatéria objfrmTelaPrincipal = new frmCadastroMatéria(1);
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void cadastroFrequênciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroFrequência objfrmTelaPrincipal = new frmCadastroFrequência();
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaProfessor objfrmTelaPrincipal = new frmPesquisaProfessor();
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void editarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtCadProfessorMatriculaCEP ObjfrmTelaPrincipal = new txtCadProfessorMatriculaCEP(1);
            ObjfrmTelaPrincipal.Show();
            Close();
        }

        private void matériaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaMateria objfrmTelaPrincipal = new frmPesquisaMateria();
            objfrmTelaPrincipal.Show();
            Close();
        }

        private void editarFrequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFrequência objfrmTelaPrincipal = new frmCadastroFrequência(1);
            objfrmTelaPrincipal.Show();
            Close();

        }

        private void ToolStripCadastroPerfil(object sender, EventArgs e)
        {
            FrmCadastroPerfil objfrmTelaPrincipal = new FrmCadastroPerfil();
            objfrmTelaPrincipal.Show();
            Hide();
        }

        private void ToolStripLogoff_Click(object sender, EventArgs e)
        {
            frmTelaLogin objfrmTelaPrincipal = new frmTelaLogin();
            objfrmTelaPrincipal.Show(); ;
            Close();
        }

        private void ToolStripSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


