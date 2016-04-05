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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLSenha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkCadastrarAluno = new System.Windows.Forms.CheckBox();
            this.chkCadastrarProfessor = new System.Windows.Forms.CheckBox();
            this.chkCadastrarNota = new System.Windows.Forms.CheckBox();
            this.chkCadastrarFrequencia = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvarPerfil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dateTimePicker1.Location = new System.Drawing.Point(1064, 1);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(895, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 261);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.textBox1.Location = new System.Drawing.Point(189, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbLSenha
            // 
            this.lbLSenha.AutoSize = true;
            this.lbLSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbLSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLSenha.Location = new System.Drawing.Point(129, 132);
            this.lbLSenha.Name = "lbLSenha";
            this.lbLSenha.Size = new System.Drawing.Size(54, 18);
            this.lbLSenha.TabIndex = 5;
            this.lbLSenha.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(85, 177);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(98, 18);
            this.lblTipoUsuario.TabIndex = 7;
            this.lblTipoUsuario.Text = "Tipo de Perfil:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador ",
            "Padrão"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(189, 177);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(197, 21);
            this.cmbTipoUsuario.TabIndex = 8;
            // 
            // chkCadastrarAluno
            // 
            this.chkCadastrarAluno.AutoSize = true;
            this.chkCadastrarAluno.Location = new System.Drawing.Point(28, 37);
            this.chkCadastrarAluno.Name = "chkCadastrarAluno";
            this.chkCadastrarAluno.Size = new System.Drawing.Size(101, 17);
            this.chkCadastrarAluno.TabIndex = 0;
            this.chkCadastrarAluno.Text = "Cadastrar Aluno";
            this.chkCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarProfessor
            // 
            this.chkCadastrarProfessor.AutoSize = true;
            this.chkCadastrarProfessor.Location = new System.Drawing.Point(28, 135);
            this.chkCadastrarProfessor.Name = "chkCadastrarProfessor";
            this.chkCadastrarProfessor.Size = new System.Drawing.Size(118, 17);
            this.chkCadastrarProfessor.TabIndex = 1;
            this.chkCadastrarProfessor.Text = "Cadastrar Professor";
            this.chkCadastrarProfessor.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarNota
            // 
            this.chkCadastrarNota.AutoSize = true;
            this.chkCadastrarNota.Location = new System.Drawing.Point(28, 102);
            this.chkCadastrarNota.Name = "chkCadastrarNota";
            this.chkCadastrarNota.Size = new System.Drawing.Size(97, 17);
            this.chkCadastrarNota.TabIndex = 2;
            this.chkCadastrarNota.Text = "Cadastrar Nota";
            this.chkCadastrarNota.UseVisualStyleBackColor = true;
            // 
            // chkCadastrarFrequencia
            // 
            this.chkCadastrarFrequencia.AutoSize = true;
            this.chkCadastrarFrequencia.Location = new System.Drawing.Point(28, 69);
            this.chkCadastrarFrequencia.Name = "chkCadastrarFrequencia";
            this.chkCadastrarFrequencia.Size = new System.Drawing.Size(127, 17);
            this.chkCadastrarFrequencia.TabIndex = 3;
            this.chkCadastrarFrequencia.Text = "Cadastrar Frequência";
            this.chkCadastrarFrequencia.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Cadastrar Aluno";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(326, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(127, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Cadastrar Frequência";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(326, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Cadastrar Nota";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(326, 135);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(118, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Cadastrar Professor";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(326, 170);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(127, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Gerar Boletim Escolar";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.chkCadastrarFrequencia);
            this.groupBox1.Controls.Add(this.chkCadastrarNota);
            this.groupBox1.Controls.Add(this.chkCadastrarProfessor);
            this.groupBox1.Controls.Add(this.chkCadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(189, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definições de permissão";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalvarPerfil
            // 
            this.btnSalvarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarPerfil.Image")));
            this.btnSalvarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarPerfil.Location = new System.Drawing.Point(421, 92);
            this.btnSalvarPerfil.Name = "btnSalvarPerfil";
            this.btnSalvarPerfil.Size = new System.Drawing.Size(120, 61);
            this.btnSalvarPerfil.TabIndex = 10;
            this.btnSalvarPerfil.Text = "      Salvar";
            this.btnSalvarPerfil.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 759);
            this.Controls.Add(this.btnSalvarPerfil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbLSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNovoUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Sistemas SR - School Cadastro Perfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.CheckBox chkCadastrarAluno;
        private System.Windows.Forms.CheckBox chkCadastrarProfessor;
        private System.Windows.Forms.CheckBox chkCadastrarNota;
        private System.Windows.Forms.CheckBox chkCadastrarFrequencia;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnSalvarPerfil;
    }
}