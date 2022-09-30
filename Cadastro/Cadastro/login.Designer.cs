namespace Cadastro
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLoginNome = new System.Windows.Forms.TextBox();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.buttonFazerLogin = new System.Windows.Forms.Button();
            this.pictureBoxVerLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxOcultarLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "EFETUE O LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "SENHA";
            // 
            // textBoxLoginNome
            // 
            this.textBoxLoginNome.Location = new System.Drawing.Point(135, 102);
            this.textBoxLoginNome.Name = "textBoxLoginNome";
            this.textBoxLoginNome.Size = new System.Drawing.Size(160, 20);
            this.textBoxLoginNome.TabIndex = 3;
            // 
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.Location = new System.Drawing.Point(135, 138);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.Size = new System.Drawing.Size(160, 20);
            this.textBoxLoginSenha.TabIndex = 4;
            this.textBoxLoginSenha.TextChanged += new System.EventHandler(this.textBoxLoginSenha_TextChanged);
            // 
            // buttonFazerLogin
            // 
            this.buttonFazerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFazerLogin.Location = new System.Drawing.Point(79, 177);
            this.buttonFazerLogin.Name = "buttonFazerLogin";
            this.buttonFazerLogin.Size = new System.Drawing.Size(216, 38);
            this.buttonFazerLogin.TabIndex = 5;
            this.buttonFazerLogin.Text = "LOGIN";
            this.buttonFazerLogin.UseVisualStyleBackColor = true;
            this.buttonFazerLogin.Click += new System.EventHandler(this.buttonFazerLogin_Click);
            // 
            // pictureBoxVerLogin
            // 
            this.pictureBoxVerLogin.Image = global::Cadastro.Properties.Resources.olho;
            this.pictureBoxVerLogin.Location = new System.Drawing.Point(301, 139);
            this.pictureBoxVerLogin.Name = "pictureBoxVerLogin";
            this.pictureBoxVerLogin.Size = new System.Drawing.Size(31, 21);
            this.pictureBoxVerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVerLogin.TabIndex = 6;
            this.pictureBoxVerLogin.TabStop = false;
            this.pictureBoxVerLogin.Click += new System.EventHandler(this.pictureBoxVerLogin_Click);
            // 
            // pictureBoxOcultarLogin
            // 
            this.pictureBoxOcultarLogin.Image = global::Cadastro.Properties.Resources.ver;
            this.pictureBoxOcultarLogin.Location = new System.Drawing.Point(301, 137);
            this.pictureBoxOcultarLogin.Name = "pictureBoxOcultarLogin";
            this.pictureBoxOcultarLogin.Size = new System.Drawing.Size(31, 21);
            this.pictureBoxOcultarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOcultarLogin.TabIndex = 7;
            this.pictureBoxOcultarLogin.TabStop = false;
            this.pictureBoxOcultarLogin.Click += new System.EventHandler(this.pictureBoxOcultarLogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 291);
            this.Controls.Add(this.pictureBoxOcultarLogin);
            this.Controls.Add(this.pictureBoxVerLogin);
            this.Controls.Add(this.buttonFazerLogin);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.textBoxLoginNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultarLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLoginNome;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
        private System.Windows.Forms.Button buttonFazerLogin;
        private System.Windows.Forms.PictureBox pictureBoxVerLogin;
        private System.Windows.Forms.PictureBox pictureBoxOcultarLogin;
    }
}