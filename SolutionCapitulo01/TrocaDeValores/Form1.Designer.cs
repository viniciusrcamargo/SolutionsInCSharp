namespace TrocaDeValores
{
    partial class frmTrocaDeValores
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
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrocarValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(48, 21);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(54, 20);
            this.txbValor1.TabIndex = 1;
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(170, 21);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(54, 20);
            this.txbValor2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            // 
            // btnTrocarValor
            // 
            this.btnTrocarValor.Location = new System.Drawing.Point(77, 47);
            this.btnTrocarValor.Name = "btnTrocarValor";
            this.btnTrocarValor.Size = new System.Drawing.Size(108, 23);
            this.btnTrocarValor.TabIndex = 4;
            this.btnTrocarValor.Text = "Trocar valor";
            this.btnTrocarValor.UseVisualStyleBackColor = true;
            this.btnTrocarValor.Click += new System.EventHandler(this.btnTrocarValor_Click);
            // 
            // frmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 75);
            this.Controls.Add(this.btnTrocarValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTrocaDeValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrocarValor;
    }
}

