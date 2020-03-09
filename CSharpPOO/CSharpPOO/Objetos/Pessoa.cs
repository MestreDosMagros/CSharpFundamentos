namespace CSharpPOO.Objetos
{
    public class Pessoa
    {
        public Pessoa(string nome, 
                      string endereco, 
                      string telefone, 
                      string cpf, 
                      string rg, 
                      int idade)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
            Idade = idade;
        }

        public void AlterarTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public int Idade { get; private set; }

        public void Beber()
        {
        }

        public void Comer()
        {
        }

        public void Andar()
        {
        }
    }
}
