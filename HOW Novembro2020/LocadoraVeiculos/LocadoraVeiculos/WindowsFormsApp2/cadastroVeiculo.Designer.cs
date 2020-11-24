namespace WindowsFormsApp2
{
    partial class cadastroVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.gridTabelaVeiculo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorVeiculo = new System.Windows.Forms.TextBox();
            this.txtDescricaoVeiculo = new System.Windows.Forms.TextBox();
            this.txtObsVeiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModeloVeiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMarcaVeiculo = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_limpar_consulta = new System.Windows.Forms.Button();
            this.btn_modificar_veiculo = new System.Windows.Forms.Button();
            this.btn_excluir_veiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE VEÍCULOS";
            // 
            // gridTabelaVeiculo
            // 
            this.gridTabelaVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabelaVeiculo.Location = new System.Drawing.Point(12, 205);
            this.gridTabelaVeiculo.Name = "gridTabelaVeiculo";
            this.gridTabelaVeiculo.Size = new System.Drawing.Size(1493, 535);
            this.gridTabelaVeiculo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CÓDIGO";
            // 
            // txtCodigoVeiculo
            // 
            this.txtCodigoVeiculo.Location = new System.Drawing.Point(342, 72);
            this.txtCodigoVeiculo.Name = "txtCodigoVeiculo";
            this.txtCodigoVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVeiculo.TabIndex = 1;
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(496, 72);
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtAnoVeiculo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ANO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "COR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "OBSERVAÇÃO";
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.Location = new System.Drawing.Point(648, 72);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtCorVeiculo.TabIndex = 3;
            // 
            // txtDescricaoVeiculo
            // 
            this.txtDescricaoVeiculo.Location = new System.Drawing.Point(661, 103);
            this.txtDescricaoVeiculo.Name = "txtDescricaoVeiculo";
            this.txtDescricaoVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoVeiculo.TabIndex = 6;
            // 
            // txtObsVeiculo
            // 
            this.txtObsVeiculo.Location = new System.Drawing.Point(875, 103);
            this.txtObsVeiculo.Name = "txtObsVeiculo";
            this.txtObsVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtObsVeiculo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "MODELO";
            // 
            // cmbModeloVeiculo
            // 
            this.cmbModeloVeiculo.FormattingEnabled = true;
            this.cmbModeloVeiculo.Location = new System.Drawing.Point(449, 102);
            this.cmbModeloVeiculo.Name = "cmbModeloVeiculo";
            this.cmbModeloVeiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbModeloVeiculo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(767, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "MARCA";
            // 
            // cmbMarcaVeiculo
            // 
            this.cmbMarcaVeiculo.FormattingEnabled = true;
            this.cmbMarcaVeiculo.Location = new System.Drawing.Point(818, 71);
            this.cmbMarcaVeiculo.Name = "cmbMarcaVeiculo";
            this.cmbMarcaVeiculo.Size = new System.Drawing.Size(100, 21);
            this.cmbMarcaVeiculo.TabIndex = 4;
            this.cmbMarcaVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaVeiculo_SelectedIndexChanged_1);
            this.cmbMarcaVeiculo.SelectedValueChanged += new System.EventHandler(this.cmbMarcaVeiculo_SelectedIndexChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(431, 153);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(521, 153);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(83, 23);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "CONSULTAR";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_limpar_consulta
            // 
            this.btn_limpar_consulta.Location = new System.Drawing.Point(619, 153);
            this.btn_limpar_consulta.Name = "btn_limpar_consulta";
            this.btn_limpar_consulta.Size = new System.Drawing.Size(126, 23);
            this.btn_limpar_consulta.TabIndex = 10;
            this.btn_limpar_consulta.Text = "LIMPAR CONSULTA";
            this.btn_limpar_consulta.UseVisualStyleBackColor = true;
            this.btn_limpar_consulta.Click += new System.EventHandler(this.btn_limpar_consulta_Click);
            // 
            // btn_modificar_veiculo
            // 
            this.btn_modificar_veiculo.Location = new System.Drawing.Point(760, 153);
            this.btn_modificar_veiculo.Name = "btn_modificar_veiculo";
            this.btn_modificar_veiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_veiculo.TabIndex = 11;
            this.btn_modificar_veiculo.Text = "MODIFICAR";
            this.btn_modificar_veiculo.UseVisualStyleBackColor = true;
            this.btn_modificar_veiculo.Click += new System.EventHandler(this.btn_modificar_veiculo_Click);
            // 
            // btn_excluir_veiculo
            // 
            this.btn_excluir_veiculo.Location = new System.Drawing.Point(852, 153);
            this.btn_excluir_veiculo.Name = "btn_excluir_veiculo";
            this.btn_excluir_veiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_veiculo.TabIndex = 12;
            this.btn_excluir_veiculo.Text = "EXCLUIR";
            this.btn_excluir_veiculo.UseVisualStyleBackColor = true;
            this.btn_excluir_veiculo.Click += new System.EventHandler(this.btn_excluir_veiculo_Click);
            // 
            // cadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 740);
            this.Controls.Add(this.btn_excluir_veiculo);
            this.Controls.Add(this.btn_modificar_veiculo);
            this.Controls.Add(this.btn_limpar_consulta);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cmbMarcaVeiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbModeloVeiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObsVeiculo);
            this.Controls.Add(this.txtDescricaoVeiculo);
            this.Controls.Add(this.txtCorVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.txtCodigoVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridTabelaVeiculo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroVeiculo";
            this.Text = "Cadastrar Veículo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTabelaVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoVeiculo;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorVeiculo;
        private System.Windows.Forms.TextBox txtDescricaoVeiculo;
        private System.Windows.Forms.TextBox txtObsVeiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbModeloVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMarcaVeiculo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_limpar_consulta;
        private System.Windows.Forms.Button btn_modificar_veiculo;
        private System.Windows.Forms.Button btn_excluir_veiculo;
    }
}