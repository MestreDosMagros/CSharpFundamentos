namespace ExerciciosCapQuatro
{
    partial class FormAluno
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cnbSemestreAluno = new System.Windows.Forms.ComboBox();
            this.numIdadeAluno = new System.Windows.Forms.NumericUpDown();
            this.txtCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblSemenstre = new System.Windows.Forms.Label();
            this.lblIdadeAluno = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdadeAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.cnbSemestreAluno);
            this.panel2.Controls.Add(this.numIdadeAluno);
            this.panel2.Controls.Add(this.txtCPFAluno);
            this.panel2.Controls.Add(this.txtNomeAluno);
            this.panel2.Controls.Add(this.lblCpfAluno);
            this.panel2.Controls.Add(this.lblSemenstre);
            this.panel2.Controls.Add(this.lblIdadeAluno);
            this.panel2.Controls.Add(this.lblNomeAluno);
            this.panel2.Location = new System.Drawing.Point(12, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 170);
            this.panel2.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(68, 135);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cnbSemestreAluno
            // 
            this.cnbSemestreAluno.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnbSemestreAluno.FormattingEnabled = true;
            this.cnbSemestreAluno.Items.AddRange(new object[] {
            "1º Semestre",
            "2º Semestre",
            "3º Semestre",
            "4º Semestre",
            "5º Semestre",
            "6º Semestre",
            "7º Semestre",
            "8º Semestre",
            "9º Semestre",
            "10º Semestre"});
            this.cnbSemestreAluno.Location = new System.Drawing.Point(99, 98);
            this.cnbSemestreAluno.Name = "cnbSemestreAluno";
            this.cnbSemestreAluno.Size = new System.Drawing.Size(100, 21);
            this.cnbSemestreAluno.TabIndex = 8;
            // 
            // numIdadeAluno
            // 
            this.numIdadeAluno.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdadeAluno.InterceptArrowKeys = false;
            this.numIdadeAluno.Location = new System.Drawing.Point(99, 40);
            this.numIdadeAluno.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numIdadeAluno.Name = "numIdadeAluno";
            this.numIdadeAluno.Size = new System.Drawing.Size(100, 20);
            this.numIdadeAluno.TabIndex = 2;
            // 
            // txtCPFAluno
            // 
            this.txtCPFAluno.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFAluno.Location = new System.Drawing.Point(99, 68);
            this.txtCPFAluno.Mask = "000.000.000-00";
            this.txtCPFAluno.Name = "txtCPFAluno";
            this.txtCPFAluno.Size = new System.Drawing.Size(100, 20);
            this.txtCPFAluno.TabIndex = 6;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(99, 8);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfAluno.Location = new System.Drawing.Point(6, 70);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(49, 19);
            this.lblCpfAluno.TabIndex = 3;
            this.lblCpfAluno.Text = "CPF:";
            // 
            // lblSemenstre
            // 
            this.lblSemenstre.AutoSize = true;
            this.lblSemenstre.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemenstre.Location = new System.Drawing.Point(5, 100);
            this.lblSemenstre.Name = "lblSemenstre";
            this.lblSemenstre.Size = new System.Drawing.Size(99, 19);
            this.lblSemenstre.TabIndex = 2;
            this.lblSemenstre.Text = "Semestre:";
            // 
            // lblIdadeAluno
            // 
            this.lblIdadeAluno.AutoSize = true;
            this.lblIdadeAluno.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeAluno.Location = new System.Drawing.Point(3, 40);
            this.lblIdadeAluno.Name = "lblIdadeAluno";
            this.lblIdadeAluno.Size = new System.Drawing.Size(69, 19);
            this.lblIdadeAluno.TabIndex = 1;
            this.lblIdadeAluno.Text = "Idade:";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno.Location = new System.Drawing.Point(6, 10);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(59, 19);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome:";
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 341);
            this.Controls.Add(this.panel2);
            this.Name = "FormAluno";
            this.Text = "FormAluno";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdadeAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblSemenstre;
        private System.Windows.Forms.Label lblIdadeAluno;
        private System.Windows.Forms.NumericUpDown numIdadeAluno;
        private System.Windows.Forms.MaskedTextBox txtCPFAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.ComboBox cnbSemestreAluno;
        private System.Windows.Forms.Button btnEnviar;
    }
}