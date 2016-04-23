namespace Max_Sistemas
{
    partial class frmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.lblTextoLogin = new System.Windows.Forms.Label();
            this.picTelaLogin = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(177, 337);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(103, 33);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(353, 337);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(103, 33);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(244, 196);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 24);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(164, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(174, 266);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejaBemVindo.Location = new System.Drawing.Point(160, 47);
            this.lblSejaBemVindo.Name = "lblSejaBemVindo";
            this.lblSejaBemVindo.Size = new System.Drawing.Size(256, 37);
            this.lblSejaBemVindo.TabIndex = 6;
            this.lblSejaBemVindo.Text = "Seja Bem-Vindo ";
            // 
            // lblTextoLogin
            // 
            this.lblTextoLogin.AutoSize = true;
            this.lblTextoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoLogin.Location = new System.Drawing.Point(164, 108);
            this.lblTextoLogin.Name = "lblTextoLogin";
            this.lblTextoLogin.Size = new System.Drawing.Size(350, 18);
            this.lblTextoLogin.TabIndex = 7;
            this.lblTextoLogin.Text = "Identifique-se por favor para utilizar o nosso produto";
            // 
            // picTelaLogin
            // 
            this.picTelaLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTelaLogin.BackgroundImage")));
            this.picTelaLogin.Location = new System.Drawing.Point(540, 47);
            this.picTelaLogin.Name = "picTelaLogin";
            this.picTelaLogin.Size = new System.Drawing.Size(239, 58);
            this.picTelaLogin.TabIndex = 8;
            this.picTelaLogin.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(244, 268);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(183, 24);
            this.txtSenha.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(613, 108);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(166, 33);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "Versão Alfa 2.0";
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 484);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.picTelaLogin);
            this.Controls.Add(this.lblTextoLogin);
            this.Controls.Add(this.lblSejaBemVindo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picTelaLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSejaBemVindo;
        private System.Windows.Forms.Label lblTextoLogin;
        private System.Windows.Forms.PictureBox picTelaLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblVersion;
    }
}

