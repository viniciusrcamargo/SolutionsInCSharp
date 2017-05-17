namespace GastoEmRestaurante
{
    partial class FrmGastoEmRestaurante
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
            this.txbDespesa = new System.Windows.Forms.TextBox();
            this.brnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Despesa";
            // 
            // txbDespesa
            // 
            this.txbDespesa.Location = new System.Drawing.Point(58, 11);
            this.txbDespesa.Name = "txbDespesa";
            this.txbDespesa.Size = new System.Drawing.Size(100, 20);
            this.txbDespesa.TabIndex = 1;
            // 
            // brnCalcular
            // 
            this.brnCalcular.Location = new System.Drawing.Point(173, 9);
            this.brnCalcular.Name = "brnCalcular";
            this.brnCalcular.Size = new System.Drawing.Size(75, 23);
            this.brnCalcular.TabIndex = 2;
            this.brnCalcular.Text = "Calcular";
            this.brnCalcular.UseVisualStyleBackColor = true;
            this.brnCalcular.Click += new System.EventHandler(this.brnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total com 10%";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.Color.Yellow;
            this.txbTotal.Enabled = false;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(107, 44);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(141, 20);
            this.txbTotal.TabIndex = 4;
            // 
            // FrmGastoEmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 70);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnCalcular);
            this.Controls.Add(this.txbDespesa);
            this.Controls.Add(this.label1);
            this.Name = "FrmGastoEmRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasto em Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDespesa;
        private System.Windows.Forms.Button brnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTotal;
    }
}

