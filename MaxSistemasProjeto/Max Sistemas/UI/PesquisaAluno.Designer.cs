namespace Max_Sistemas
{
    partial class frmPesquisaAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaAluno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaDeTelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasAdesivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picPesAluno = new System.Windows.Forms.PictureBox();
            this.txtPesquisaAluno = new System.Windows.Forms.TextBox();
            this.BtnPesquisaAluno = new System.Windows.Forms.Button();
            this.dataGridViewAluno = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaMinistrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 32);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1085, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Principal";
            // 
            // menuPrincipalToolStripMenuItem1
            // 
            this.menuPrincipalToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("menuPrincipalToolStripMenuItem1.Image")));
            this.menuPrincipalToolStripMenuItem1.Name = "menuPrincipalToolStripMenuItem1";
            this.menuPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.menuPrincipalToolStripMenuItem1.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.capturaDeTelaToolStripMenuItem,
            this.notasAdesivasToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // capturaDeTelaToolStripMenuItem
            // 
            this.capturaDeTelaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("capturaDeTelaToolStripMenuItem.Image")));
            this.capturaDeTelaToolStripMenuItem.Name = "capturaDeTelaToolStripMenuItem";
            this.capturaDeTelaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.capturaDeTelaToolStripMenuItem.Text = "Captura de Tela";
            // 
            // notasAdesivasToolStripMenuItem
            // 
            this.notasAdesivasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notasAdesivasToolStripMenuItem.Image")));
            this.notasAdesivasToolStripMenuItem.Name = "notasAdesivasToolStripMenuItem";
            this.notasAdesivasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notasAdesivasToolStripMenuItem.Text = "Notas Adesivas";
            // 
            // picPesAluno
            // 
            this.picPesAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPesAluno.BackgroundImage")));
            this.picPesAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPesAluno.Location = new System.Drawing.Point(553, 432);
            this.picPesAluno.Name = "picPesAluno";
            this.picPesAluno.Size = new System.Drawing.Size(241, 61);
            this.picPesAluno.TabIndex = 62;
            this.picPesAluno.TabStop = false;
            // 
            // txtPesquisaAluno
            // 
            this.txtPesquisaAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaAluno.Location = new System.Drawing.Point(10, 37);
            this.txtPesquisaAluno.Name = "txtPesquisaAluno";
            this.txtPesquisaAluno.Size = new System.Drawing.Size(125, 24);
            this.txtPesquisaAluno.TabIndex = 64;
            // 
            // BtnPesquisaAluno
            // 
            this.BtnPesquisaAluno.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisaAluno.Image")));
            this.BtnPesquisaAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisaAluno.Location = new System.Drawing.Point(146, 34);
            this.BtnPesquisaAluno.Name = "BtnPesquisaAluno";
            this.BtnPesquisaAluno.Size = new System.Drawing.Size(106, 27);
            this.BtnPesquisaAluno.TabIndex = 65;
            this.BtnPesquisaAluno.Text = "       Pesquisa";
            this.BtnPesquisaAluno.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAluno
            // 
            this.dataGridViewAluno.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.Turno,
            this.Sala,
            this.Endereço,
            this.TipoEspecialidade,
            this.MateriaMinistrada});
            this.dataGridViewAluno.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewAluno.Location = new System.Drawing.Point(-1, 63);
            this.dataGridViewAluno.Name = "dataGridViewAluno";
            this.dataGridViewAluno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAluno.Size = new System.Drawing.Size(1352, 362);
            this.dataGridViewAluno.TabIndex = 69;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.Width = 200;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            // 
            // Endereço
            // 
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.Width = 300;
            // 
            // TipoEspecialidade
            // 
            this.TipoEspecialidade.HeaderText = "Especialidade";
            this.TipoEspecialidade.Name = "TipoEspecialidade";
            this.TipoEspecialidade.Width = 200;
            // 
            // MateriaMinistrada
            // 
            this.MateriaMinistrada.HeaderText = "Matéria ministrada";
            this.MateriaMinistrada.Name = "MateriaMinistrada";
            this.MateriaMinistrada.Width = 200;
            // 
            // frmPesquisaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1343, 683);
            this.Controls.Add(this.dataGridViewAluno);
            this.Controls.Add(this.BtnPesquisaAluno);
            this.Controls.Add(this.txtPesquisaAluno);
            this.Controls.Add(this.picPesAluno);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Sistemas SR School - Pesquisa Alunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPesAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaDeTelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasAdesivasToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picPesAluno;
        private System.Windows.Forms.TextBox txtPesquisaAluno;
        private System.Windows.Forms.Button BtnPesquisaAluno;
        private System.Windows.Forms.DataGridView dataGridViewAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaMinistrada;
    }
}