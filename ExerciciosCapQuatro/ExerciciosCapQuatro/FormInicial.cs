using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCapQuatro
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            var form = new FormAluno();
            form.Show();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            var form = new FormProfessor();
            form.Show();
        }
    }
}
