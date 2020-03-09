using System;

namespace ExerciciosPOO
{
    public class Gato : Animal
    {
        public Gato(string tipoAnimal) : base(tipoAnimal)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("MIAU");
        }
    }
}
