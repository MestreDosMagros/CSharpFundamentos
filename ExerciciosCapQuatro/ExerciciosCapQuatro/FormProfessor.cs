using System;
using System.Windows.Forms;

namespace ExerciciosCapQuatro
{
    public partial class FormProfessor : FormPai
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var textToShow = $@"
            Turma: {base._turma}
            Matéria: {base._materia}
            Horário: {base._horario}
            Sala: {base._sala}
            Nome do professor: {txtNomeProfessor.Text}
            Idade do professor: {numIdadeProfessor.Value.ToString()}
            Formação: {txtFormacaoProfessor.Text}
            Total de turmas do professor: {numTurmasProfessor.Value.ToString()}";

            MessageBox.Show(textToShow, "Informações do professor");
        }
    }
}
