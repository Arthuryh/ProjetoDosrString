namespace ProjetoFinal
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Termos = new System.Windows.Forms.TabPage();
            this.Login = new System.Windows.Forms.TabPage();
            this.painelConteudo1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.painelConteudo2 = new System.Windows.Forms.Panel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblRecuperaSenha = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.painelBotoes = new System.Windows.Forms.Panel();
            this.btnRejeitar = new System.Windows.Forms.Button();
            this.BtnAceitar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.painelConteudo1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painelConteudo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.painelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Termos);
            this.tabControl.Controls.Add(this.Login);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(564, 19);
            this.tabControl.TabIndex = 7;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Termos
            // 
            this.Termos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Termos.Location = new System.Drawing.Point(4, 22);
            this.Termos.Name = "Termos";
            this.Termos.Padding = new System.Windows.Forms.Padding(3);
            this.Termos.Size = new System.Drawing.Size(556, 0);
            this.Termos.TabIndex = 0;
            this.Termos.Text = "Termos";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(556, 0);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // painelConteudo1
            // 
            this.painelConteudo1.Controls.Add(this.panel2);
            this.painelConteudo1.Controls.Add(this.richTextBox1);
            this.painelConteudo1.Location = new System.Drawing.Point(1, 25);
            this.painelConteudo1.Name = "painelConteudo1";
            this.painelConteudo1.Size = new System.Drawing.Size(560, 279);
            this.painelConteudo1.TabIndex = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 54);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoFinal.Properties.Resources.laser_beam;
            this.pictureBox2.Location = new System.Drawing.Point(7, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TERMOS DE USO DO SISTEMA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(536, 206);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // painelConteudo2
            // 
            this.painelConteudo2.Controls.Add(this.pcbLogo);
            this.painelConteudo2.Controls.Add(this.lblRecuperaSenha);
            this.painelConteudo2.Controls.Add(this.btnEntrar);
            this.painelConteudo2.Controls.Add(this.txtSenha);
            this.painelConteudo2.Controls.Add(this.txtUsu);
            this.painelConteudo2.Controls.Add(this.lblSenha);
            this.painelConteudo2.Controls.Add(this.lblUsu);
            this.painelConteudo2.Enabled = false;
            this.painelConteudo2.Location = new System.Drawing.Point(0, 25);
            this.painelConteudo2.Name = "painelConteudo2";
            this.painelConteudo2.Size = new System.Drawing.Size(555, 279);
            this.painelConteudo2.TabIndex = 2;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::ProjetoFinal.Properties.Resources.laser_beam;
            this.pcbLogo.Location = new System.Drawing.Point(169, 13);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(220, 125);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 20;
            this.pcbLogo.TabStop = false;
            // 
            // lblRecuperaSenha
            // 
            this.lblRecuperaSenha.AutoSize = true;
            this.lblRecuperaSenha.Location = new System.Drawing.Point(165, 241);
            this.lblRecuperaSenha.Name = "lblRecuperaSenha";
            this.lblRecuperaSenha.Size = new System.Drawing.Size(91, 13);
            this.lblRecuperaSenha.TabIndex = 19;
            this.lblRecuperaSenha.TabStop = true;
            this.lblRecuperaSenha.Text = "Recuperar Senha";
            this.lblRecuperaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperaSenha_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(314, 228);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 38);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(225, 195);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(163, 20);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(225, 153);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(163, 20);
            this.txtUsu.TabIndex = 16;
            this.txtUsu.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(165, 198);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 15;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(165, 156);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(43, 13);
            this.lblUsu.TabIndex = 14;
            this.lblUsu.Text = "Usuário";
            // 
            // painelBotoes
            // 
            this.painelBotoes.Controls.Add(this.btnRejeitar);
            this.painelBotoes.Controls.Add(this.BtnAceitar);
            this.painelBotoes.Location = new System.Drawing.Point(3, 304);
            this.painelBotoes.Name = "painelBotoes";
            this.painelBotoes.Size = new System.Drawing.Size(555, 56);
            this.painelBotoes.TabIndex = 11;
            // 
            // btnRejeitar
            // 
            this.btnRejeitar.Location = new System.Drawing.Point(375, 6);
            this.btnRejeitar.Name = "btnRejeitar";
            this.btnRejeitar.Size = new System.Drawing.Size(75, 39);
            this.btnRejeitar.TabIndex = 1;
            this.btnRejeitar.Text = "Negar";
            this.btnRejeitar.UseVisualStyleBackColor = true;
            this.btnRejeitar.Click += new System.EventHandler(this.btnRejeitar_Click);
            // 
            // BtnAceitar
            // 
            this.BtnAceitar.Location = new System.Drawing.Point(470, 6);
            this.BtnAceitar.Name = "BtnAceitar";
            this.BtnAceitar.Size = new System.Drawing.Size(75, 39);
            this.BtnAceitar.TabIndex = 0;
            this.BtnAceitar.Text = "Aceitar";
            this.BtnAceitar.UseVisualStyleBackColor = true;
            this.BtnAceitar.Click += new System.EventHandler(this.BtnAceitar_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.BtnAceitar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 361);
            this.Controls.Add(this.painelConteudo2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.painelBotoes);
            this.Controls.Add(this.painelConteudo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabControl.ResumeLayout(false);
            this.painelConteudo1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painelConteudo2.ResumeLayout(false);
            this.painelConteudo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.painelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Termos;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.Panel painelConteudo1;
        private System.Windows.Forms.Panel painelConteudo2;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.LinkLabel lblRecuperaSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel painelBotoes;
        private System.Windows.Forms.Button btnRejeitar;
        private System.Windows.Forms.Button BtnAceitar;

    }
}