using System;
using System.Data.SqlClient;

namespace ExemploConexaoSQL
{
    class Program
    {
        const string ConnectionString = @"Server=localhost;Database=ESCOLA;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            var alunoInserir = new Aluno(cPF: "1234567892",
                                          nome: "Aluno Teste",
                                          email: "teste@teste.com",
                                          dDD: "47",
                                          telefone: "123456789",
                                          dDDContato: "47",
                                          telefoneContato: "123456789",
                                          dataNascimento: DateTime.Now);

            //Insert(alunoInserir);
            //Select(alunoInserir.Nome);

            //var alunoAtualizar = Select(2);
            //Update(alunoAtualizar, "048");
            //var alunoAtualizado = Select(2);
            Delete();
        }

        private static Aluno Select(int idPesquisar)
        {
            var conn = new SqlConnection(ConnectionString);
            Aluno aluno = null;

            try
            {
                conn.Open();

                var select = @"SELECT ID, CPF, NOME, EMAIL, DDD, TELEFONE, DDD_CONTATO, TELEFONE_CONTATO, DATA_NASCIMENTO FROM ALUNOS WHERE ID = @ID";

                using var cmd = new SqlCommand(select, conn);

                cmd.Parameters.AddWithValue("@ID", idPesquisar);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var id = Convert.ToInt32(reader["ID"]);
                    var cpf = Convert.ToString(reader["CPF"]);
                    var nome = Convert.ToString(reader["NOME"]);
                    var email = Convert.ToString(reader["EMAIL"]);
                    var ddd = reader["DDD"].ToString();
                    var telefone = Convert.ToString(reader["TELEFONE"]);
                    var dddContato = Convert.ToString(reader["DDD_CONTATO"]);
                    var telefoneContato = Convert.ToString(reader["TELEFONE_CONTATO"]);
                    var dataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);

                    aluno = new Aluno(id, cpf, nome, email, ddd, telefone, dddContato, telefoneContato, dataNascimento);

                    Console.WriteLine(aluno.ToString());
                }
                else
                    Console.WriteLine("Nenhum registro encontrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return aluno;
        }

        private static void Select(string nomePesquisar)
        {
            var conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                var select = @"SELECT ID, CPF, NOME, EMAIL, DDD, TELEFONE, DDD_CONTATO, TELEFONE_CONTATO, DATA_NASCIMENTO FROM ALUNOS WHERE NOME = @NOME";

                using var cmd = new SqlCommand(select, conn);

                cmd.Parameters.AddWithValue("@NOME", nomePesquisar);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var id = Convert.ToInt32(reader["ID"]);
                    var cpf = Convert.ToString(reader["CPF"]);
                    var nome = Convert.ToString(reader["NOME"]);
                    var email = Convert.ToString(reader["EMAIL"]);
                    var ddd = reader["DDD"].ToString();
                    var telefone = Convert.ToString(reader["TELEFONE"]);
                    var dddContato = Convert.ToString(reader["DDD_CONTATO"]);
                    var telefoneContato = Convert.ToString(reader["TELEFONE_CONTATO"]);
                    var dataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);

                    var aluno = new Aluno(id, cpf, nome, email, ddd, telefone, dddContato, telefoneContato, dataNascimento);

                    Console.WriteLine(aluno.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private static void Insert(Aluno alunoInserir)
        {
            var conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                var insert = @"INSERT INTO ALUNOS (CPF, NOME, EMAIL) VALUES (@CPF, @NOME, @EMAIL)";

                var cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@CPF", alunoInserir.CPF);
                cmd.Parameters.AddWithValue("@NOME", alunoInserir.Nome);
                cmd.Parameters.AddWithValue("@EMAIL", alunoInserir.Email);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Aluno inserido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private static void Update(Aluno alunoAtualizar, string dddNovo)
        {
            var conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                var update = @"UPDATE ALUNOS SET DDD = @DDD WHERE ID = @ID";

                using var cmd = new SqlCommand(update, conn);

                cmd.Parameters.AddWithValue("@DDD", dddNovo);
                cmd.Parameters.AddWithValue("@ID", alunoAtualizar.Id);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private static void Delete()
        {
            var conn = new SqlConnection(ConnectionString);

            try
            {
                conn.Open();

                var delete = @"DELETE FROM ALUNOS WHERE DDD IS NULL";

                var cmd = new SqlCommand(delete, conn);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Exclusão concluida com sucesso");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public class Aluno
        {
            public Aluno(string cPF,
                         string nome,
                         string email,
                         string dDD,
                         string telefone,
                         string dDDContato,
                         string telefoneContato,
                         DateTime dataNascimento)
            {
                CPF = cPF;
                Nome = nome;
                Email = email;
                DDD = dDD;
                Telefone = telefone;
                DDDContato = dDDContato;
                TelefoneContato = telefoneContato;
                DataNascimento = dataNascimento;
            }

            public Aluno(int id,
                         string cPF,
                         string nome,
                         string email,
                         string dDD,
                         string telefone,
                         string dDDContato,
                         string telefoneContato,
                         DateTime dataNascimento)
            {
                Id = id;
                CPF = cPF;
                Nome = nome;
                Email = email;
                DDD = dDD;
                Telefone = telefone;
                DDDContato = dDDContato;
                TelefoneContato = telefoneContato;
                DataNascimento = dataNascimento;
            }

            public int Id { get; private set; }
            public string CPF { get; private set; }
            public string Nome { get; private set; }
            public string Email { get; private set; }
            public string DDD { get; private set; }
            public string Telefone { get; private set; }
            public string DDDContato { get; private set; }
            public string TelefoneContato { get; private set; }
            public DateTime DataNascimento { get; private set; }

            public override string ToString()
            {
                return $@"Id: {Id}, CPF: {CPF}, Nome: {Nome}, Email: {Email}, DDD: {DDD}";
            }
        }
    }
}
