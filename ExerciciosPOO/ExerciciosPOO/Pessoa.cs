namespace ExerciciosPOO
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public abstract void Trabalhar();
    }
}
