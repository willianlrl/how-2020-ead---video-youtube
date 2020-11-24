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
    public partial class cadastroVeiculo : Form
    {
        public cadastroVeiculo()
        {
            InitializeComponent();
        }

        private void cadastroVeiculo_Load(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.preencherComboBoxMarcas(cmbMarcaVeiculo);
            dados.atualizarGridVeiculo(gridTabelaVeiculo);
        }

            private void cmbMarcaVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarcaVeiculo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.preencherComboBoxModelos(cmbModeloVeiculo, cmbMarcaVeiculo.Text);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.cadastrarVeiculo(txtCodigoVeiculo.Text, txtAnoVeiculo.Text, txtCorVeiculo.Text, txtDescricaoVeiculo.Text, txtObsVeiculo.Text, cmbMarcaVeiculo.Text, cmbModeloVeiculo.Text, gridTabelaVeiculo);
            txtCodigoVeiculo.Text = "";
            txtAnoVeiculo.Text = "";
            txtCorVeiculo.Text = "";
            txtDescricaoVeiculo.Text = "";
            txtObsVeiculo.Text = "";
            cmbModeloVeiculo.SelectedIndex = -1;
            cmbMarcaVeiculo.SelectedIndex = -1;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.consultarVeiculo(txtCodigoVeiculo.Text, txtDescricaoVeiculo.Text, txtAnoVeiculo.Text, txtCorVeiculo.Text, txtObsVeiculo.Text, cmbMarcaVeiculo.Text, cmbModeloVeiculo.Text, gridTabelaVeiculo);
        }

        private void btn_limpar_consulta_Click(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.atualizarGridVeiculo(gridTabelaVeiculo);
            txtCodigoVeiculo.Text = "";
            txtAnoVeiculo.Text = "";
            txtCorVeiculo.Text = "";
            txtDescricaoVeiculo.Text = "";
            txtObsVeiculo.Text = "";
            cmbModeloVeiculo.SelectedIndex = -1;
            cmbMarcaVeiculo.SelectedIndex = -1;
            
        }

        private void btn_modificar_veiculo_Click(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.atualizarVeiculo(txtCodigoVeiculo.Text.ToUpper(), txtDescricaoVeiculo.Text.ToUpper(), txtAnoVeiculo.Text.ToUpper(), txtCorVeiculo.Text.ToUpper(), txtObsVeiculo.Text.ToUpper(), cmbMarcaVeiculo.Text, cmbModeloVeiculo.Text, gridTabelaVeiculo);
            txtCodigoVeiculo.Text = "";
            txtDescricaoVeiculo.Text = "";
            txtAnoVeiculo.Text = "";
            txtCorVeiculo.Text = "";
            txtObsVeiculo.Text = "";
            cmbModeloVeiculo.SelectedIndex = -1;
            cmbMarcaVeiculo.SelectedIndex = -1;
        }

        private void btn_excluir_veiculo_Click(object sender, EventArgs e)
        {
            Veiculo dados = new Veiculo();
            dados.excluirVeiculo(txtCodigoVeiculo.Text.ToUpper(), gridTabelaVeiculo);
            txtCodigoVeiculo.Text = "";
        }
    }
}
