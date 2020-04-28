namespace ExerciciosCapQuatro
{
    partial class FormPai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSala = new System.Windows.Forms.MaskedTextBox();
            this.cnbHorario = new System.Windows.Forms.ComboBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSala);
            this.panel1.Controls.Add(this.cnbHorario);
            this.panel1.Controls.Add(this.txtMateria);
            this.panel1.Controls.Add(this.txtTurma);
            this.panel1.Controls.Add(this.lblSala);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.lblMateria);
            this.panel1.Controls.Add(this.lblTurma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 138);
            this.panel1.TabIndex = 0;
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.Location = new System.Drawing.Point(99, 105);
            this.txtSala.Mask = "A-000";
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 20);
            this.txtSala.TabIndex = 9;
            this.txtSala.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtSala_MaskInputRejected);
            // 
            // cnbHorario
            // 
            this.cnbHorario.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnbHorario.FormattingEnabled = true;
            this.cnbHorario.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.cnbHorario.Location = new System.Drawing.Point(99, 75);
            this.cnbHorario.Name = "cnbHorario";
            this.cnbHorario.Size = new System.Drawing.Size(100, 21);
            this.cnbHorario.TabIndex = 8;
            this.cnbHorario.SelectedIndexChanged += new System.EventHandler(this.cnbHorario_SelectedIndexChanged);
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.Location = new System.Drawing.Point(99, 41);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 5;
            this.txtMateria.TextChanged += new System.EventHandler(this.txtMateria_TextChanged);
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(99, 9);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(100, 20);
            this.txtTurma.TabIndex = 4;
            this.txtTurma.TextChanged += new System.EventHandler(this.txtTurma_TextChanged);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(5, 103);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(59, 19);
            this.lblSala.TabIndex = 3;
            this.lblSala.Text = "Sala:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(4, 73);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(89, 19);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horário:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(4, 41);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(89, 19);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Matéria:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(3, 10);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(69, 19);
            this.lblTurma.TabIndex = 0;
            this.lblTurma.Text = "Turma:";
            // 
            // FormPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 341);
            this.Controls.Add(this.panel1);
            this.Name = "FormPai";
            this.Text = "FormPai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.MaskedTextBox txtSala;
        private System.Windows.Forms.ComboBox cnbHorario;
    }
}