using Max_Sistemas.controller;
using Max_Sistemas.regras_de_negocio;
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
            buscaProfessor();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            bool retorno = false;
            materia.Nome = txbNomeMateria.Text;
            if (cmbProfessor.Text=="")
            {
                MessageBox.Show("Preencha o professor!");
            }
            else
            {
                string id = cmbProfessor.SelectedItem.ToString();
                materia.Professor.IdProfessor = Convert.ToInt32(id.Substring(0, 1));
                if (txbCargaHoraria.Text == "")
                {
                    txbCargaHoraria.Text = "0";
                    materia.CargaHoraria = Convert.ToDouble(txbCargaHoraria.Text);
                }

                materia.DataCadastro = Convert.ToDateTime(txbData.Text);

                TratadorMateria tratador = new TratadorMateria();
                retorno = tratador.salvarMateria(materia);
            }
            if (retorno==true)
            {
                
            }
        }

        private void buscaProfessor()
        {
            TratadorProfessor tratador = new TratadorProfessor();
            foreach (Professor item in tratador.buscaProfessor())
            {
                cmbProfessor.Items.Add(item.IdProfessor+" - "+item.Nome);
            }
        }
    }
}
