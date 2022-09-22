namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonSubtrair = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero1.Location = new System.Drawing.Point(49, 27);
            this.labelNumero1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(83, 23);
            this.labelNumero1.TabIndex = 0;
            this.labelNumero1.Text = "1° Numero";
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero2.Location = new System.Drawing.Point(49, 85);
            this.labelNumero2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(83, 23);
            this.labelNumero2.TabIndex = 1;
            this.labelNumero2.Text = "2° Numero";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(103, 138);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(108, 33);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "Resultado";
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelValorFinal.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorFinal.Location = new System.Drawing.Point(147, 171);
            this.labelValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(23, 26);
            this.labelValorFinal.TabIndex = 3;
            this.labelValorFinal.Text = "0";
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNumero1.Location = new System.Drawing.Point(17, 54);
            this.textBoxNumero1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(140, 27);
            this.textBoxNumero1.TabIndex = 4;
            this.textBoxNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero1_KeyPress);
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(17, 108);
            this.textBoxNumero2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(140, 27);
            this.textBoxNumero2.TabIndex = 5;
            this.textBoxNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSomar
            // 
            this.buttonSomar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSomar.Location = new System.Drawing.Point(165, 49);
            this.buttonSomar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(77, 34);
            this.buttonSomar.TabIndex = 6;
            this.buttonSomar.Text = "+";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplicar.Location = new System.Drawing.Point(165, 101);
            this.buttonMultiplicar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(77, 34);
            this.buttonMultiplicar.TabIndex = 7;
            this.buttonMultiplicar.Text = "*";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.buttonMultiplicar_Click);
            // 
            // buttonSubtrair
            // 
            this.buttonSubtrair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtrair.Location = new System.Drawing.Point(250, 49);
            this.buttonSubtrair.Name = "buttonSubtrair";
            this.buttonSubtrair.Size = new System.Drawing.Size(77, 34);
            this.buttonSubtrair.TabIndex = 8;
            this.buttonSubtrair.Text = "-";
            this.buttonSubtrair.UseVisualStyleBackColor = true;
            this.buttonSubtrair.Click += new System.EventHandler(this.buttonSubtrair_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDividir.Location = new System.Drawing.Point(250, 101);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(77, 34);
            this.buttonDividir.TabIndex = 9;
            this.buttonDividir.Text = "/";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(340, 206);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonSubtrair);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonSomar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelValorFinal);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttonSubtrair;
        private System.Windows.Forms.Button buttonDividir;
    }
}

