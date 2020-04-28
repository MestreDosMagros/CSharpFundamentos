namespace ExercicioCapTres
{
    partial class Eventos
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
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.cnbSexoUsuario = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblValidaNomeUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(12, 12);
            this.txtNomeUsuario.MaxLength = 1000;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUsuario.TabIndex = 0;
            this.txtNomeUsuario.TextChanged += new System.EventHandler(this.txtNomeUsuario_TextChanged);
            // 
            // cnbSexoUsuario
            // 
            this.cnbSexoUsuario.FormattingEnabled = true;
            this.cnbSexoUsuario.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cnbSexoUsuario.Location = new System.Drawing.Point(12, 51);
            this.cnbSexoUsuario.Name = "cnbSexoUsuario";
            this.cnbSexoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cnbSexoUsuario.TabIndex = 1;
            this.cnbSexoUsuario.SelectedIndexChanged += new System.EventHandler(this.cnbSexoUsuario_SelectedIndexChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(23, 127);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Avançar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblValidaNomeUsuario
            // 
            this.lblValidaNomeUsuario.AutoSize = true;
            this.lblValidaNomeUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblValidaNomeUsuario.Location = new System.Drawing.Point(9, 35);
            this.lblValidaNomeUsuario.Name = "lblValidaNomeUsuario";
            this.lblValidaNomeUsuario.Size = new System.Drawing.Size(170, 13);
            this.lblValidaNomeUsuario.TabIndex = 3;
            this.lblValidaNomeUsuario.Text = "Nome muito grande, favor abreviar";
            this.lblValidaNomeUsuario.Visible = false;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidaNomeUsuario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cnbSexoUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.ComboBox cnbSexoUsuario;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblValidaNomeUsuario;
    }
}