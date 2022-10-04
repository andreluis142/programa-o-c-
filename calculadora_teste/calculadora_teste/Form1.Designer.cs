namespace calculadora_teste
{
    partial class calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonSubtrair = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPorcentagem = new System.Windows.Forms.Button();
            this.buttonPotenciacao = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDicas = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNum1.Location = new System.Drawing.Point(113, 39);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(185, 19);
            this.textBoxNum1.TabIndex = 0;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primeiro numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Numero";
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNum2.Location = new System.Drawing.Point(113, 86);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(185, 19);
            this.textBoxNum2.TabIndex = 2;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSomar
            // 
            this.buttonSomar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSomar.Location = new System.Drawing.Point(67, 178);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(60, 42);
            this.buttonSomar.TabIndex = 4;
            this.buttonSomar.Text = "+";
            this.buttonSomar.UseVisualStyleBackColor = false;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // buttonSubtrair
            // 
            this.buttonSubtrair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubtrair.Location = new System.Drawing.Point(133, 178);
            this.buttonSubtrair.Name = "buttonSubtrair";
            this.buttonSubtrair.Size = new System.Drawing.Size(60, 42);
            this.buttonSubtrair.TabIndex = 5;
            this.buttonSubtrair.Text = "-";
            this.buttonSubtrair.UseVisualStyleBackColor = false;
            this.buttonSubtrair.Click += new System.EventHandler(this.buttonSubtrair_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMultiplicar.Location = new System.Drawing.Point(67, 226);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(60, 42);
            this.buttonMultiplicar.TabIndex = 6;
            this.buttonMultiplicar.Text = "*";
            this.buttonMultiplicar.UseVisualStyleBackColor = false;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDividir.Location = new System.Drawing.Point(133, 226);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(60, 42);
            this.buttonDividir.TabIndex = 6;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = false;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(94, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResultado.Location = new System.Drawing.Point(113, 133);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(185, 19);
            this.textBoxResultado.TabIndex = 10;
            this.textBoxResultado.Text = "0";
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(163, 322);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 42);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPorcentagem
            // 
            this.buttonPorcentagem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPorcentagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPorcentagem.Location = new System.Drawing.Point(199, 226);
            this.buttonPorcentagem.Name = "buttonPorcentagem";
            this.buttonPorcentagem.Size = new System.Drawing.Size(60, 42);
            this.buttonPorcentagem.TabIndex = 12;
            this.buttonPorcentagem.Text = "%";
            this.buttonPorcentagem.UseVisualStyleBackColor = false;
            this.buttonPorcentagem.Click += new System.EventHandler(this.buttonPorcentagem_Click);
            // 
            // buttonPotenciacao
            // 
            this.buttonPotenciacao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPotenciacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPotenciacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPotenciacao.Location = new System.Drawing.Point(200, 178);
            this.buttonPotenciacao.Name = "buttonPotenciacao";
            this.buttonPotenciacao.Size = new System.Drawing.Size(60, 42);
            this.buttonPotenciacao.TabIndex = 13;
            this.buttonPotenciacao.Text = "x²";
            this.buttonPotenciacao.UseVisualStyleBackColor = false;
            this.buttonPotenciacao.Click += new System.EventHandler(this.buttonPotenciacao_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(67, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "²√x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDicas
            // 
            this.buttonDicas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDicas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDicas.Location = new System.Drawing.Point(265, 275);
            this.buttonDicas.Name = "buttonDicas";
            this.buttonDicas.Size = new System.Drawing.Size(60, 42);
            this.buttonDicas.TabIndex = 15;
            this.buttonDicas.Text = "?";
            this.buttonDicas.UseVisualStyleBackColor = false;
            this.buttonDicas.Click += new System.EventHandler(this.buttonDicas_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLog.Location = new System.Drawing.Point(133, 274);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(60, 42);
            this.buttonLog.TabIndex = 16;
            this.buttonLog.Text = "LOG";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCos.Location = new System.Drawing.Point(199, 275);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(60, 42);
            this.buttonCos.TabIndex = 17;
            this.buttonCos.Text = "COS";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.buttonCos_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTan.Location = new System.Drawing.Point(265, 226);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(60, 42);
            this.buttonTan.TabIndex = 18;
            this.buttonTan.Text = "TAN";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.buttonTan_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPi.Location = new System.Drawing.Point(265, 178);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(60, 42);
            this.buttonPi.TabIndex = 19;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 458);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonDicas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPotenciacao);
            this.Controls.Add(this.buttonPorcentagem);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonSubtrair);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "calculadora";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonSubtrair;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPorcentagem;
        private System.Windows.Forms.Button buttonPotenciacao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDicas;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonPi;
    }
}

