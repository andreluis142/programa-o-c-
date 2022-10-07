namespace frota_taxi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLitros = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecoAlcool = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrecoGasolina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGasolina = new System.Windows.Forms.TextBox();
            this.textBoxAlcool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KMs a percorrer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade (L)";
            // 
            // textBoxLitros
            // 
            this.textBoxLitros.Location = new System.Drawing.Point(239, 266);
            this.textBoxLitros.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLitros.Name = "textBoxLitros";
            this.textBoxLitros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLitros.Size = new System.Drawing.Size(144, 24);
            this.textBoxLitros.TabIndex = 2;
            this.textBoxLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(239, 220);
            this.textBoxKm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxKm.Size = new System.Drawing.Size(144, 24);
            this.textBoxKm.TabIndex = 3;
            this.textBoxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(261, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(89, 331);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(436, 132);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço Gasolina";
            // 
            // textBoxPrecoAlcool
            // 
            this.textBoxPrecoAlcool.Location = new System.Drawing.Point(379, 171);
            this.textBoxPrecoAlcool.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoAlcool.Name = "textBoxPrecoAlcool";
            this.textBoxPrecoAlcool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPrecoAlcool.Size = new System.Drawing.Size(132, 24);
            this.textBoxPrecoAlcool.TabIndex = 8;
            this.textBoxPrecoAlcool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço Alcool";
            // 
            // textBoxPrecoGasolina
            // 
            this.textBoxPrecoGasolina.Location = new System.Drawing.Point(107, 171);
            this.textBoxPrecoGasolina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrecoGasolina.Name = "textBoxPrecoGasolina";
            this.textBoxPrecoGasolina.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPrecoGasolina.Size = new System.Drawing.Size(132, 24);
            this.textBoxPrecoGasolina.TabIndex = 10;
            this.textBoxPrecoGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rendimento por litro com:";
            // 
            // textBoxGasolina
            // 
            this.textBoxGasolina.Location = new System.Drawing.Point(107, 112);
            this.textBoxGasolina.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGasolina.Name = "textBoxGasolina";
            this.textBoxGasolina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxGasolina.Size = new System.Drawing.Size(132, 24);
            this.textBoxGasolina.TabIndex = 12;
            this.textBoxGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAlcool
            // 
            this.textBoxAlcool.Location = new System.Drawing.Point(379, 112);
            this.textBoxAlcool.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlcool.Name = "textBoxAlcool";
            this.textBoxAlcool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAlcool.Size = new System.Drawing.Size(132, 24);
            this.textBoxAlcool.TabIndex = 13;
            this.textBoxAlcool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gasolina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alcool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 41);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gastos CTT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::frota_taxi.Properties.Resources._26fd;
            this.pictureBox1.Image = global::frota_taxi.Properties.Resources.gasosa;
            this.pictureBox1.Location = new System.Drawing.Point(261, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(643, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAlcool);
            this.Controls.Add(this.textBoxGasolina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrecoGasolina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrecoAlcool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxLitros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLitros;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecoAlcool;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrecoGasolina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGasolina;
        private System.Windows.Forms.TextBox textBoxAlcool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

