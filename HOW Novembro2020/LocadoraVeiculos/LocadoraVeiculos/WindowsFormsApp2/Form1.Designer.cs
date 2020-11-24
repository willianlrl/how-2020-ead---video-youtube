namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOCAÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.lOCAÇÃOToolStripMenuItem1,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(167, 70);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mARCASToolStripMenuItem,
            this.vEÍCULOSToolStripMenuItem,
            this.vEÍCULOToolStripMenuItem,
            this.cLIENTEToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(160, 19);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS E CONSULTAS";
            this.cADASTROSToolStripMenuItem.Click += new System.EventHandler(this.cADASTROSToolStripMenuItem_Click);
            // 
            // mARCASToolStripMenuItem
            // 
            this.mARCASToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.mARCASToolStripMenuItem.Name = "mARCASToolStripMenuItem";
            this.mARCASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mARCASToolStripMenuItem.Text = "MARCA";
            this.mARCASToolStripMenuItem.Click += new System.EventHandler(this.mARCASToolStripMenuItem_Click);
            // 
            // vEÍCULOSToolStripMenuItem
            // 
            this.vEÍCULOSToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.vEÍCULOSToolStripMenuItem.Name = "vEÍCULOSToolStripMenuItem";
            this.vEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vEÍCULOSToolStripMenuItem.Text = "MODELO";
            this.vEÍCULOSToolStripMenuItem.Click += new System.EventHandler(this.vEÍCULOSToolStripMenuItem_Click);
            // 
            // vEÍCULOToolStripMenuItem
            // 
            this.vEÍCULOToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.vEÍCULOToolStripMenuItem.Name = "vEÍCULOToolStripMenuItem";
            this.vEÍCULOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vEÍCULOToolStripMenuItem.Text = "VEÍCULO";
            this.vEÍCULOToolStripMenuItem.Click += new System.EventHandler(this.vEÍCULOToolStripMenuItem_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // lOCAÇÃOToolStripMenuItem1
            // 
            this.lOCAÇÃOToolStripMenuItem1.Name = "lOCAÇÃOToolStripMenuItem1";
            this.lOCAÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(160, 19);
            this.lOCAÇÃOToolStripMenuItem1.Text = "LOCAÇÃO";
            this.lOCAÇÃOToolStripMenuItem1.Click += new System.EventHandler(this.lOCAÇÃOToolStripMenuItem1_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(160, 19);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(0, 70);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(68, 159);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(166, 70);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.TopToolStripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.TopToolStripPanel.BackgroundImage")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlugaCar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOCAÇÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mARCASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

