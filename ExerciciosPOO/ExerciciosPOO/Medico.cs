using System;

namespace ExerciciosPOO
{
    public class Medico : Pessoa
    {
        public Medico(string nome) : base(nome)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Estou de plantão");
        }
    }
}
