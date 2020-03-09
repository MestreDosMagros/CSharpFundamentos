namespace ExerciciosPOO
{
    public abstract class Animal
    {
        protected Animal(string tipoAnimal)
        {
            TipoAnimal = tipoAnimal;
        }

        public string TipoAnimal { get; private set; }

        public abstract void EmitirSom();
    }
}
