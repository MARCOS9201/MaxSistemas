using Max_Sistemas.servicos.persistencia;
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
    public partial class frmTelaLogin : Form
    {
        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // fecha o processo da tela de login
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Hide(); //esconde a tela de menu principal
            frmTelaPrincipal newForm2 = new frmTelaPrincipal(); //Chama tela de menu principal
            newForm2.ShowDialog();
            
        }
    }
}
