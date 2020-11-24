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
    class Locacao
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

        private string dataRetirada;

        public string DataRetirada
        {
            get { return dataRetirada; }
            set { dataRetirada = value; }
        }

        private string dataDevolucao;

        public string DataDevolucao
        {
            get { return dataDevolucao; }
            set { dataDevolucao = value; }
        }

        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string obs;

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        private string codigoCarro;

        public string CodigoCarro
        {
            get { return codigoCarro; }
            set { codigoCarro = value; }
        }

        private string modeloCarro;

        public string ModeloCarro
        {
            get { return modeloCarro; }
            set { modeloCarro = value; }
        }

        private string anoCarro;

        public string AnoCarro
        {
            get { return anoCarro; }
            set { anoCarro = value; }
        }

        private string nomeCliente;

        public string NomeCliente
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        private string codigoCliente;

        public string CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }


        internal void preencherComboBoxCodigoCliente(ComboBox cmbCliente)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            conexao.Open();
            stringSql = "SELECT codigo FROM clientes";
            comando = new SqlCommand(stringSql, conexao);
            dataAdapter = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();  //instancia de uma nova tabela
            dataAdapter.Fill(tabela); //preenche a tabela que será gerada no combobox
            cmbCliente.DataSource = tabela; //informa que a fonte de dados para o combobox será a tabela gerada neste método
            cmbCliente.DisplayMember = "codigo"; //seleciona o display com os dados de descrição da tabela marcas
            cmbCliente.SelectedIndex = -1;  //deixar o combobox limpo, sem nenhuma opção selecionada ao ser carregado
            conexao.Close();
        }

        internal void preencherComboBoxCodigoVeiculo(ComboBox cmbVeiculo)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            conexao.Open();
            stringSql = "SELECT codigo FROM veiculos";
            comando = new SqlCommand(stringSql, conexao);
            dataAdapter = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();  //instancia de uma nova tabela
            dataAdapter.Fill(tabela); //preenche a tabela que será gerada no combobox
            cmbVeiculo.DataSource = tabela; //informa que a fonte de dados para o combobox será a tabela gerada neste método
            cmbVeiculo.DisplayMember = "codigo"; //seleciona o display com os dados de descrição da tabela marcas
            cmbVeiculo.SelectedIndex = -1;  //deixar o combobox limpo, sem nenhuma opção selecionada ao ser carregado
            conexao.Close();
        }

        internal void atualizarGridLocacao(DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "SELECT CODIGO, DATA_RETIRADA, DATA_DEVOLUCAO, CODIGO_CLIENTE, NOME_CLIENTE, CODIGO_CARRO, MODELO_CARRO, VALOR, OBS FROM locacao";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
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


        //preenche os TextBox read only da tela de locação referentes ao veículo
        internal void preencherTxtCarro(string codigo, TextBox txtModeloLocacao, TextBox txtAnoLocacao, TextBox txtObsCarroLocacao)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            stringSql = "SELECT MODELO FROM veiculos where @CODIGO = CODIGO ";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
            conexao.Open();
            comando = new SqlCommand(stringSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", codigo); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
            dataAdapter = new SqlDataAdapter(comando);
            txtModeloLocacao.Text = (string)comando.ExecuteScalar();

            stringSql = "SELECT ANO FROM veiculos where @CODIGO = CODIGO ";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
            comando = new SqlCommand(stringSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", codigo); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
            txtAnoLocacao.Text = (string)comando.ExecuteScalar();


            stringSql = "SELECT OBS FROM veiculos where @CODIGO = CODIGO ";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS
            comando = new SqlCommand(stringSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", codigo); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
            txtObsCarroLocacao.Text = (string)comando.ExecuteScalar();
        }


        //preenche os TextBox read only da tela de locação referentes ao cliente
        internal void preencherTxtCliente(string codigo, TextBox txtNomeLocacao)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            stringSql = "SELECT NOME FROM clientes where @CODIGO = CODIGO ";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
            conexao.Open();
            comando = new SqlCommand(stringSql, conexao);
            comando.Parameters.AddWithValue("@CODIGO", codigo); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
            dataAdapter = new SqlDataAdapter(comando);
            txtNomeLocacao.Text = (string)comando.ExecuteScalar();
        }




        internal void cadastrarLocacao(string codigo, string retirada, string devolucao, string valor, string obs, string codigoCarro, string modeloCarro, string anoCarro, string obsCarro, string codigoCliente, string nomeCliente, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "IF NOT EXISTS (SELECT CODIGO FROM modelos WHERE CODIGO = @CODIGO)" +
                    "BEGIN INSERT INTO locacao(CODIGO, DATA_RETIRADA, DATA_DEVOLUCAO, VALOR, OBS, CODIGO_CARRO, MODELO_CARRO, ANO_CARRO, OBS_CARRO, CODIGO_CLIENTE, NOME_CLIENTE) VALUES (@CODIGO, @DATA_RETIRADA, @DATA_DEVOLUCAO, @VALOR, @OBS, @CODIGO_CARRO, @MODELO_CARRO, @ANO_CARRO, @OBS_CARRO, @CODIGO_CLIENTE, @NOME_CLIENTE) END";  //STRING SQL PARA INSERIR O REGISTRO NO BANCO DE DADOS CASO O CODIGO NÃO SEJA REPETIDO
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); ; 
                comando.Parameters.AddWithValue("@DATA_RETIRADA", retirada.ToUpper());
                comando.Parameters.AddWithValue("@DATA_DEVOLUCAO", devolucao.ToUpper());
                comando.Parameters.AddWithValue("@VALOR", valor.ToUpper());
                comando.Parameters.AddWithValue("@OBS", obs.ToUpper());
                comando.Parameters.AddWithValue("@CODIGO_CARRO", codigoCarro.ToUpper());
                comando.Parameters.AddWithValue("@MODELO_CARRO", modeloCarro.ToUpper());
                comando.Parameters.AddWithValue("@ANO_CARRO", anoCarro.ToUpper());
                comando.Parameters.AddWithValue("@OBS_CARRO", obsCarro.ToUpper());
                comando.Parameters.AddWithValue("@CODIGO_CLIENTE", codigoCliente.ToUpper());
                comando.Parameters.AddWithValue("@NOME_CLIENTE", nomeCliente.ToUpper());


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
               
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção
            }
            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                atualizarGridLocacao(gridTabela);
            }
        }

        internal void consultarLocacao(string codigo, string retirada, string devolucao, string valor, string obs, string codigoCarro, string codigoCliente, DataGridView gridTabela)
        {
            if (codigo != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO LIKE '{0}'", codigo);
            }
            if (retirada != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_RETIRADA LIKE '%{0}%'", retirada);
}
            if (devolucao != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("DATA_DEVOLUCAO LIKE '%{0}%'", devolucao);
            }
            if (valor != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("VALOR LIKE '%{0}%'", valor);
            }
            if (obs != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("OBS LIKE '%{0}%'", obs);
            }
            if (codigoCarro != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO_CARRO LIKE '%{0}%'", codigoCarro);
            }
            if (codigoCliente != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO_CLIENTE LIKE '{0}'", codigoCliente);
            }
        }



        internal void atualizarLocacao(string codigo, string retirada, string devolucao, string valor, string obs, string codigoCarro, string modeloCarro, string anoCarro, string obsCarro, string codigoCliente, string nomeCliente, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "UPDATE locacao SET CODIGO = @CODIGO, DATA_RETIRADA = @DATA_RETIRADA, DATA_DEVOLUCAO = @DATA_DEVOLUCAO, VALOR = @VALOR, OBS = @OBS, CODIGO_CARRO = @CODIGO_CARRO, MODELO_CARRO = @MODELO_CARRO, ANO_CARRO = @ANO_CARRO, OBS_CARRO = @OBS_CARRO, CODIGO_CLIENTE = @CODIGO_CLIENTE, NOME_CLIENTE = @NOME_CLIENTE WHERE CODIGO = @CODIGO";
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); ;
                comando.Parameters.AddWithValue("@DATA_RETIRADA", retirada.ToUpper());
                comando.Parameters.AddWithValue("@DATA_DEVOLUCAO", devolucao.ToUpper());
                comando.Parameters.AddWithValue("@VALOR", valor.ToUpper());
                comando.Parameters.AddWithValue("@OBS", obs.ToUpper());
                comando.Parameters.AddWithValue("@CODIGO_CARRO", codigoCarro.ToUpper());
                comando.Parameters.AddWithValue("@MODELO_CARRO", modeloCarro.ToUpper());
                comando.Parameters.AddWithValue("@ANO_CARRO", anoCarro.ToUpper());
                comando.Parameters.AddWithValue("@OBS_CARRO", obsCarro.ToUpper());
                comando.Parameters.AddWithValue("@CODIGO_CLIENTE", codigoCliente.ToUpper());
                comando.Parameters.AddWithValue("@NOME_CLIENTE", nomeCliente.ToUpper());


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
            atualizarGridLocacao(gridTabela);
        }



        internal void excluirLocacao(string codigo, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "DELETE FROM locacao WHERE CODIGO = @CODIGO";  //STRING SQL PARA EXCLUIR O REGISTRO NO BANCO DE DADOS QUANDO O CODIGO DIGITADO É IGUAL A ALGUM CODIGO NA TABELA MARCAS
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
            atualizarGridLocacao(gridTabela);
        }


    }
}
