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
    public partial class cadastroMarca : Form
    {
        public cadastroMarca()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.cadastrarMarca(txtCodigo.Text.ToUpper(), txtDescricao.Text.ToUpper(), gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";

        }

        private void gridTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastroMarca_Load(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.atualizaGrid(gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.excluirMarca(txtCodigo.Text.ToUpper(), gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.consultarMarca(txtCodigo.Text.ToUpper(), txtDescricao.Text.ToUpper(), gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.atualizarMarca(txtCodigo.Text.ToUpper(), txtDescricao.Text.ToUpper(), gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";
        }

        private void btn_limpar_consulta_marca_Click(object sender, EventArgs e)
        {
            Marca dados = new Marca();
            dados.atualizaGrid(gridTabela);
            txtCodigo.Text = "";
            txtDescricao.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
