namespace MatriculaAlunoVersionTwo
{
    partial class FrmMatriculaAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.btnIdentificarCat = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblRecCat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(55, 10);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(383, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(13, 45);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(126, 43);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(154, 20);
            this.dtpDataNasc.TabIndex = 3;
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(286, 45);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 13);
            this.lblDataAtual.TabIndex = 4;
            // 
            // btnIdentificarCat
            // 
            this.btnIdentificarCat.Location = new System.Drawing.Point(16, 73);
            this.btnIdentificarCat.Name = "btnIdentificarCat";
            this.btnIdentificarCat.Size = new System.Drawing.Size(198, 23);
            this.btnIdentificarCat.TabIndex = 5;
            this.btnIdentificarCat.Text = "Identificar Categoria";
            this.btnIdentificarCat.UseVisualStyleBackColor = true;
            this.btnIdentificarCat.Click += new System.EventHandler(this.btnIdentificarCat_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.Color.Blue;
            this.lblCat.Location = new System.Drawing.Point(234, 78);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 6;
            this.lblCat.Text = "Categoria";
            // 
            // lblRecCat
            // 
            this.lblRecCat.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.lblRecCat.BackColor = System.Drawing.Color.Yellow;
            this.lblRecCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecCat.Enabled = false;
            this.lblRecCat.Location = new System.Drawing.Point(292, 73);
            this.lblRecCat.Name = "lblRecCat";
            this.lblRecCat.Size = new System.Drawing.Size(146, 23);
            this.lblRecCat.TabIndex = 7;
            // 
            // FrmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 103);
            this.Controls.Add(this.lblRecCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnIdentificarCat);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmMatriculaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula de Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Button btnIdentificarCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblRecCat;
    }
}

