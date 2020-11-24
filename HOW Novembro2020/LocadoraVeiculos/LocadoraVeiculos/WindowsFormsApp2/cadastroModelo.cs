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
    public partial class cadastroModelo : Form
    {
        public cadastroModelo()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void cadastroModelo_Load(object sender, EventArgs e)
        {
            Modelo dados = new Modelo();
            dados.preencherComboBoxMarcas(cmbMarca);
            dados.atualizarGridModelo(gridTabelaModelo);
        }

        private void btn_salvar_modelo_Click(object sender, EventArgs e)
        {
            Modelo dados = new Modelo();
            dados.cadastrarModelo(txtCodigoModelo.Text.ToUpper(), txtDescricaoModelo.Text.ToUpper(), cmbMarca.Text, gridTabelaModelo);
            dados.atualizarGridModelo(gridTabelaModelo);
            txtCodigoModelo.Text = "";
            txtDescricaoModelo.Text = "";
            cmbMarca.SelectedIndex = -1;
        }

        private void btn_consultar_modelo_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.consultarMarca(txtCodigoModelo.Text.ToUpper(), txtDescricaoModelo.Text.ToUpper(), gridTabelaModelo);
            txtCodigoModelo.Text = "";
            txtDescricaoModelo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelo dados = new Modelo();
            dados.atualizarGridModelo(gridTabelaModelo);
            txtCodigoModelo.Text = "";
            txtDescricaoModelo.Text = "";
        }

        private void btn_modificar_modelo_Click(object sender, EventArgs e)
        {
            Modelo dados = new Modelo();
            dados.atualizarModelo(txtCodigoModelo.Text.ToUpper(), txtDescricaoModelo.Text.ToUpper(), cmbMarca.Text, gridTabelaModelo);
            txtCodigoModelo.Text = "";
            txtDescricaoModelo.Text = "";
        }

        private void btn_excluir_modelo_Click(object sender, EventArgs e)
        {
            Modelo dados = new Modelo();
            dados.excluirModelo(txtCodigoModelo.Text.ToUpper(), gridTabelaModelo);
            txtCodigoModelo.Text = "";
            txtDescricaoModelo.Text = "";
        }

        private void gridTabelaModelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
