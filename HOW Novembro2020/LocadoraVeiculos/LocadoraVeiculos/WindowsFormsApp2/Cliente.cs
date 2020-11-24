using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//adicionado para utilizar a referência Mysql.Data
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp2
{
    class Cliente
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string stringSql;
        //Essas 5 linhas acima são as variáveis para facilitar durante o processo de utilização do SQL.

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }



        internal void atualizarGridCliente(DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "SELECT CODIGO, NOME, EMAIL, SENHA FROM clientes";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
                conexao.Open();
                dataAdapter = new SqlDataAdapter(stringSql, conexao);
                DataTable tabela = new DataTable(); //gera uma nova instancia do DataTable para exibir a tabela
                dataAdapter.Fill(tabela); //popula a tabela
                gridTabela.DataSource = tabela; //exibe a tabela
                gridTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; //redimensiona a tabela para se ajustar ao tamanho do objeto pai


            }

            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção

            }

            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                conexao = null;
                comando = null;

            }
        }




        internal void cadastrarCliente(string codigo, string nome, string email, string senha, DataGridView gridTabelaCliente)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "IF NOT EXISTS (SELECT CODIGO FROM clientes WHERE CODIGO = @CODIGO)" +
                    "BEGIN INSERT INTO clientes(CODIGO, NOME, EMAIL, SENHA) VALUES (@CODIGO, @NOME, @EMAIL, @SENHA) END";  //STRING SQL PARA INSERIR O REGISTRO NO BANCO DE DADOS CASO O CODIGO NÃO SEJA REPETIDO
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
                comando.Parameters.AddWithValue("@NOME", nome.ToUpper());//adiciona o valor digitado no campo txtdescricao para a variavel @descricao
                comando.Parameters.AddWithValue("@EMAIL", email.ToUpper());//adiciona o valor digitado no campo txtMarca para a variavel @MARCA
                comando.Parameters.AddWithValue("@SENHA", senha.ToUpper());


                conexao.Open();  //abre a conexao com o banco de dados
                int verificaDuplicidade = comando.ExecuteNonQuery();//se o comando.ExecuteNonQuery retornar 1, significa que o registro foi salvo, caso contrário, significa que o registro não foi salvo devido a duplicidade

                if (verificaDuplicidade >= 1)
                {
                    MessageBox.Show("Registro salvo com sucesso"); //exibe esta mensagem caso não haja duplicidade e o registro seja salvo na base de dados
                }
                if (verificaDuplicidade <= 0)
                {
                    MessageBox.Show("Registro não salvo. Este código já está cadastrado"); //exibe esta mensagem caso haja duplicidade e o registro não possa ser salvo na base de dados
                }

            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção
            }
            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                atualizarGridCliente(gridTabelaCliente);
            }
        }


        internal void consultarCliente(string codigo, string nome, string email, string senha, DataGridView gridTabela)
        {
            if (codigo != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO LIKE '%{0}%'", codigo);
            }
            if (nome != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOME LIKE '%{0}%'", nome);
            }
            if (email != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("EMAIL LIKE '%{0}%'", email);
            }
            if (senha != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("SENHA LIKE '%{0}%'", senha);
            }
        }


        internal void atualizarCliente(string codigo, string nome, string email, string senha, DataGridView gridTabelaCliente)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "UPDATE clientes SET CODIGO = @CODIGO, NOME = @NOME, EMAIL = @EMAIL, SENHA = @SENHA WHERE CODIGO = @CODIGO";  //STRING SQL PARA ATUALIZAR O REGISTRO NO BANCO DE DADOS QUANDO O ID DIGITADO É IGUAL A ALGUM ID NA BASE DE DADOS
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper());
                comando.Parameters.AddWithValue("@NOME", nome.ToUpper());
                comando.Parameters.AddWithValue("@EMAIL", email.ToUpper());
                comando.Parameters.AddWithValue("@SENHA", senha.ToUpper());

                conexao.Open();  //abre a conexao com o banco de dados

                comando.ExecuteNonQuery(); //O método ExecuteNonQuery é utilizado para executar instruções SQL que não retornam dados, como Insert, Update, Delete, e Set.
            }

            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção

            }

            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                conexao = null;
                comando = null;
            }
            atualizarGridCliente(gridTabelaCliente);
        }


        internal void excluirCliente(string codigo, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "DELETE FROM clientes WHERE CODIGO = @CODIGO";  //STRING SQL PARA EXCLUIR O REGISTRO NO BANCO DE DADOS QUANDO O CODIGO DIGITADO É IGUAL A ALGUM CODIGO NA TABELA 
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper());

                conexao.Open();  //abre a conexao com o banco de dados

                comando.ExecuteNonQuery(); //O método ExecuteNonQuery é utilizado para executar instruções SQL que não retornam dados, como Insert, Update, Delete, e Set.
            }

            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção

            }

            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                conexao = null;
                comando = null;
            }
            atualizarGridCliente(gridTabela);
        }



    }
}
