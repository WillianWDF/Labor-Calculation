using MySqlConnector;
using System;
using System.Collections.Generic;

namespace ETAPA_5.Models
{
    public class ItensUsuarioRepository
    {
        //Objetivo: Criar as funcionalidades/métodos que manipulam os atributos da class Usuario.
        //Cadastrar, Listar, Alterar/ Editar e Excluir - CRUD (C - Create , R- Read  , U - Update , D - Delete)
        //Definir as credênciais do Banco de Dados que irei usar.

        private const string DadosConexao = "Database = CalculosTrabalhistas; Data Source=localhost; User Id=root;";
        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de Dados em funcionamento");
            Conexao.Close();
        }

 
         public ItensUsuario BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();//Abro a conexão com o banco de dados.

            //Query em SQL para Filtrar: select * from Tabela;
            String Query = "select * from Usuario where Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("Id", Id);


            MySqlDataReader Reader = Comando.ExecuteReader();

            ItensUsuario UsuarioEncotrado = new ItensUsuario();

            if (Reader.Read())
            {
                //Se for encontrado algum registro, devemos aribuir para o Objeto UsuarioEncotrado.

                UsuarioEncotrado.Id = Reader.GetInt32("Id"); //Recebe os dados do banco de dados e alimenta o objeto.

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncotrado.Nome = Reader.GetString("Nome");//Recebe os dados do banco de dados e alimenta o objeto.

                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    UsuarioEncotrado.Email = Reader.GetString("Email");//Recebe os dados do banco de dados e alimenta o objeto.

                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    UsuarioEncotrado.Telefone = Reader.GetString("Telefone");//Recebe os dados do banco de dados e alimenta o objeto.

                
            }


            Conexao.Close(); //Fecha a conexão com o banco de dados.

            return UsuarioEncotrado; //Retorna os valores do Objeto UsuarioEncotrado.


        }

        public List<ItensUsuario> Listar()
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();//Abro a conexão com o banco de dados.

            //Query em SQL para Listagem: select * from Tabela;
            String Query = "SELECT * FROM Usuario;";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            //Percuso nos registro do Banco de Dados. - É preciso usar uma estrutura de repetição.
            //O objeto Reader irá receber todos os registros executados dentro do Banco de Dados (Em Comando.ExecuteReader();).
            MySqlDataReader Reader = Comando.ExecuteReader(); //Aqui esta a execução do Comando em si.

            List<ItensUsuario> Lista = new List<ItensUsuario>();//Criando uma lista da classe Usuário usuário vazia.
            while (Reader.Read())
            {
                ItensUsuario DadosDeUsuarios = new ItensUsuario();//Criando um objeto da classe Usuario.

                DadosDeUsuarios.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    DadosDeUsuarios.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    DadosDeUsuarios.Email = Reader.GetString("Email");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                    DadosDeUsuarios.Telefone = Reader.GetString("Telefone");

               

                Lista.Add(DadosDeUsuarios);
            }


            Conexao.Close();
            return Lista; // - Retornando a lista da classe Usuário.

        }

        public void Cadastrar(ItensUsuario Dados)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();//Abro a conexão com o banco de dados.

            //Query em SQL para inserção: insert into TABELA (campos) value(informaçõs);
            String Query = "Insert into Usuario (Nome,Email,Telefone) VALUES (@Nome,@Email,@Telefone)";

            //Prepadando o SQL para o objeto de conexão.
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);


            //Tratamento para SQL injection.
            Comando.Parameters.AddWithValue("@Nome", Dados.Nome);
            Comando.Parameters.AddWithValue("@Email", Dados.Email);
            Comando.Parameters.AddWithValue("@Telefone", Dados.Telefone);
            

            Comando.ExecuteNonQuery(); // Executa a Query no banco de dados.

            Conexao.Close();//Fecho a conexão com o banco de dados.      
        }


    public void Editar(ItensUsuario Dados)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();//Abro a conexão com o banco de dados.

            //Query em SQL para Alteração: update tabale set campo1=info1 where condição.
            String Query = "update Usuario set Nome=@Nome, Email=@Email, Telefone=@Telefone where Id=@Id ";

            //Prepadando o SQL para o objeto de conexão.
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);


            //Tratamento para SQL injection.
            Comando.Parameters.AddWithValue("@Id", Dados.Id);
            Comando.Parameters.AddWithValue("@Nome", Dados.Nome);
            Comando.Parameters.AddWithValue("@Email", Dados.Email);
            Comando.Parameters.AddWithValue("@Telefone", Dados.Telefone);
            Comando.ExecuteNonQuery(); // Executa a Query no banco de dados.
            Conexao.Close();//Fecho a conexão com o banco de dados.
        }
    
    
    public void Excluir(ItensUsuario Dados)
            {
                MySqlConnection Conexao = new MySqlConnection(DadosConexao);
                Conexao.Open();//Abro a conexão com o banco de dados.
                //Query em SQL para exclusão: delete from Usuario where = condiçãp.
                String Query = "delete from Usuario where Id=@Id";

                //Prepadando o SQL para o objeto de conexão.
                MySqlCommand Comando = new MySqlCommand(Query, Conexao);

                //Tratamento para SQL injection.
                Comando.Parameters.AddWithValue("@Id", Dados.Id);

                Comando.ExecuteNonQuery(); // Executa a Query no banco de dados.


                Conexao.Close();//Fecho a conexão com o banco de dados.
            }
    
    
    
    }
}