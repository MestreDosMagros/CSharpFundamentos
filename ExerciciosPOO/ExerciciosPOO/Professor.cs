using System;

namespace ExerciciosPOO
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Estou ensinando");
        }
    }
}
