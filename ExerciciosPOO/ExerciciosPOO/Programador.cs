using System;

namespace ExerciciosPOO
{
    public class Programador : Pessoa
    {
        public Programador(string nome) : base(nome)
        {
        }

        public override void Trabalhar()
        {
            Console.WriteLine("Estou programando");
        }
    }
}
