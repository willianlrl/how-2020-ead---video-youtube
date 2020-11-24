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
    class Veiculo
    {



        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string stringSql;
        //Essas 5 linhas acima são as variáveis para facilitar durante o processo de utilização do SQL.



        //declaração de variável + getters e setters
        private string codigo;

        
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string ano;

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }


        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        private string obs;

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }


        //popula o combobox de marcas
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


        //popula o combobox de modelos

        internal void preencherComboBoxModelos(ComboBox cmbModelo, string marca)
        {
            conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
            conexao.Open();
            stringSql = "SELECT descricao FROM modelos where @MARCA = MARCA";  //STRING SQL PARA ATUALIZAR O REGISTRO NO BANCO DE DADOS QUANDO O ID DIGITADO É IGUAL A ALGUM ID NA BASE DE DADOS
            comando = new SqlCommand(stringSql, conexao);
            comando.Parameters.AddWithValue("@MARCA", marca.ToUpper());
            dataAdapter = new SqlDataAdapter(comando);
            DataTable tabela = new DataTable();  //instancia de uma nova tabela
            dataAdapter.Fill(tabela); //preenche a tabela
            cmbModelo.DataSource = tabela; //informa que a fonte de dados para o combobox será a tabela gerada neste método
            cmbModelo.DisplayMember = "descricao"; //seleciona o display com os dados de descrição da tabela marcas
            cmbModelo.SelectedIndex = -1;  //deixar o combobox limpo, sem nenhuma opção selecionada ao ser carregado
            conexao.Close();
        }

        
        //atualiza a tabela de veiculos cadastrados listada no módulo de cadastro de veiculos
        internal void atualizarGridVeiculo(DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "SELECT MARCA, MODELO, DESCRICAO, CODIGO, ANO, COR, OBS FROM veiculos";  //STRING SQL PARA SELECIONAR OS REGISTROS NO BANCO DE DADOS 
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



        //cadastrar veiculo
        internal void cadastrarVeiculo(string codigo, string ano, string cor, string descricao, string obs, string marca, string modelo, DataGridView gridTabelaVeiculo)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "IF NOT EXISTS (SELECT CODIGO FROM modelos WHERE CODIGO = @CODIGO)" +
                    "BEGIN INSERT INTO veiculos(CODIGO, ANO, COR, DESCRICAO, OBS, MARCA, MODELO) VALUES (@CODIGO, @ANO, @COR, @DESCRICAO, @OBS, @MARCA, @MODELO) END";  //STRING SQL PARA INSERIR O REGISTRO NO BANCO DE DADOS CASO O CODIGO NÃO SEJA REPETIDO
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
                comando.Parameters.AddWithValue("@DESCRICAO", descricao.ToUpper());//adiciona o valor digitado no campo txtdescricao para a variavel @descricao
                comando.Parameters.AddWithValue("@MARCA", marca.ToUpper());//adiciona o valor digitado no campo txtMarca para a variavel @MARCA
                comando.Parameters.AddWithValue("@ANO", ano.ToUpper());
                comando.Parameters.AddWithValue("@COR", cor.ToUpper());
                comando.Parameters.AddWithValue("@OBS", obs.ToUpper());
                comando.Parameters.AddWithValue("@MODELO", modelo.ToUpper());


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
                atualizarGridVeiculo(gridTabelaVeiculo);
            }
        }


        internal void consultarVeiculo(string codigo, string descricao, string ano, string cor, string obs, string marca, string modelo, DataGridView gridTabela)
        {
            if (codigo != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("CODIGO LIKE '%{0}%'", codigo); 
            }
            if (descricao != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("DESCRICAO LIKE '%{0}%'", descricao); 
            }
            if (ano != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("ANO LIKE '%{0}%'", ano); 
            }
            if (cor != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("COR LIKE '%{0}%'", cor); 
            }
            if (obs != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("OBS LIKE '%{0}%'", obs);
            }
            if (marca != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("MARCA LIKE '%{0}%'", marca);
            }

            if (modelo != "")
            {
                (gridTabela.DataSource as DataTable).DefaultView.RowFilter = string.Format("MODELO LIKE '%{0}%'", modelo);
            }

        }



        internal void atualizarVeiculo(string codigo, string descricao, string ano, string cor, string obs, string marca, string modelo, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "UPDATE veiculos SET CODIGO = @CODIGO, DESCRICAO = @DESCRICAO, MARCA = @MARCA, ANO = @ANO, COR = @COR, OBS = @OBS, MODELO = @MODELO WHERE CODIGO = @CODIGO";  //STRING SQL PARA ATUALIZAR O REGISTRO NO BANCO DE DADOS QUANDO O ID DIGITADO É IGUAL A ALGUM ID NA BASE DE DADOS
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@CODIGO", codigo.ToUpper()); //adiciona o valor digitado no campo txtcodigo para a variavel @codigo
                comando.Parameters.AddWithValue("@DESCRICAO", descricao.ToUpper());//adiciona o valor digitado no campo txtdescricao para a variavel @descricao
                comando.Parameters.AddWithValue("@MARCA", marca.ToUpper());//adiciona o valor digitado no campo txtMarca para a variavel @MARCA
                comando.Parameters.AddWithValue("@ANO", ano.ToUpper());
                comando.Parameters.AddWithValue("@COR", cor.ToUpper());
                comando.Parameters.AddWithValue("@OBS", obs.ToUpper());
                comando.Parameters.AddWithValue("@MODELO", modelo.ToUpper());

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
            atualizarGridVeiculo(gridTabela);
        }


        internal void excluirVeiculo(string codigo, DataGridView gridTabela)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\LocadoraVeiculos\locadoraDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "DELETE FROM veiculos WHERE CODIGO = @CODIGO";  //STRING SQL PARA EXCLUIR O REGISTRO NO BANCO DE DADOS QUANDO O CODIGO DIGITADO É IGUAL A ALGUM CODIGO NA TABELA MARCAS
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
            atualizarGridVeiculo(gridTabela);
        }

    }
    

}
