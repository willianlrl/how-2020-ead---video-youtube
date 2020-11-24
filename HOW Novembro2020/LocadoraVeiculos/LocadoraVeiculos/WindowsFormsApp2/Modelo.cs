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
    class Modelo
    {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string stringSql;
        //Essas 5 linhas acima são as variáveis para facilitar durante o processo de utilização do SQL.






        // MODELOS

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }



        //preencher combo box com as marcas da cadastradas na tabela "marcas"
        internal void preencherComboBoxMarcas(ComboBox cmbMarca)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            conexao.Open();
            stringSql = "SELECT descricao FROM marcas";  //STRING SQL PARA ATUALIZAR O REGISTRO NO BANCO DE DADOS QUANDO O ID DIGITADO É IGUAL A ALGUM ID NA BASE DE DADOS
            comando = new SqlCommand(stringSql, conexao);
            dataAdapter = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();  //instancia de uma nova tabela
            dataAdapter.Fill(tabela); //preenche a tabela
            cmbMarca.DataSource = tabela; //informa que a fonte de dados para o combobox será a tabela gerada neste método
            cmbMarca.DisplayMember = "descricao"; //seleciona o display com os dados de descrição da tabela marcas
            cmbMarca.SelectedIndex = -1;  //deixar o combobox limpo, sem nenhuma opção selecionada ao ser carregado
            conexao.Close();
        }


        internal void cadastrarModelo(string codigo, string descricao, string marca, DataGridView gridTabelaModelo)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "IF NOT EXISTS (SELECT CODIGO FROM modelos WHERE CODIGO = @CODIGO)" +
                    "BEGIN INSERT INTO modelos(CODIGO, DESCRICAO, MARCA) VALUES (@CODIGO, @DESCRICAO, @MARCA) END";  //STRING SQL PARA INSERIR O REGISTRO NO BANCO DE DADOS CASO O CODIGO NÃO SEJA REPETIDO
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
                comando.Parameters.AddWithValue("@DESCRICAO", descricao.ToUpper());//adiciona o valor digitado no campo txtdescricao para a variavel @descricao
                comando.Parameters.AddWithValue("@MARCA", marca.ToUpper());//adiciona o valor digitado no campo txtMarca para a variavel @MARCA


                conexao.Open();  //abre a conexao com o banco de dados
                int verificaDuplicidade = comando.ExecuteNonQuery();//se o comando.ExecuteNonQuery retornar 1, significa que o registro foi salvo, caso contrário, significa que o registro não foi salvo devido a duplicidade

                if (verificaDuplicidade == 1)
                {
                    MessageBox.Show("Registro salvo com sucesso"); //exibe esta mensagem caso não haja duplicidade e o registro seja salvo na base de dados
                }
                if (verificaDuplicidade != 1)
                {
                    MessageBox.Show("Registro não salvo. Este código já está cadastrado"); //exibe esta mensagem caso haja duplicidade e o registro não possa ser salvo na base de dados
                }
                comando.ExecuteNonQuery(); //O método ExecuteNonQuery é utilizado para executar instruções SQL que não retornam dados, como Insert, Update, Delete, e Set.

            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção
            }
            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                atualizarGridModelo(gridTabelaModelo);
            }
        }

        //atualiza grid na tela de cadastro de modelos
        internal void atualizarGridModelo(DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "SELECT CODIGO, DESCRICAO, MARCA FROM modelos";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
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


        //consultar modelo
        internal void consultarModelo(string codigo, string descricao, DataGridView gridTabela)
        {
            if (codigo != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO LIKE '%{0}%'", codigo); //realiza a consulta da marca e atualiza a tabela no DataGridView
            }
            if (descricao != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("DESCRICAO LIKE '%{0}%'", descricao); //realiza a consulta da marca e atualiza a tabela no DataGridView
            }
        }



        //atualizar modelo
        internal void atualizarModelo(string codigo, string descricao, string marca, DataGridView gridTabelaModelo)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "UPDATE modelos SET CODIGO = @CODIGO, DESCRICAO = @DESCRICAO, MARCA = @MARCA WHERE CODIGO = @CODIGO";  //STRING SQL PARA ATUALIZAR O REGISTRO NO BANCO DE DADOS QUANDO O ID DIGITADO É IGUAL A ALGUM ID NA BASE DE DADOS
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper());
                comando.Parameters.AddWithValue("@DESCRICAO", descricao.ToUpper());
                comando.Parameters.AddWithValue("@MARCA", marca.ToUpper());

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
            atualizarGridModelo(gridTabelaModelo);
        }




        //excluir modelo
        internal void excluirModelo(string codigo, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "DELETE FROM modelos WHERE CODIGO = @CODIGO";  //STRING SQL PARA EXCLUIR O REGISTRO NO BANCO DE DADOS QUANDO O CODIGO DIGITADO É IGUAL A ALGUM CODIGO NA TABELA MARCAS
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
            atualizarGridModelo(gridTabela);
        }
    }
}
