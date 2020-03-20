using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questao1();

            //Questao12();

            //Questao25();

            //Questao32();

            //Questao33();

            //Questao36();

            //Questao39();

            try
            {
                QuestaoBonus();
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato da idade não está correto [0-9]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static void Questao25()
        {
            // Entrar com nome, nota da PR1 e nota da PR2 de um aluno, imprimir nome, nota da PR1, nota da PR2,
            // média e uma das mensagens: APROVADO, REPROVADO ou EXAME(a média é 7 para aprovação, menor que 3
            // para reprovação e as demais em exame).

            Console.WriteLine("Insira seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Insira nota da primeira prova");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira nota da segunda prova");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            var aluno = new AlunoQuestao25();

            aluno.Nome = nome;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;

            var media = (nota1 + nota2) / 2;

            Console.WriteLine($"{aluno.Nome} nota 1: {aluno.Nota1}, nota 2: {aluno.Nota2}, media: {media}");

            if (media >= 7)
                Console.WriteLine("APROVADO");
            else if (media > 3)
                Console.WriteLine("EXAME");
            else
                Console.WriteLine("REPROVADO");
        }

        private static void Questao1()
        {
            // Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos
            // incorporaram essa palavra em seu vocabulário.Sabendo - se que 100 quilowatts de energia custa um sétimo do
            // salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta
            // por uma residência e calcule. Imprima:
            // O valor em reais de cada quilowatt
            // O valor em reais a ser pago
            // O novo valor a ser pago por essa residência com um desconto de 10 %

            Console.WriteLine("Insira o valor do salário mínimo atual");
            var salarioMinimoAtual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de quilowatts gasta");
            var quantidadeQuilowattsGasta = Convert.ToDouble(Console.ReadLine());

            var valorPorQuilowatt = Math.Round((salarioMinimoAtual / 7) / 100, 2);
            var valorAPagar = Math.Round(valorPorQuilowatt * quantidadeQuilowattsGasta, 2);
            var valorComDesconto = Math.Round(valorAPagar - (valorAPagar * 0.1), 2);

            Console.WriteLine($"Valor por quilowatt: {valorPorQuilowatt}");
            Console.WriteLine($"Valor em reais a ser pago: {valorAPagar}");
            Console.WriteLine($"Valor após desconto: {valorComDesconto}");
        }

        private static void Questao12()
        {
            // Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo feminino e tiver menos que 25
            // anos, imprimir nome e a mensagem: ACEITA.Caso contrário, imprimir nome e a mensagem: NÃO ACEITA.
            Console.WriteLine("Insira seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Insira sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira seu gênero");
            var sexo = Convert.ToChar(Console.ReadLine());

            var pessoa = new PessoaQuestao12();

            pessoa.Nome = nome;
            pessoa.Idade = idade;
            pessoa.Sexo = sexo;

            if (pessoa.Sexo == 'F' && pessoa.Idade < 25)
                Console.WriteLine($"{pessoa.Nome} ACEITA");
            else
                Console.WriteLine("NÃO ACEITA");
        }

        private static void Questao32()
        {
            var list1 = CriarArray();

            Console.WriteLine("Lista desordenada:");

            for (int i = 0; i <= list1.Length - 1; i++)
                Console.WriteLine($"posição {i}, valor: {list1[i]}");

            var listaOrdenadaCrescente = list1.OrderBy(x => x).ToArray();
            var listaOrdenadaDecrescente = list1.OrderByDescending(x => x).ToArray();

            Console.WriteLine("Lista ordenada crescente:");

            for (int i = 0; i <= list1.Length - 1; i++)
                Console.WriteLine($"posição: {i}, valor {listaOrdenadaCrescente[i]}");

            Console.WriteLine("Lista ordenada decrescente:");

            for (int i = 0; i <= list1.Length - 1; i++)
                Console.WriteLine($"posição: {i}, valor {listaOrdenadaDecrescente[i]}");
        }

        private static int[] CriarArray()
        {
            var retorno = new int[4];

            var random = new Random();

            for (int i = 0; i <= 4 - 1; i++)
                retorno[i] = random.Next(maxValue: 1000);

            return retorno;
        }

        private static void Questao33()
        {
            // Uma loja tem 15 clientes cadastrados e deseja enviar uma correspondência a cada um deles anunciando
            // um bônus especial.Faça um programa que leia o nome do cliente e o valor das suas compras no ano passado.
            // Calcule e mostre um bônus de 10 % se o valor das compras for menor que R$1.000, 00 e de 15 % caso seja maior
            // do que R$ 1.000,00.

            //cria o cliente
            var cliente1 = new ClienteQuestao33
            {
                Nome = "cliente 1",
                Pedidos = new List<PedidoQuestao33>()
            };

            //cria um pedido
            var pedido1 = new PedidoQuestao33();

            //define as propriedades do pedido
            pedido1.DataCompra = new DateTime(2020, 12, 24);
            pedido1.NomeCliente = cliente1.Nome;
            pedido1.Valor = 121;

            //insere o pedido a lista de pedidos do cliente criado
            cliente1.Pedidos.Add(pedido1);

            var cliente2 = new ClienteQuestao33
            {
                Nome = "cliente 2",
                Pedidos = new List<PedidoQuestao33>()
            };

            var pedido2 = new PedidoQuestao33();

            pedido2.DataCompra = new DateTime(2019, 12, 24);
            pedido2.NomeCliente = cliente2.Nome;
            pedido2.Valor = 312;

            cliente2.Pedidos.Add(pedido2);

            var pedido3 = new PedidoQuestao33();

            pedido3.DataCompra = new DateTime(2019, 06, 12);
            pedido3.NomeCliente = cliente2.Nome;
            pedido3.Valor = 243;

            cliente2.Pedidos.Add(pedido3);

            var pedido4 = new PedidoQuestao33();

            pedido4.DataCompra = new DateTime(2020, 12, 24);
            pedido4.NomeCliente = cliente2.Nome;
            pedido4.Valor = 1800;

            cliente2.Pedidos.Add(pedido4);

            var cliente3 = new ClienteQuestao33
            {
                Nome = "cliente 3",
                Pedidos = new List<PedidoQuestao33>()
            };

            var pedido5 = new PedidoQuestao33();

            pedido5.DataCompra = new DateTime(2019, 06, 12);
            pedido5.NomeCliente = cliente3.Nome;
            pedido5.Valor = 342;

            cliente3.Pedidos.Add(pedido5);

            var pedido6 = new PedidoQuestao33();

            pedido6.DataCompra = new DateTime(2019, 01, 09);
            pedido6.NomeCliente = cliente3.Nome;
            pedido6.Valor = 600;

            cliente3.Pedidos.Add(pedido6);

            var pedido7 = new PedidoQuestao33();

            pedido7.DataCompra = new DateTime(2019, 01, 09);
            pedido7.NomeCliente = cliente3.Nome;
            pedido7.Valor = 1240;

            cliente3.Pedidos.Add(pedido7);

            var listaDeClientesDaLoja = new List<ClienteQuestao33>();

            listaDeClientesDaLoja.Add(cliente1);
            listaDeClientesDaLoja.Add(cliente2);
            listaDeClientesDaLoja.Add(cliente3);

            // parametrizando o ano pelo console
            var ano = Convert.ToInt32(Console.ReadLine());

            foreach (var cliente in listaDeClientesDaLoja)
            {
                // busca somente os pedidos do cliente que foram feitos no ano passado
                var pedidosDoAnoPassado = cliente.Pedidos.Where(pedido => pedido.DataCompra.Year == ano);

                // verifica se a lista de pedidos do ano passado está vazia
                if (!pedidosDoAnoPassado.Any())
                {
                    Console.WriteLine($"Cliente {cliente.Nome} não teve nenhum pedido no ano passado");
                    continue;
                }

                // faz a soma do valor de todos os pedidos da lista de pedidos do ano passado
                var valorTotalDasComprasDoAnoPassado = pedidosDoAnoPassado.Sum(x => x.Valor);

                string bonusTotal;

                if (valorTotalDasComprasDoAnoPassado >= 1000)
                    bonusTotal = "15%";
                else
                    bonusTotal = "10%";

                Console.WriteLine($"Cliente {cliente.Nome} tem um bônus de {bonusTotal}");
            }
        }

        private static void Questao36()
        {
            // Faça um programa que receba idade de 15 pessoas e que calcule e mostre:
            // a quantidade de pessoas em cada faixa etária
            // a percentagem de pessoas na primeira e na última faixa etária, com relação ao total de pessoas

            // 1 - Até 15 anos
            // 2 - De 16 a 30 anos
            // 3 - De 31 a 45 anos
            // 4 - De 46 a 60 anos
            // 5 - Acima de 61 anos

            var listaDePessoas = new List<PessoaQuestao36>();

            for (int i = 0; i <= 5 - 1; i++)
                listaDePessoas.Add(CriarPessoa());

            var faixaEtaria1 = listaDePessoas.Count(x => x.Idade <= 15);
            var faixaEtaria2 = listaDePessoas.Count(x => x.Idade > 15 && x.Idade <= 30);
            var faixaEtaria3 = listaDePessoas.Count(x => x.Idade > 30 && x.Idade <= 45);
            var faixaEtaria4 = listaDePessoas.Count(x => x.Idade > 45 && x.Idade <= 60);
            var faixaEtaria5 = listaDePessoas.Count(x => x.Idade > 60);

            var faixaEtaria1Counter = 0;
            var faixaEtaria2Counter = 0;
            var faixaEtaria3Counter = 0;
            var faixaEtaria4Counter = 0;
            var faixaEtaria5Counter = 0;

            foreach (var pessoa in listaDePessoas)
            {
                if (pessoa.Idade <= 15)
                    faixaEtaria1Counter++;
                else if (pessoa.Idade > 15 && pessoa.Idade <= 30)
                    faixaEtaria2Counter++;
                else if (pessoa.Idade > 30 && pessoa.Idade <= 45)
                    faixaEtaria3Counter++;
                else if (pessoa.Idade > 45 && pessoa.Idade <= 60)
                    faixaEtaria4Counter++;
                else if (pessoa.Idade > 60)
                    faixaEtaria5Counter++;
            }

            var percentagemPessoasPrimeiraFaixaEtaria = (100 * faixaEtaria1) / listaDePessoas.Count();
            var percentagemPessoasUltimaFaixaEtaria = (100 * faixaEtaria5) / listaDePessoas.Count();

            //Console.WriteLine($"Quantidade de pessoas na faixa etária 1: {faixaEtaria1Counter}");
            //Console.WriteLine($"Quantidade de pessoas na faixa etária 2: {faixaEtaria2Counter}");
            //Console.WriteLine($"Quantidade de pessoas na faixa etária 3: {faixaEtaria3Counter}");
            //Console.WriteLine($"Quantidade de pessoas na faixa etária 4: {faixaEtaria4Counter}");
            //Console.WriteLine($"Quantidade de pessoas na faixa etária 5: {faixaEtaria5Counter}");

            Console.WriteLine($"Quantidade de pessoas na faixa etária 1: {faixaEtaria1}");
            Console.WriteLine($"Quantidade de pessoas na faixa etária 2: {faixaEtaria2}");
            Console.WriteLine($"Quantidade de pessoas na faixa etária 3: {faixaEtaria3}");
            Console.WriteLine($"Quantidade de pessoas na faixa etária 4: {faixaEtaria4}");
            Console.WriteLine($"Quantidade de pessoas na faixa etária 5: {faixaEtaria5}");
            Console.WriteLine($"Porcentagem de pessoas na primeira faixa etária em relação ao total: {percentagemPessoasPrimeiraFaixaEtaria}");
            Console.WriteLine($"Porcentagem de pessoas na última faixa etária em relação ao total: {percentagemPessoasUltimaFaixaEtaria}");
        }

        private static PessoaQuestao36 CriarPessoa()
        {
            Console.WriteLine("Insira o nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Insira a idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            return new PessoaQuestao36
            {
                Nome = nome,
                Idade = idade
            };
        }

        private static void Questao39()
        {

        }

        private static void QuestaoBonus()
        {
            // Uma loja possui alguns clientes cadastrados em sua base de dados e quer saber:
            //  quantos clientes foram cadastrados nos ultimos dois meses;
            //  qual a média de valor gasto na loja pelos clientes nos ultimos seis meses;
            //  qual a média de faixa etária dos clientes que compram acima de 1000 reais na loja;
            //  a média de pedidos dos clientes da loja no ano atual;

            // Os clientes devem ser cadastrados pelo usuário
            // Os clientes da loja devem conter as seguintes informações: nome, idade, data de cadastro, lista de pedidos feitos na loja.
            // Os pedidos da loja devem conter as seguintes informações: nome do cliente, data da compra, valor total.

            var listaDeClientesDaLoja = new List<Cliente>();

            for (int i = 0; i < 5; i++)
                listaDeClientesDaLoja.Add(CriarCliente());

            var clientesCadastradosNosUltimosDoisMeses = listaDeClientesDaLoja.Count(cliente =>
                                                                             cliente.DataCadastro >= DateTime.Now.AddMonths(-2));

            //var contador = 0;
            //foreach (var cliente in listaDeClientesDaLoja)
            //{
            //    if (cliente.DataCadastro.Month >= DateTime.Now.Month - 2)
            //        contador++;
            //}

            var listaPedidosFeitosNosUltimosSeisMeses = new List<Pedido>();

            var totalIdadeClientesJaCompraramMaisDe1000Reais = 0;
            var totalClientesJaCompraramMaisDe1000Reais = 0;

            var totalPedidosDoClienteFeitosNoAnoAtual = 0;
            var clientesJaCompraramNoAnoAtual = 0;

            foreach (var cliente in listaDeClientesDaLoja)
            {
                listaPedidosFeitosNosUltimosSeisMeses.AddRange(cliente.Pedidos.Where(pedido =>
                    pedido.DataCompra >= DateTime.Now.AddMonths(-6)));

                //foreach (var pedido in cliente.Pedidos)
                //{
                //    if (pedido.DataCompra.Month <= DateTime.Now.Month - 6)
                //        listaPedidosFeitosNoSemestreAnterior.Add(pedido);
                //}

                var clienteJaComprouMaisDe1000Reais = cliente.Pedidos.Any(pedido => pedido.ValorTotal > 1000);

                if (clienteJaComprouMaisDe1000Reais)
                {
                    totalIdadeClientesJaCompraramMaisDe1000Reais += cliente.Idade;
                    totalClientesJaCompraramMaisDe1000Reais++;
                }

                var clienteJaComprouEsseAno = cliente.Pedidos.Any(pedido => pedido.DataCompra.Year == DateTime.Now.Year);

                if (clienteJaComprouEsseAno)
                {
                    totalPedidosDoClienteFeitosNoAnoAtual += cliente.Pedidos.Count(pedido => pedido.DataCompra.Year == DateTime.Now.Year);
                    clientesJaCompraramNoAnoAtual++;
                }
            }
            clientesJaCompraramNoAnoAtual = 0;
            var mediaPedidosNaLojaNoAnoAtual = totalPedidosDoClienteFeitosNoAnoAtual / clientesJaCompraramNoAnoAtual;

            var mediaFaixaEtariaClientesJaCompraramMaisDe1000 = totalIdadeClientesJaCompraramMaisDe1000Reais / totalClientesJaCompraramMaisDe1000Reais;

            var mediaValorGastoEmPedidosDosUltimosSeisMeses = listaPedidosFeitosNosUltimosSeisMeses.Sum(pedido => pedido.ValorTotal) / listaPedidosFeitosNosUltimosSeisMeses.Count();

            Console.WriteLine($"Média dos pedidos feitos neste ano: {mediaPedidosNaLojaNoAnoAtual}");
            Console.WriteLine($"Média faixa etária dos pedidos com mais de 1000 reais: {mediaFaixaEtariaClientesJaCompraramMaisDe1000}");
            Console.WriteLine($"Média valor gasto nos ultimos seis meses: {mediaValorGastoEmPedidosDosUltimosSeisMeses}");
        }

        private static Cliente CriarCliente()
        {
            Console.WriteLine("Insira seu nome");
            var nome = Console.ReadLine();

            if (nome.Contains("0") ||
                nome.Contains("1") ||
                nome.Contains("2") ||
                nome.Contains("3") ||
                nome.Contains("4") ||
                nome.Contains("5") ||
                nome.Contains("6") ||
                nome.Contains("7") ||
                nome.Contains("8") ||
                nome.Contains("9"))
                throw new Exception("Nome não pode conter digitos");

            Console.WriteLine("Insira sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            var random = new Random();

            var dia = random.Next(minValue: 1, maxValue: 28);
            var mes = random.Next(minValue: 1, maxValue: 12);
            var ano = random.Next(2018, 2021);

            var dataCadastro = new DateTime(ano, mes, dia);

            var listaPedidosDoCliente = new List<Pedido>();

            var totalPedidos = random.Next(1, 10);

            for (int i = 0; i < totalPedidos; i++)
                listaPedidosDoCliente.Add(CriaPedido(nome, dataCadastro));

            return new Cliente
            {
                Nome = nome,
                Idade = idade,
                DataCadastro = dataCadastro,
                Pedidos = listaPedidosDoCliente
            };
        }

        private static Pedido CriaPedido(string nomeCliente, DateTime dataCadastroCliente)
        {
            var random = new Random();

            var dataCadastroPedido = DateTime.MinValue;

            while (dataCadastroPedido < dataCadastroCliente)
            {
                var dia = random.Next(minValue: 1, maxValue: 28);
                var mes = random.Next(minValue: 1, maxValue: 12);
                var ano = random.Next(2019, 2021);

                dataCadastroPedido = new DateTime(ano, mes, dia);
            }

            return new Pedido
            {
                NomeCliente = nomeCliente,
                ValorTotal = random.Next(50, 10000),
                DataCompra = dataCadastroPedido
            };
        }
    }

    public class PessoaQuestao12
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }

    public class AlunoQuestao25
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
    }

    public class ClienteQuestao33
    {
        public string Nome { get; set; }
        public List<PedidoQuestao33> Pedidos { get; set; }
    }

    public class PedidoQuestao33
    {
        public string NomeCliente { get; set; }
        public DateTime DataCompra { get; set; }
        public double Valor { get; set; }
    }

    public class PessoaQuestao36
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }

    public class Pedido
    {
        public string NomeCliente { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
    }
}
