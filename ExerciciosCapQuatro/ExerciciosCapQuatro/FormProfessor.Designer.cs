namespace ExerciciosCapQuatro
{
    partial class FormProfessor
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
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblIdadeProfessor = new System.Windows.Forms.Label();
            this.lblFormacaoProfessor = new System.Windows.Forms.Label();
            this.lblQntTurmasProfessor = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.txtFormacaoProfessor = new System.Windows.Forms.TextBox();
            this.numIdadeProfessor = new System.Windows.Forms.NumericUpDown();
            this.numTurmasProfessor = new System.Windows.Forms.NumericUpDown();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdadeProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurmasProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.numTurmasProfessor);
            this.panel2.Controls.Add(this.numIdadeProfessor);
            this.panel2.Controls.Add(this.txtFormacaoProfessor);
            this.panel2.Controls.Add(this.txtNomeProfessor);
            this.panel2.Controls.Add(this.lblQntTurmasProfessor);
            this.panel2.Controls.Add(this.lblFormacaoProfessor);
            this.panel2.Controls.Add(this.lblIdadeProfessor);
            this.panel2.Controls.Add(this.lblNomeProfessor);
            this.panel2.Location = new System.Drawing.Point(13, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 172);
            this.panel2.TabIndex = 1;
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(8, 15);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(59, 19);
            this.lblNomeProfessor.TabIndex = 0;
            this.lblNomeProfessor.Text = "Nome:";
            // 
            // lblIdadeProfessor
            // 
            this.lblIdadeProfessor.AutoSize = true;
            this.lblIdadeProfessor.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeProfessor.Location = new System.Drawing.Point(4, 43);
            this.lblIdadeProfessor.Name = "lblIdadeProfessor";
            this.lblIdadeProfessor.Size = new System.Drawing.Size(69, 19);
            this.lblIdadeProfessor.TabIndex = 1;
            this.lblIdadeProfessor.Text = "Idade:";
            // 
            // lblFormacaoProfessor
            // 
            this.lblFormacaoProfessor.AutoSize = true;
            this.lblFormacaoProfessor.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormacaoProfessor.Location = new System.Drawing.Point(4, 72);
            this.lblFormacaoProfessor.Name = "lblFormacaoProfessor";
            this.lblFormacaoProfessor.Size = new System.Drawing.Size(99, 19);
            this.lblFormacaoProfessor.TabIndex = 2;
            this.lblFormacaoProfessor.Text = "Formação:";
            // 
            // lblQntTurmasProfessor
            // 
            this.lblQntTurmasProfessor.AutoSize = true;
            this.lblQntTurmasProfessor.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntTurmasProfessor.Location = new System.Drawing.Point(8, 100);
            this.lblQntTurmasProfessor.Name = "lblQntTurmasProfessor";
            this.lblQntTurmasProfessor.Size = new System.Drawing.Size(79, 19);
            this.lblQntTurmasProfessor.TabIndex = 3;
            this.lblQntTurmasProfessor.Text = "Turmas:";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfessor.Location = new System.Drawing.Point(98, 13);
            this.txtNomeProfessor.MaxLength = 50;
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProfessor.TabIndex = 4;
            // 
            // txtFormacaoProfessor
            // 
            this.txtFormacaoProfessor.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormacaoProfessor.Location = new System.Drawing.Point(98, 72);
            this.txtFormacaoProfessor.Name = "txtFormacaoProfessor";
            this.txtFormacaoProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtFormacaoProfessor.TabIndex = 5;
            // 
            // numIdadeProfessor
            // 
            this.numIdadeProfessor.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdadeProfessor.Location = new System.Drawing.Point(98, 43);
            this.numIdadeProfessor.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numIdadeProfessor.Name = "numIdadeProfessor";
            this.numIdadeProfessor.Size = new System.Drawing.Size(100, 20);
            this.numIdadeProfessor.TabIndex = 6;
            // 
            // numTurmasProfessor
            // 
            this.numTurmasProfessor.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTurmasProfessor.Location = new System.Drawing.Point(98, 98);
            this.numTurmasProfessor.Name = "numTurmasProfessor";
            this.numTurmasProfessor.Size = new System.Drawing.Size(100, 20);
            this.numTurmasProfessor.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(73, 135);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 341);
            this.Controls.Add(this.panel2);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIdadeProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurmasProfessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown numTurmasProfessor;
        private System.Windows.Forms.NumericUpDown numIdadeProfessor;
        private System.Windows.Forms.TextBox txtFormacaoProfessor;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label lblQntTurmasProfessor;
        private System.Windows.Forms.Label lblFormacaoProfessor;
        private System.Windows.Forms.Label lblIdadeProfessor;
        private System.Windows.Forms.Label lblNomeProfessor;
    }
}