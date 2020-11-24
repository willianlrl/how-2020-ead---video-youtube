namespace WindowsFormsApp2
{
    partial class cadastroLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroLocacao));
            this.gridTabelaLocacao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoLocacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCarroLocacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClienteLocacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRetiradaLocacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDevolucaoLocacao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorLocacao = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObsLocacao = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModeloLocacao = new System.Windows.Forms.TextBox();
            this.txtAnoLocacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObsCarroLocacao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeLocacao = new System.Windows.Forms.TextBox();
            this.btn_salvar_locacao = new System.Windows.Forms.Button();
            this.btn_consultar_locacao = new System.Windows.Forms.Button();
            this.btn_limpar_consulta_locacao = new System.Windows.Forms.Button();
            this.btn_excluir_locacao = new System.Windows.Forms.Button();
            this.btn_modificar_locacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTabelaLocacao
            // 
            this.gridTabelaLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabelaLocacao.Location = new System.Drawing.Point(12, 263);
            this.gridTabelaLocacao.Name = "gridTabelaLocacao";
            this.gridTabelaLocacao.Size = new System.Drawing.Size(1329, 435);
            this.gridTabelaLocacao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO LOCAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CÓDIGO";
            // 
            // txtCodigoLocacao
            // 
            this.txtCodigoLocacao.Location = new System.Drawing.Point(144, 58);
            this.txtCodigoLocacao.Name = "txtCodigoLocacao";
            this.txtCodigoLocacao.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLocacao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CÓDIGO DO CARRO";
            // 
            // cmbCarroLocacao
            // 
            this.cmbCarroLocacao.FormattingEnabled = true;
            this.cmbCarroLocacao.Location = new System.Drawing.Point(144, 98);
            this.cmbCarroLocacao.Name = "cmbCarroLocacao";
            this.cmbCarroLocacao.Size = new System.Drawing.Size(121, 21);
            this.cmbCarroLocacao.TabIndex = 2;
            this.cmbCarroLocacao.SelectedIndexChanged += new System.EventHandler(this.cmbCarroLocacao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CÓDIGO DO CLIENTE";
            // 
            // cmbClienteLocacao
            // 
            this.cmbClienteLocacao.FormattingEnabled = true;
            this.cmbClienteLocacao.Location = new System.Drawing.Point(144, 136);
            this.cmbClienteLocacao.Name = "cmbClienteLocacao";
            this.cmbClienteLocacao.Size = new System.Drawing.Size(121, 21);
            this.cmbClienteLocacao.TabIndex = 3;
            this.cmbClienteLocacao.SelectedIndexChanged += new System.EventHandler(this.cmbClienteLocacao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATA DA RETIRADA";
            // 
            // txtRetiradaLocacao
            // 
            this.txtRetiradaLocacao.Location = new System.Drawing.Point(428, 58);
            this.txtRetiradaLocacao.Mask = "00/00/00";
            this.txtRetiradaLocacao.Name = "txtRetiradaLocacao";
            this.txtRetiradaLocacao.Size = new System.Drawing.Size(64, 20);
            this.txtRetiradaLocacao.TabIndex = 4;
            this.txtRetiradaLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDevolucaoLocacao
            // 
            this.txtDevolucaoLocacao.Location = new System.Drawing.Point(689, 58);
            this.txtDevolucaoLocacao.Mask = "00/00/00";
            this.txtDevolucaoLocacao.Name = "txtDevolucaoLocacao";
            this.txtDevolucaoLocacao.Size = new System.Drawing.Size(64, 20);
            this.txtDevolucaoLocacao.TabIndex = 5;
            this.txtDevolucaoLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DATA DE DEVOLUÇÃO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(836, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "R$";
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.Location = new System.Drawing.Point(863, 58);
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(100, 20);
            this.txtValorLocacao.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1012, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "OBSERVAÇÕES";
            // 
            // txtObsLocacao
            // 
            this.txtObsLocacao.Location = new System.Drawing.Point(1105, 56);
            this.txtObsLocacao.Name = "txtObsLocacao";
            this.txtObsLocacao.Size = new System.Drawing.Size(236, 143);
            this.txtObsLocacao.TabIndex = 7;
            this.txtObsLocacao.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "MODELO";
            // 
            // txtModeloLocacao
            // 
            this.txtModeloLocacao.Location = new System.Drawing.Point(373, 98);
            this.txtModeloLocacao.Name = "txtModeloLocacao";
            this.txtModeloLocacao.ReadOnly = true;
            this.txtModeloLocacao.Size = new System.Drawing.Size(100, 20);
            this.txtModeloLocacao.TabIndex = 33;
            this.txtModeloLocacao.TabStop = false;
            // 
            // txtAnoLocacao
            // 
            this.txtAnoLocacao.Location = new System.Drawing.Point(538, 98);
            this.txtAnoLocacao.Name = "txtAnoLocacao";
            this.txtAnoLocacao.ReadOnly = true;
            this.txtAnoLocacao.Size = new System.Drawing.Size(100, 20);
            this.txtAnoLocacao.TabIndex = 18;
            this.txtAnoLocacao.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ANO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "OBSERVAÇÃO";
            // 
            // txtObsCarroLocacao
            // 
            this.txtObsCarroLocacao.Location = new System.Drawing.Point(786, 102);
            this.txtObsCarroLocacao.Name = "txtObsCarroLocacao";
            this.txtObsCarroLocacao.ReadOnly = true;
            this.txtObsCarroLocacao.Size = new System.Drawing.Size(236, 20);
            this.txtObsCarroLocacao.TabIndex = 21;
            this.txtObsCarroLocacao.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(316, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "NOME";
            // 
            // txtNomeLocacao
            // 
            this.txtNomeLocacao.Location = new System.Drawing.Point(361, 137);
            this.txtNomeLocacao.Name = "txtNomeLocacao";
            this.txtNomeLocacao.ReadOnly = true;
            this.txtNomeLocacao.Size = new System.Drawing.Size(300, 20);
            this.txtNomeLocacao.TabIndex = 23;
            this.txtNomeLocacao.TabStop = false;
            // 
            // btn_salvar_locacao
            // 
            this.btn_salvar_locacao.Location = new System.Drawing.Point(168, 202);
            this.btn_salvar_locacao.Name = "btn_salvar_locacao";
            this.btn_salvar_locacao.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_locacao.TabIndex = 8;
            this.btn_salvar_locacao.Text = "SALVAR";
            this.btn_salvar_locacao.UseVisualStyleBackColor = true;
            this.btn_salvar_locacao.Click += new System.EventHandler(this.btn_salvar_locacao_Click);
            // 
            // btn_consultar_locacao
            // 
            this.btn_consultar_locacao.Location = new System.Drawing.Point(291, 202);
            this.btn_consultar_locacao.Name = "btn_consultar_locacao";
            this.btn_consultar_locacao.Size = new System.Drawing.Size(91, 23);
            this.btn_consultar_locacao.TabIndex = 9;
            this.btn_consultar_locacao.Text = "CONSULTAR";
            this.btn_consultar_locacao.UseVisualStyleBackColor = true;
            this.btn_consultar_locacao.Click += new System.EventHandler(this.btn_consultar_locacao_Click);
            // 
            // btn_limpar_consulta_locacao
            // 
            this.btn_limpar_consulta_locacao.Location = new System.Drawing.Point(482, 202);
            this.btn_limpar_consulta_locacao.Name = "btn_limpar_consulta_locacao";
            this.btn_limpar_consulta_locacao.Size = new System.Drawing.Size(228, 23);
            this.btn_limpar_consulta_locacao.TabIndex = 10;
            this.btn_limpar_consulta_locacao.Text = "LIMPAR CONSULTA";
            this.btn_limpar_consulta_locacao.UseVisualStyleBackColor = true;
            this.btn_limpar_consulta_locacao.Click += new System.EventHandler(this.btn_limpar_consulta_locacao_Click);
            // 
            // btn_excluir_locacao
            // 
            this.btn_excluir_locacao.Location = new System.Drawing.Point(931, 202);
            this.btn_excluir_locacao.Name = "btn_excluir_locacao";
            this.btn_excluir_locacao.Size = new System.Drawing.Size(91, 23);
            this.btn_excluir_locacao.TabIndex = 12;
            this.btn_excluir_locacao.Text = "EXCLUIR";
            this.btn_excluir_locacao.UseVisualStyleBackColor = true;
            this.btn_excluir_locacao.Click += new System.EventHandler(this.btn_excluir_locacao_Click);
            // 
            // btn_modificar_locacao
            // 
            this.btn_modificar_locacao.Location = new System.Drawing.Point(786, 202);
            this.btn_modificar_locacao.Name = "btn_modificar_locacao";
            this.btn_modificar_locacao.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_locacao.TabIndex = 11;
            this.btn_modificar_locacao.Text = "MODIFICAR";
            this.btn_modificar_locacao.UseVisualStyleBackColor = true;
            this.btn_modificar_locacao.Click += new System.EventHandler(this.btn_modificar_locacao_Click);
            // 
            // cadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 710);
            this.Controls.Add(this.btn_excluir_locacao);
            this.Controls.Add(this.btn_modificar_locacao);
            this.Controls.Add(this.btn_limpar_consulta_locacao);
            this.Controls.Add(this.btn_consultar_locacao);
            this.Controls.Add(this.btn_salvar_locacao);
            this.Controls.Add(this.txtNomeLocacao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtObsCarroLocacao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAnoLocacao);
            this.Controls.Add(this.txtModeloLocacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObsLocacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDevolucaoLocacao);
            this.Controls.Add(this.txtRetiradaLocacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClienteLocacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCarroLocacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoLocacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTabelaLocacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroLocacao";
            this.Text = "Cadastro Locação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTabelaLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoLocacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCarroLocacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClienteLocacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtRetiradaLocacao;
        private System.Windows.Forms.MaskedTextBox txtDevolucaoLocacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtValorLocacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtObsLocacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModeloLocacao;
        private System.Windows.Forms.TextBox txtAnoLocacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtObsCarroLocacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeLocacao;
        private System.Windows.Forms.Button btn_salvar_locacao;
        private System.Windows.Forms.Button btn_consultar_locacao;
        private System.Windows.Forms.Button btn_limpar_consulta_locacao;
        private System.Windows.Forms.Button btn_excluir_locacao;
        private System.Windows.Forms.Button btn_modificar_locacao;
    }
}