namespace WindowsFormsApp2
{
    partial class cadastroMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroMarca));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_consultar_marca = new System.Windows.Forms.Button();
            this.btn_salvar_marca = new System.Windows.Forms.Button();
            this.gridTabela = new System.Windows.Forms.DataGridView();
            this.btn_excluir_marca = new System.Windows.Forms.Button();
            this.btn_modificar_marca = new System.Windows.Forms.Button();
            this.btn_limpar_consulta_marca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(430, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(220, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(760, 79);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(220, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CADASTRO DE MARCAS";
            // 
            // btn_consultar_marca
            // 
            this.btn_consultar_marca.Location = new System.Drawing.Point(521, 153);
            this.btn_consultar_marca.Name = "btn_consultar_marca";
            this.btn_consultar_marca.Size = new System.Drawing.Size(83, 23);
            this.btn_consultar_marca.TabIndex = 4;
            this.btn_consultar_marca.Text = "CONSULTAR";
            this.btn_consultar_marca.UseVisualStyleBackColor = true;
            this.btn_consultar_marca.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salvar_marca
            // 
            this.btn_salvar_marca.Location = new System.Drawing.Point(431, 153);
            this.btn_salvar_marca.Name = "btn_salvar_marca";
            this.btn_salvar_marca.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_marca.TabIndex = 3;
            this.btn_salvar_marca.Text = "SALVAR";
            this.btn_salvar_marca.UseVisualStyleBackColor = true;
            this.btn_salvar_marca.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // gridTabela
            // 
            this.gridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabela.Location = new System.Drawing.Point(12, 205);
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.Size = new System.Drawing.Size(1329, 435);
            this.gridTabela.TabIndex = 8;
            this.gridTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTabela_CellContentClick);
            // 
            // btn_excluir_marca
            // 
            this.btn_excluir_marca.Location = new System.Drawing.Point(852, 153);
            this.btn_excluir_marca.Name = "btn_excluir_marca";
            this.btn_excluir_marca.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_marca.TabIndex = 7;
            this.btn_excluir_marca.Text = "EXCLUIR";
            this.btn_excluir_marca.UseVisualStyleBackColor = true;
            this.btn_excluir_marca.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_modificar_marca
            // 
            this.btn_modificar_marca.Location = new System.Drawing.Point(760, 153);
            this.btn_modificar_marca.Name = "btn_modificar_marca";
            this.btn_modificar_marca.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_marca.TabIndex = 6;
            this.btn_modificar_marca.Text = "MODIFICAR";
            this.btn_modificar_marca.UseVisualStyleBackColor = true;
            this.btn_modificar_marca.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_limpar_consulta_marca
            // 
            this.btn_limpar_consulta_marca.Location = new System.Drawing.Point(619, 153);
            this.btn_limpar_consulta_marca.Name = "btn_limpar_consulta_marca";
            this.btn_limpar_consulta_marca.Size = new System.Drawing.Size(126, 23);
            this.btn_limpar_consulta_marca.TabIndex = 5;
            this.btn_limpar_consulta_marca.Text = "LIMPAR CONSULTA";
            this.btn_limpar_consulta_marca.UseVisualStyleBackColor = true;
            this.btn_limpar_consulta_marca.Click += new System.EventHandler(this.btn_limpar_consulta_marca_Click);
            // 
            // cadastroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 652);
            this.Controls.Add(this.btn_limpar_consulta_marca);
            this.Controls.Add(this.btn_modificar_marca);
            this.Controls.Add(this.btn_excluir_marca);
            this.Controls.Add(this.gridTabela);
            this.Controls.Add(this.btn_salvar_marca);
            this.Controls.Add(this.btn_consultar_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroMarca";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Marca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_consultar_marca;
        private System.Windows.Forms.Button btn_salvar_marca;
        internal System.Windows.Forms.DataGridView gridTabela;
        private System.Windows.Forms.Button btn_excluir_marca;
        private System.Windows.Forms.Button btn_modificar_marca;
        private System.Windows.Forms.Button btn_limpar_consulta_marca;
    }
}