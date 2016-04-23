namespace Max_Sistemas
{
    partial class frmPesquisaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaMateria));
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
            this.BtnPesquisaMateria = new System.Windows.Forms.Button();
            this.txtPesquisaMateria = new System.Windows.Forms.TextBox();
            this.dataGridViewMateria = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaMinistrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picPesMateria = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 32);
            this.panel1.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1136, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 24);
            this.menuStrip1.TabIndex = 7;
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
            // BtnPesquisaMateria
            // 
            this.BtnPesquisaMateria.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisaMateria.Image")));
            this.BtnPesquisaMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisaMateria.Location = new System.Drawing.Point(136, 37);
            this.BtnPesquisaMateria.Name = "BtnPesquisaMateria";
            this.BtnPesquisaMateria.Size = new System.Drawing.Size(106, 27);
            this.BtnPesquisaMateria.TabIndex = 75;
            this.BtnPesquisaMateria.Text = "       Pesquisa";
            this.BtnPesquisaMateria.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaMateria
            // 
            this.txtPesquisaMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMateria.Location = new System.Drawing.Point(5, 39);
            this.txtPesquisaMateria.Name = "txtPesquisaMateria";
            this.txtPesquisaMateria.Size = new System.Drawing.Size(125, 24);
            this.txtPesquisaMateria.TabIndex = 74;
            // 
            // dataGridViewMateria
            // 
            this.dataGridViewMateria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nome,
            this.Turno,
            this.Sala,
            this.Endereço,
            this.TipoEspecialidade,
            this.MateriaMinistrada});
            this.dataGridViewMateria.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewMateria.Location = new System.Drawing.Point(2, 65);
            this.dataGridViewMateria.Name = "dataGridViewMateria";
            this.dataGridViewMateria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMateria.Size = new System.Drawing.Size(1356, 346);
            this.dataGridViewMateria.TabIndex = 73;
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
            // picPesMateria
            // 
            this.picPesMateria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPesMateria.BackgroundImage")));
            this.picPesMateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPesMateria.Location = new System.Drawing.Point(568, 417);
            this.picPesMateria.Name = "picPesMateria";
            this.picPesMateria.Size = new System.Drawing.Size(241, 61);
            this.picPesMateria.TabIndex = 72;
            this.picPesMateria.TabStop = false;
            // 
            // frmPesquisaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnPesquisaMateria);
            this.Controls.Add(this.txtPesquisaMateria);
            this.Controls.Add(this.dataGridViewMateria);
            this.Controls.Add(this.picPesMateria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Sistemas SR School - Pesquisa Matéria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPesMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPesquisaMateria;
        private System.Windows.Forms.TextBox txtPesquisaMateria;
        private System.Windows.Forms.DataGridView dataGridViewMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEspecialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaMinistrada;
        private System.Windows.Forms.PictureBox picPesMateria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaDeTelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasAdesivasToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}