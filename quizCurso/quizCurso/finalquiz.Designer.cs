namespace quizCurso
{
    partial class finalquiz
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
            this.labelAcertos = new System.Windows.Forms.Label();
            this.labelErros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARABÉNS, VOCÊ CONCLUIU O QUIZ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACERTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ERROS";
            // 
            // labelAcertos
            // 
            this.labelAcertos.AutoSize = true;
            this.labelAcertos.Location = new System.Drawing.Point(511, 112);
            this.labelAcertos.Name = "labelAcertos";
            this.labelAcertos.Size = new System.Drawing.Size(21, 24);
            this.labelAcertos.TabIndex = 3;
            this.labelAcertos.Text = "0";
            // 
            // labelErros
            // 
            this.labelErros.AutoSize = true;
            this.labelErros.Location = new System.Drawing.Point(511, 177);
            this.labelErros.Name = "labelErros";
            this.labelErros.Size = new System.Drawing.Size(21, 24);
            this.labelErros.TabIndex = 4;
            this.labelErros.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelErros);
            this.Controls.Add(this.labelAcertos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "finalquiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "finalquiz";
            this.Load += new System.EventHandler(this.finalquiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAcertos;
        private System.Windows.Forms.Label labelErros;
        private System.Windows.Forms.Button button1;
    }
}