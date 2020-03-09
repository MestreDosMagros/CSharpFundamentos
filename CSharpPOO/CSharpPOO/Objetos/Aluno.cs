using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO.Objetos
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome,
            string endereco,
            string telefone,
            string cpf,
            string rg,
            int idade, 
            int numeroMatricula, 
            string cursoMatriculado, 
            string escola) : base(nome, endereco, telefone, cpf, rg, idade)
        {
            NumeroMatricula = numeroMatricula;
            CursoMatriculado = cursoMatriculado;
            Escola = escola;
        }

        public int NumeroMatricula { get; private set; }
        public string CursoMatriculado { get; private set; }
        public string Escola { get; private set; }

        public void Estudar()
        {
        }
    }
}
