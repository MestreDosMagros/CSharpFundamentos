namespace CSharpPOO.Abstracao
{
    public abstract class Veiculo
    {
        public Veiculo(string tipoModelo)
        {
            TipoModelo = tipoModelo;
        }

        public string TipoModelo { get; private set; }

        public abstract void Mover();

        public abstract void Parar();

        public abstract void Parar(string comoParar);

        public abstract void Abastecer();
    }
}
