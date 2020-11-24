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
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.atualizarGridCliente(gridTabelaCliente);
        }

        private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.cadastrarCliente(txtCodigoCliente.Text.ToUpper(), txtNomeCliente.Text.ToUpper(), txtEmailCliente.Text.ToUpper(), txtSenhaCliente.Text.ToUpper(), gridTabelaCliente);
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtSenhaCliente.Text = "";
        }

        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.consultarCliente(txtCodigoCliente.Text, txtNomeCliente.Text, txtEmailCliente.Text, txtSenhaCliente.Text, gridTabelaCliente);
        }

        private void btn_limpar_consulta_cliente_Click(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.atualizarGridCliente(gridTabelaCliente);
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtSenhaCliente.Text = "";
        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.atualizarCliente(txtCodigoCliente.Text.ToUpper(), txtNomeCliente.Text.ToUpper(),txtEmailCliente.Text.ToUpper(), txtSenhaCliente.Text.ToUpper(), gridTabelaCliente);
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtSenhaCliente.Text = "";
        }

        private void btn_excluir_cliente_Click(object sender, EventArgs e)
        {
            Cliente dados = new Cliente();
            dados.excluirCliente(txtCodigoCliente.Text.ToUpper(), gridTabelaCliente);
            txtCodigoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtEmailCliente.Text = "";
            txtSenhaCliente.Text = "";
        }
    }
}
