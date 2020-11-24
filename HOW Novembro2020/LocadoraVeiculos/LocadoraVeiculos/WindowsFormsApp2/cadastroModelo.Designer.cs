namespace WindowsFormsApp2
{
    partial class cadastroModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroModelo));
            this.txtCodigoModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoModelo = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridTabelaModelo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salvar_modelo = new System.Windows.Forms.Button();
            this.btn_consultar_modelo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_modificar_marca = new System.Windows.Forms.Button();
            this.btn_excluir_modelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoModelo
            // 
            this.txtCodigoModelo.Location = new System.Drawing.Point(282, 80);
            this.txtCodigoModelo.Name = "txtCodigoModelo";
            this.txtCodigoModelo.Size = new System.Drawing.Size(224, 20);
            this.txtCodigoModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // txtDescricaoModelo
            // 
            this.txtDescricaoModelo.Location = new System.Drawing.Point(597, 80);
            this.txtDescricaoModelo.Name = "txtDescricaoModelo";
            this.txtDescricaoModelo.Size = new System.Drawing.Size(224, 20);
            this.txtDescricaoModelo.TabIndex = 2;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(888, 79);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(245, 21);
            this.cmbMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MARCA";
            // 
            // gridTabelaModelo
            // 
            this.gridTabelaModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabelaModelo.Location = new System.Drawing.Point(12, 205);
            this.gridTabelaModelo.Name = "gridTabelaModelo";
            this.gridTabelaModelo.Size = new System.Drawing.Size(1329, 435);
            this.gridTabelaModelo.TabIndex = 9;
            this.gridTabelaModelo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTabelaModelo_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CADASTRO DE MODELOS";
            // 
            // btn_salvar_modelo
            // 
            this.btn_salvar_modelo.Location = new System.Drawing.Point(431, 153);
            this.btn_salvar_modelo.Name = "btn_salvar_modelo";
            this.btn_salvar_modelo.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_modelo.TabIndex = 4;
            this.btn_salvar_modelo.Text = "SALVAR";
            this.btn_salvar_modelo.UseVisualStyleBackColor = true;
            this.btn_salvar_modelo.Click += new System.EventHandler(this.btn_salvar_modelo_Click);
            // 
            // btn_consultar_modelo
            // 
            this.btn_consultar_modelo.Location = new System.Drawing.Point(521, 153);
            this.btn_consultar_modelo.Name = "btn_consultar_modelo";
            this.btn_consultar_modelo.Size = new System.Drawing.Size(83, 23);
            this.btn_consultar_modelo.TabIndex = 5;
            this.btn_consultar_modelo.Text = "CONSULTAR";
            this.btn_consultar_modelo.UseVisualStyleBackColor = true;
            this.btn_consultar_modelo.Click += new System.EventHandler(this.btn_consultar_modelo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "LIMPAR CONSULTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_modificar_marca
            // 
            this.btn_modificar_marca.Location = new System.Drawing.Point(760, 153);
            this.btn_modificar_marca.Name = "btn_modificar_marca";
            this.btn_modificar_marca.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_marca.TabIndex = 7;
            this.btn_modificar_marca.Text = "MODIFICAR";
            this.btn_modificar_marca.UseVisualStyleBackColor = true;
            this.btn_modificar_marca.Click += new System.EventHandler(this.btn_modificar_modelo_Click);
            // 
            // btn_excluir_modelo
            // 
            this.btn_excluir_modelo.Location = new System.Drawing.Point(852, 153);
            this.btn_excluir_modelo.Name = "btn_excluir_modelo";
            this.btn_excluir_modelo.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_modelo.TabIndex = 8;
            this.btn_excluir_modelo.Text = "EXCLUIR";
            this.btn_excluir_modelo.UseVisualStyleBackColor = true;
            this.btn_excluir_modelo.Click += new System.EventHandler(this.btn_excluir_modelo_Click);
            // 
            // cadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 652);
            this.Controls.Add(this.btn_excluir_modelo);
            this.Controls.Add(this.btn_modificar_marca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_consultar_modelo);
            this.Controls.Add(this.btn_salvar_modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridTabelaModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoModelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroModelo";
            this.Text = "Cadastrar Modelo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridTabelaModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_salvar_modelo;
        private System.Windows.Forms.Button btn_consultar_modelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_modificar_marca;
        private System.Windows.Forms.Button btn_excluir_modelo;
    }
}