namespace CalculoPesoIdeal
{
    partial class FrmCalculoPesoIdeal
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
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rbtnFeminino);
            this.grbSexo.Controls.Add(this.rbtnMasculino);
            this.grbSexo.Location = new System.Drawing.Point(13, 13);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(169, 46);
            this.grbSexo.TabIndex = 0;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(86, 19);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(7, 20);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(243, 30);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(114, 20);
            this.txbAltura.TabIndex = 2;
            this.txbAltura.TextChanged += new System.EventHandler(this.txbAltura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso Ideal";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.Blue;
            this.lblPesoIdeal.Location = new System.Drawing.Point(146, 79);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(100, 23);
            this.lblPesoIdeal.TabIndex = 4;
            // 
            // FrmCalculoPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 119);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbSexo);
            this.Name = "FrmCalculoPesoIdeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Peso Ideal";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPesoIdeal;
    }
}

