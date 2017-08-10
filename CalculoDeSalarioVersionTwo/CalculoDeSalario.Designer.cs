namespace CalculoDeSalario
{
    partial class FrmCalculoDeSalario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSalMinimo = new System.Windows.Forms.TextBox();
            this.txbHorasTrab = new System.Windows.Forms.TextBox();
            this.gbTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbVeterano = new System.Windows.Forms.RadioButton();
            this.rbCalouro = new System.Windows.Forms.RadioButton();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTurno.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // txbSalMinimo
            // 
            this.txbSalMinimo.Location = new System.Drawing.Point(152, 28);
            this.txbSalMinimo.Name = "txbSalMinimo";
            this.txbSalMinimo.Size = new System.Drawing.Size(173, 22);
            this.txbSalMinimo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbSalMinimo, "Informe o valor atual do salário mínimo");
            // 
            // txbHorasTrab
            // 
            this.txbHorasTrab.Location = new System.Drawing.Point(153, 62);
            this.txbHorasTrab.Name = "txbHorasTrab";
            this.txbHorasTrab.Size = new System.Drawing.Size(172, 22);
            this.txbHorasTrab.TabIndex = 3;
            // 
            // gbTurno
            // 
            this.gbTurno.Controls.Add(this.rbNoturno);
            this.gbTurno.Controls.Add(this.rbVespertino);
            this.gbTurno.Controls.Add(this.rbMatutino);
            this.gbTurno.Location = new System.Drawing.Point(344, 24);
            this.gbTurno.Name = "gbTurno";
            this.gbTurno.Size = new System.Drawing.Size(200, 117);
            this.gbTurno.TabIndex = 4;
            this.gbTurno.TabStop = false;
            this.gbTurno.Text = "Turno";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(12, 83);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(80, 21);
            this.rbNoturno.TabIndex = 2;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(12, 53);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(97, 21);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(12, 22);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(83, 21);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbVeterano);
            this.gbCategoria.Controls.Add(this.rbCalouro);
            this.gbCategoria.Location = new System.Drawing.Point(17, 89);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(306, 52);
            this.gbCategoria.TabIndex = 5;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // rbVeterano
            // 
            this.rbVeterano.AutoSize = true;
            this.rbVeterano.Location = new System.Drawing.Point(180, 18);
            this.rbVeterano.Name = "rbVeterano";
            this.rbVeterano.Size = new System.Drawing.Size(87, 21);
            this.rbVeterano.TabIndex = 1;
            this.rbVeterano.TabStop = true;
            this.rbVeterano.Text = "Veterano";
            this.rbVeterano.UseVisualStyleBackColor = true;
            // 
            // rbCalouro
            // 
            this.rbCalouro.AutoSize = true;
            this.rbCalouro.Location = new System.Drawing.Point(12, 20);
            this.rbCalouro.Name = "rbCalouro";
            this.rbCalouro.Size = new System.Drawing.Size(78, 21);
            this.rbCalouro.TabIndex = 0;
            this.rbCalouro.TabStop = true;
            this.rbCalouro.Text = "Calouro";
            this.rbCalouro.UseVisualStyleBackColor = true;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 16;
            this.lbResultado.Location = new System.Drawing.Point(19, 148);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(525, 148);
            this.lbResultado.TabIndex = 6;
            // 
            // lblSituacao
            // 
            this.lblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacao.Location = new System.Drawing.Point(19, 310);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(381, 32);
            this.lblSituacao.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(406, 310);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 32);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // FrmCalculoDeSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 354);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbTurno);
            this.Controls.Add(this.txbHorasTrab);
            this.Controls.Add(this.txbSalMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculoDeSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Sálario";
            this.gbTurno.ResumeLayout(false);
            this.gbTurno.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSalMinimo;
        private System.Windows.Forms.TextBox txbHorasTrab;
        private System.Windows.Forms.GroupBox gbTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbVeterano;
        private System.Windows.Forms.RadioButton rbCalouro;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}