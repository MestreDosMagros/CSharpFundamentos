using System;

namespace ExerciciosPOO
{
    public class Cachorro : Animal
    {
        public Cachorro(string tipoAnimal) : base(tipoAnimal)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("AU AU");
        }
    }
}
