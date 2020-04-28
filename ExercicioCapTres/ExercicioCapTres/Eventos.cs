using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCapTres
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo!", "Bem vindo");
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text.Length > 15)
                lblValidaNomeUsuario.Visible = true;
            else
                lblValidaNomeUsuario.Visible = false;
        }

        private void cnbSexoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cnbSexoUsuario.SelectedItem.ToString() == "Masculino")
                txtNomeUsuario.Text = txtNomeUsuario.Text.ToUpper();
            else
                txtNomeUsuario.Text = txtNomeUsuario.Text.ToLower();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
    }
}
