namespace WindowsFormsApp2
{
    partial class cadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.gridTabelaCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salvar_cliente = new System.Windows.Forms.Button();
            this.btn_consultar_cliente = new System.Windows.Forms.Button();
            this.btn_limpar_consulta_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_excluir_cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(413, 78);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // gridTabelaCliente
            // 
            this.gridTabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabelaCliente.Location = new System.Drawing.Point(12, 205);
            this.gridTabelaCliente.Name = "gridTabelaCliente";
            this.gridTabelaCliente.Size = new System.Drawing.Size(1329, 435);
            this.gridTabelaCliente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(575, 78);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(742, 78);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(100, 20);
            this.txtEmailCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMAIL";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Location = new System.Drawing.Point(913, 78);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SENHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CADASTRO DE CLIENTES";
            // 
            // btn_salvar_cliente
            // 
            this.btn_salvar_cliente.Location = new System.Drawing.Point(431, 153);
            this.btn_salvar_cliente.Name = "btn_salvar_cliente";
            this.btn_salvar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_cliente.TabIndex = 5;
            this.btn_salvar_cliente.Text = "SALVAR";
            this.btn_salvar_cliente.UseVisualStyleBackColor = true;
            this.btn_salvar_cliente.Click += new System.EventHandler(this.btn_salvar_cliente_Click);
            // 
            // btn_consultar_cliente
            // 
            this.btn_consultar_cliente.Location = new System.Drawing.Point(521, 153);
            this.btn_consultar_cliente.Name = "btn_consultar_cliente";
            this.btn_consultar_cliente.Size = new System.Drawing.Size(83, 23);
            this.btn_consultar_cliente.TabIndex = 6;
            this.btn_consultar_cliente.Text = "CONSULTAR";
            this.btn_consultar_cliente.UseVisualStyleBackColor = true;
            this.btn_consultar_cliente.Click += new System.EventHandler(this.btn_consultar_cliente_Click);
            // 
            // btn_limpar_consulta_cliente
            // 
            this.btn_limpar_consulta_cliente.Location = new System.Drawing.Point(619, 153);
            this.btn_limpar_consulta_cliente.Name = "btn_limpar_consulta_cliente";
            this.btn_limpar_consulta_cliente.Size = new System.Drawing.Size(126, 23);
            this.btn_limpar_consulta_cliente.TabIndex = 7;
            this.btn_limpar_consulta_cliente.Text = "LIMPAR CONSULTA";
            this.btn_limpar_consulta_cliente.UseVisualStyleBackColor = true;
            this.btn_limpar_consulta_cliente.Click += new System.EventHandler(this.btn_limpar_consulta_cliente_Click);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.Location = new System.Drawing.Point(760, 153);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_cliente.TabIndex = 8;
            this.btn_modificar_cliente.Text = "MODIFICAR";
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // btn_excluir_cliente
            // 
            this.btn_excluir_cliente.Location = new System.Drawing.Point(852, 153);
            this.btn_excluir_cliente.Name = "btn_excluir_cliente";
            this.btn_excluir_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir_cliente.TabIndex = 9;
            this.btn_excluir_cliente.Text = "EXCLUIR";
            this.btn_excluir_cliente.UseVisualStyleBackColor = true;
            this.btn_excluir_cliente.Click += new System.EventHandler(this.btn_excluir_cliente_Click);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 652);
            this.Controls.Add(this.btn_modificar_cliente);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_limpar_consulta_cliente);
            this.Controls.Add(this.btn_consultar_cliente);
            this.Controls.Add(this.btn_salvar_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridTabelaCliente);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroCliente";
            this.Text = "Cadastrar Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabelaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.DataGridView gridTabelaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salvar_cliente;
        private System.Windows.Forms.Button btn_consultar_cliente;
        private System.Windows.Forms.Button btn_limpar_consulta_cliente;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_excluir_cliente;
    }
}