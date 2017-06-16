namespace MatriculaDeAluno
{
    partial class FrmMatriculaDeAluno
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoriaResp = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txbAnoNascimento = new System.Windows.Forms.TextBox();
            this.txbAnoAniversario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Ano Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "An&o último aniversário:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Identificar Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria:";
            // 
            // lblCategoriaResp
            // 
            this.lblCategoriaResp.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoriaResp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaResp.Location = new System.Drawing.Point(212, 79);
            this.lblCategoriaResp.Name = "lblCategoriaResp";
            this.lblCategoriaResp.Size = new System.Drawing.Size(112, 17);
            this.lblCategoriaResp.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txbAnoNascimento
            // 
            this.txbAnoNascimento.Location = new System.Drawing.Point(97, 45);
            this.txbAnoNascimento.Name = "txbAnoNascimento";
            this.txbAnoNascimento.Size = new System.Drawing.Size(57, 20);
            this.txbAnoNascimento.TabIndex = 4;
            // 
            // txbAnoAniversario
            // 
            this.txbAnoAniversario.Location = new System.Drawing.Point(266, 45);
            this.txbAnoAniversario.Name = "txbAnoAniversario";
            this.txbAnoAniversario.Size = new System.Drawing.Size(58, 20);
            this.txbAnoAniversario.TabIndex = 6;
            this.txbAnoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txbAnoAniversario_Validating);
            // 
            // FrmMatriculaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 111);
            this.Controls.Add(this.txbAnoAniversario);
            this.Controls.Add(this.txbAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCategoriaResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatriculaDeAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula de Aluno";
            this.Load += new System.EventHandler(this.FrmMatriculaDeAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoriaResp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txbAnoNascimento;
        private System.Windows.Forms.TextBox txbAnoAniversario;
    }
}

