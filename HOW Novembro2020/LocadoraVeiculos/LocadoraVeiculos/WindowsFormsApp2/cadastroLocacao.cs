using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class cadastroLocacao : Form
    {
        public cadastroLocacao()
        {
            InitializeComponent();
        }

        private void cadastroLocacao_Load(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.preencherComboBoxCodigoCliente(cmbClienteLocacao);
            dados.preencherComboBoxCodigoVeiculo(cmbCarroLocacao);
            dados.atualizarGridLocacao(gridTabelaLocacao);
        }

        private void cmbCarroLocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.preencherTxtCarro(cmbCarroLocacao.Text, txtModeloLocacao, txtAnoLocacao, txtObsCarroLocacao);
        }

        private void cmbClienteLocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.preencherTxtCliente(cmbClienteLocacao.Text, txtNomeLocacao);
        }

        private void btn_salvar_locacao_Click(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.cadastrarLocacao(txtCodigoLocacao.Text, txtRetiradaLocacao.Text, txtDevolucaoLocacao.Text, txtValorLocacao.Text, txtObsLocacao.Text, cmbCarroLocacao.Text, txtModeloLocacao.Text, txtAnoLocacao.Text, txtObsCarroLocacao.Text, cmbClienteLocacao.Text, txtNomeLocacao.Text, gridTabelaLocacao);
            txtCodigoLocacao.Text = "";
            txtRetiradaLocacao.Text = "";
            txtDevolucaoLocacao.Text = "";
            txtValorLocacao.Text = "";
            txtObsLocacao.Text = "";
            cmbCarroLocacao.SelectedIndex = -1;
            txtModeloLocacao.Text = "";
            txtAnoLocacao.Text = "";
            txtObsCarroLocacao.Text = "";
            cmbClienteLocacao.SelectedIndex = -1;
            txtNomeLocacao.Text = "";

        }

        private void btn_consultar_locacao_Click(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.consultarLocacao(txtCodigoLocacao.Text, txtRetiradaLocacao.Text, txtDevolucaoLocacao.Text, txtValorLocacao.Text, txtObsLocacao.Text, cmbCarroLocacao.Text, cmbClienteLocacao.Text, gridTabelaLocacao);
            txtCodigoLocacao.Text = "";
            txtRetiradaLocacao.Text = "";
            txtDevolucaoLocacao.Text = "";
            txtValorLocacao.Text = "";
            txtObsLocacao.Text = "";
            cmbCarroLocacao.SelectedIndex = -1;
            txtModeloLocacao.Text = "";
            txtAnoLocacao.Text = "";
            txtObsCarroLocacao.Text = "";
            cmbClienteLocacao.SelectedIndex = -1;
            txtNomeLocacao.Text = "";

        }

        private void btn_modificar_locacao_Click(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.atualizarLocacao(txtCodigoLocacao.Text, txtRetiradaLocacao.Text, txtDevolucaoLocacao.Text, txtValorLocacao.Text, txtObsLocacao.Text, cmbCarroLocacao.Text, txtModeloLocacao.Text, txtAnoLocacao.Text, txtObsCarroLocacao.Text, cmbClienteLocacao.Text, txtNomeLocacao.Text, gridTabelaLocacao);
            txtCodigoLocacao.Text = "";
            txtRetiradaLocacao.Text = "";
            txtDevolucaoLocacao.Text = "";
            txtValorLocacao.Text = "";
            txtObsLocacao.Text = "";
            cmbCarroLocacao.SelectedIndex = -1;
            txtModeloLocacao.Text = "";
            txtAnoLocacao.Text = "";
            txtObsCarroLocacao.Text = "";
            cmbClienteLocacao.SelectedIndex = -1;
            txtNomeLocacao.Text = "";
        }

        private void btn_excluir_locacao_Click(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.excluirLocacao(txtCodigoLocacao.Text.ToUpper(), gridTabelaLocacao);
            txtCodigoLocacao.Text = "";
            txtRetiradaLocacao.Text = "";
            txtDevolucaoLocacao.Text = "";
            txtValorLocacao.Text = "";
            txtObsLocacao.Text = "";
            cmbCarroLocacao.SelectedIndex = -1;
            txtModeloLocacao.Text = "";
            txtAnoLocacao.Text = "";
            txtObsCarroLocacao.Text = "";
            cmbClienteLocacao.SelectedIndex = -1;
            txtNomeLocacao.Text = "";
        }

        private void btn_limpar_consulta_locacao_Click(object sender, EventArgs e)
        {
            Locacao dados = new Locacao();
            dados.atualizarGridLocacao(gridTabelaLocacao);
            txtCodigoLocacao.Text = "";
            txtRetiradaLocacao.Text = "";
            txtDevolucaoLocacao.Text = "";
            txtValorLocacao.Text = "";
            txtObsLocacao.Text = "";
            cmbCarroLocacao.SelectedIndex = -1;
            txtModeloLocacao.Text = "";
            txtAnoLocacao.Text = "";
            txtObsCarroLocacao.Text = "";
            cmbClienteLocacao.SelectedIndex = -1;
            txtNomeLocacao.Text = "";
        }
    }
}
