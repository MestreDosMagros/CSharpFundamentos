using System;
using System.Windows.Forms;

namespace ExerciciosCapQuatro
{
    public partial class FormAluno : FormPai
    {
        public FormAluno()
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
            Nome do aluno: {txtNomeAluno.Text}
            Idade do aluno: {numIdadeAluno.Value.ToString()}
            CPF do aluno: {txtCPFAluno.Text}
            Semestre atual: {cnbSemestreAluno.SelectedItem.ToString()}";
            
            MessageBox.Show(textToShow, "Informações do aluno");
        }
    }
}
