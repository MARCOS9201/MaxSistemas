namespace Max_Sistemas
{
    partial class FrmCadastroPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCadPerfil = new System.Windows.Forms.PictureBox();
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkCadastrarAluno = new System.Windows.Forms.CheckBox();
            this.chkCadastrarProfessor = new System.Windows.Forms.CheckBox();
            this.chkCadastrarNota = new System.Windows.Forms.CheckBox();
            this.chkCadastrarFrequencia = new System.Windows.Forms.CheckBox();
            this.chkGeraBoletim = new System.Windows.Forms.CheckBox();
            this.grupDefinicaoPermissao = new System.Windows.Forms.GroupBox();
            this.btnSalvarPerfil = new System.Windows.Forms.Button();
            this.btnCancelarPerfil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadPerfil)).BeginInit();
            this.grupDefinicaoPermissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 30);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1086, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCadastroToolStripMenuItem,
            this.menuPrincipalToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            // 
            // novoCadastroToolStripMenuItem
            // 
            this.novoCadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoCadastroToolStripMenuItem.Image")));
            this.novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            this.novoCadastroToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.novoCadastroToolStripMenuItem.Text = "Cadastro Novo Perfil";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuPrincipalToolStripMenuItem.Image")));
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // picCadPerfil
            // 
            this.picCadPerfil.BackColor = System.Drawing.Color.Transparent;
            this.picCadPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCadPerfil.BackgroundImage")));
            this.picCadPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCadPerfil.Location = new System.Drawing.Point(895, 229);
            this.picCadPerfil.Name = "picCadPerfil";
            this.picCadPerfil.Size = new System.Drawing.Size(468, 261);
            this.picCadPerfil.TabIndex = 2;
            this.picCadPerfil.TabStop = false;
            // 
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.AutoSize = true;
            this.lblNovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoUsuario.Location = new System.Drawing.Point(119, 92);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblNovoUsuario.TabIndex = 3;
            this.lblNovoUsuario.Text = "Usuário:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(189, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 24);
            this.textBox1.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(129, 132);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(189, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 24);
            this.textBox2.TabIndex = 6;
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPerfil.Location = new System.Drawing.Point(85, 177);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(98, 18);
            this.lblTipoPerfil.TabIndex = 7;
            this.lblTipoPerfil.Text = "Tipo de Perfil:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador ",
            "Padrão"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(189, 177);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(197, 26);
            this.cmbTipoUsuario.TabIndex = 8;
            // 
            // chkCadastrarAluno
            // 
            this.chkCadastrarAluno.AutoSize = true;
            this.chkCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCadastrarAluno.Location = new System.Drawing.Point(28, 28);
            this.chkCadastrarAluno.Name = "chkCadastrarAluno";
            this.chkCadastrarAluno.Size = new System.Drawing.Size(143, 24);
            this.chkCadastrarAluno.TabIndex = 0;
            this.chkCadastrarAluno.Text = "Cadastrar Aluno";
            this.chkCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarProfessor
            // 
            this.chkCadastrarProfessor.AutoSize = true;
            this.chkCadastrarProfessor.Location = new System.Drawing.Point(27, 118);
            this.chkCadastrarProfessor.Name = "chkCadastrarProfessor";
            this.chkCadastrarProfessor.Size = new System.Drawing.Size(170, 24);
            this.chkCadastrarProfessor.TabIndex = 1;
            this.chkCadastrarProfessor.Text = "Cadastrar Professor";
            this.chkCadastrarProfessor.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarNota
            // 
            this.chkCadastrarNota.AutoSize = true;
            this.chkCadastrarNota.Location = new System.Drawing.Point(28, 88);
            this.chkCadastrarNota.Name = "chkCadastrarNota";
            this.chkCadastrarNota.Size = new System.Drawing.Size(136, 24);
            this.chkCadastrarNota.TabIndex = 2;
            this.chkCadastrarNota.Text = "Cadastrar Nota";
            this.chkCadastrarNota.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarFrequencia
            // 
            this.chkCadastrarFrequencia.AutoSize = true;
            this.chkCadastrarFrequencia.Location = new System.Drawing.Point(28, 58);
            this.chkCadastrarFrequencia.Name = "chkCadastrarFrequencia";
            this.chkCadastrarFrequencia.Size = new System.Drawing.Size(182, 24);
            this.chkCadastrarFrequencia.TabIndex = 3;
            this.chkCadastrarFrequencia.Text = "Cadastrar Frequência";
            this.chkCadastrarFrequencia.UseVisualStyleBackColor = true;
            // 
            // chkGeraBoletim
            // 
            this.chkGeraBoletim.AutoSize = true;
            this.chkGeraBoletim.Location = new System.Drawing.Point(27, 148);
            this.chkGeraBoletim.Name = "chkGeraBoletim";
            this.chkGeraBoletim.Size = new System.Drawing.Size(183, 24);
            this.chkGeraBoletim.TabIndex = 8;
            this.chkGeraBoletim.Text = "Gerar Boletim Escolar";
            this.chkGeraBoletim.UseVisualStyleBackColor = true;
            // 
            // grupDefinicaoPermissao
            // 
            this.grupDefinicaoPermissao.BackColor = System.Drawing.Color.Transparent;
            this.grupDefinicaoPermissao.Controls.Add(this.chkGeraBoletim);
            this.grupDefinicaoPermissao.Controls.Add(this.chkCadastrarFrequencia);
            this.grupDefinicaoPermissao.Controls.Add(this.chkCadastrarNota);
            this.grupDefinicaoPermissao.Controls.Add(this.chkCadastrarProfessor);
            this.grupDefinicaoPermissao.Controls.Add(this.chkCadastrarAluno);
            this.grupDefinicaoPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupDefinicaoPermissao.Location = new System.Drawing.Point(189, 229);
            this.grupDefinicaoPermissao.Name = "grupDefinicaoPermissao";
            this.grupDefinicaoPermissao.Size = new System.Drawing.Size(352, 247);
            this.grupDefinicaoPermissao.TabIndex = 9;
            this.grupDefinicaoPermissao.TabStop = false;
            this.grupDefinicaoPermissao.Text = "Definições de permissão";
            this.grupDefinicaoPermissao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalvarPerfil
            // 
            this.btnSalvarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarPerfil.Image")));
            this.btnSalvarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPerfil.Location = new System.Drawing.Point(421, 92);
            this.btnSalvarPerfil.Name = "btnSalvarPerfil";
            this.btnSalvarPerfil.Size = new System.Drawing.Size(120, 58);
            this.btnSalvarPerfil.TabIndex = 10;
            this.btnSalvarPerfil.Text = "      Salvar";
            this.btnSalvarPerfil.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPerfil
            // 
            this.btnCancelarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarPerfil.Image")));
            this.btnCancelarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPerfil.Location = new System.Drawing.Point(421, 159);
            this.btnCancelarPerfil.Name = "btnCancelarPerfil";
            this.btnCancelarPerfil.Size = new System.Drawing.Size(120, 54);
            this.btnCancelarPerfil.TabIndex = 147;
            this.btnCancelarPerfil.Text = "           Cancelar";
            this.btnCancelarPerfil.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 535);
            this.Controls.Add(this.btnCancelarPerfil);
            this.Controls.Add(this.btnSalvarPerfil);
            this.Controls.Add(this.grupDefinicaoPermissao);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoPerfil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNovoUsuario);
            this.Controls.Add(this.picCadPerfil);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Sistemas SR - School Cadastro Perfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCadPerfil)).EndInit();
            this.grupDefinicaoPermissao.ResumeLayout(false);
            this.grupDefinicaoPermissao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picCadPerfil;
        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.CheckBox chkCadastrarAluno;
        private System.Windows.Forms.CheckBox chkCadastrarProfessor;
        private System.Windows.Forms.CheckBox chkCadastrarNota;
        private System.Windows.Forms.CheckBox chkCadastrarFrequencia;
        private System.Windows.Forms.CheckBox chkGeraBoletim;
        private System.Windows.Forms.GroupBox grupDefinicaoPermissao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnSalvarPerfil;
        private System.Windows.Forms.Button btnCancelarPerfil;
    }
}