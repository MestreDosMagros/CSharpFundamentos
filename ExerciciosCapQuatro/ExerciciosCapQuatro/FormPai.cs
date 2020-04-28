using System;
using System.Windows.Forms;

namespace ExerciciosCapQuatro
{
    public partial class FormPai : Form
    {
        protected string _turma;
        protected string _materia;
        protected string _horario;
        protected string _sala;

        public FormPai()
        {
            InitializeComponent();
        }

        private void txtTurma_TextChanged(object sender, EventArgs e)
        {
            _turma = txtTurma.Text;
        }

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {
            _materia = txtMateria.Text;
        }

        private void cnbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            _horario = cnbHorario.SelectedItem.ToString();
        }

        private void txtSala_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            _sala = txtSala.Text;
        }
    }
}
