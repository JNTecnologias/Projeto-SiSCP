namespace SiSCP
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastroTitulares = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastroDependentes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadastroProcedimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsultarTitular = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsultarDependente = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsultarProcedimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioEXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWord = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInformaçõesDoSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarMenu,
            this.consultarMenu,
            this.relatorioMenu,
            this.utilitariosMenu,
            this.sobreMenu,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastarMenu
            // 
            this.cadastarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastroTitulares,
            this.itemCadastroDependentes,
            this.itemCadastroProcedimentos});
            this.cadastarMenu.Name = "cadastarMenu";
            this.cadastarMenu.Size = new System.Drawing.Size(71, 20);
            this.cadastarMenu.Text = "Cadastros";
            // 
            // itemCadastroTitulares
            // 
            this.itemCadastroTitulares.Name = "itemCadastroTitulares";
            this.itemCadastroTitulares.Size = new System.Drawing.Size(143, 22);
            this.itemCadastroTitulares.Text = "Titulares";
            this.itemCadastroTitulares.Click += new System.EventHandler(this.itemCadastroTitulares_Click);
            // 
            // itemCadastroDependentes
            // 
            this.itemCadastroDependentes.Name = "itemCadastroDependentes";
            this.itemCadastroDependentes.Size = new System.Drawing.Size(143, 22);
            this.itemCadastroDependentes.Text = "Dependentes";
            this.itemCadastroDependentes.Click += new System.EventHandler(this.itemCadastroDependentes_Click);
            // 
            // itemCadastroProcedimentos
            // 
            this.itemCadastroProcedimentos.Name = "itemCadastroProcedimentos";
            this.itemCadastroProcedimentos.Size = new System.Drawing.Size(143, 22);
            this.itemCadastroProcedimentos.Text = "Tratamentos";
            this.itemCadastroProcedimentos.Click += new System.EventHandler(this.itemCadastroProcedimentos_Click);
            // 
            // consultarMenu
            // 
            this.consultarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConsultarTitular,
            this.itemConsultarDependente,
            this.itemConsultarProcedimentos});
            this.consultarMenu.Name = "consultarMenu";
            this.consultarMenu.Size = new System.Drawing.Size(71, 20);
            this.consultarMenu.Text = "Consultas";
            this.consultarMenu.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // itemConsultarTitular
            // 
            this.itemConsultarTitular.Name = "itemConsultarTitular";
            this.itemConsultarTitular.Size = new System.Drawing.Size(154, 22);
            this.itemConsultarTitular.Text = "Titular";
            // 
            // itemConsultarDependente
            // 
            this.itemConsultarDependente.Name = "itemConsultarDependente";
            this.itemConsultarDependente.Size = new System.Drawing.Size(154, 22);
            this.itemConsultarDependente.Text = "Dependente";
            // 
            // itemConsultarProcedimentos
            // 
            this.itemConsultarProcedimentos.Name = "itemConsultarProcedimentos";
            this.itemConsultarProcedimentos.Size = new System.Drawing.Size(154, 22);
            this.itemConsultarProcedimentos.Text = "Procedimentos";
            // 
            // relatorioMenu
            // 
            this.relatorioMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioEXCELToolStripMenuItem});
            this.relatorioMenu.Name = "relatorioMenu";
            this.relatorioMenu.Size = new System.Drawing.Size(71, 20);
            this.relatorioMenu.Text = "Relatórios";
            // 
            // relatórioEXCELToolStripMenuItem
            // 
            this.relatórioEXCELToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem1});
            this.relatórioEXCELToolStripMenuItem.Name = "relatórioEXCELToolStripMenuItem";
            this.relatórioEXCELToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.relatórioEXCELToolStripMenuItem.Text = "Relatório";
            // 
            // excelToolStripMenuItem1
            // 
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem1.Text = "Excel";
            // 
            // utilitariosMenu
            // 
            this.utilitariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCalculadora,
            this.itemExcel,
            this.itemWord});
            this.utilitariosMenu.Name = "utilitariosMenu";
            this.utilitariosMenu.Size = new System.Drawing.Size(69, 20);
            this.utilitariosMenu.Text = "Utilitários";
            // 
            // itemCalculadora
            // 
            this.itemCalculadora.Name = "itemCalculadora";
            this.itemCalculadora.Size = new System.Drawing.Size(152, 22);
            this.itemCalculadora.Text = "Calculadora";
            this.itemCalculadora.Click += new System.EventHandler(this.itemCalculadora_Click);
            // 
            // itemExcel
            // 
            this.itemExcel.Name = "itemExcel";
            this.itemExcel.Size = new System.Drawing.Size(152, 22);
            this.itemExcel.Text = "Excel";
            this.itemExcel.Click += new System.EventHandler(this.itemExcel_Click);
            // 
            // itemWord
            // 
            this.itemWord.Name = "itemWord";
            this.itemWord.Size = new System.Drawing.Size(152, 22);
            this.itemWord.Text = "Word";
            this.itemWord.Click += new System.EventHandler(this.itemWord_Click);
            // 
            // sobreMenu
            // 
            this.sobreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInformaçõesDoSistema,
            this.itemSuporte});
            this.sobreMenu.Name = "sobreMenu";
            this.sobreMenu.Size = new System.Drawing.Size(49, 20);
            this.sobreMenu.Text = "Sobre";
            // 
            // itemInformaçõesDoSistema
            // 
            this.itemInformaçõesDoSistema.Name = "itemInformaçõesDoSistema";
            this.itemInformaçõesDoSistema.Size = new System.Drawing.Size(201, 22);
            this.itemInformaçõesDoSistema.Text = "Informações do Sistema";
            this.itemInformaçõesDoSistema.Click += new System.EventHandler(this.itemInformaçõesDoSistema_Click);
            // 
            // itemSuporte
            // 
            this.itemSuporte.Name = "itemSuporte";
            this.itemSuporte.Size = new System.Drawing.Size(201, 22);
            this.itemSuporte.Text = "Suporte";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(713, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo !!!";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(216, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiSCP v0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastarMenu;
        private System.Windows.Forms.ToolStripMenuItem consultarMenu;
        private System.Windows.Forms.ToolStripMenuItem itemCadastroTitulares;
        private System.Windows.Forms.ToolStripMenuItem itemCadastroProcedimentos;
        private System.Windows.Forms.ToolStripMenuItem itemCadastroDependentes;
        private System.Windows.Forms.ToolStripMenuItem itemConsultarTitular;
        private System.Windows.Forms.ToolStripMenuItem itemConsultarProcedimentos;
        private System.Windows.Forms.ToolStripMenuItem relatorioMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreMenu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem utilitariosMenu;
        private System.Windows.Forms.ToolStripMenuItem itemCalculadora;
        private System.Windows.Forms.ToolStripMenuItem itemExcel;
        private System.Windows.Forms.ToolStripMenuItem itemWord;
        private System.Windows.Forms.ToolStripMenuItem relatórioEXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemConsultarDependente;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem itemInformaçõesDoSistema;
        private System.Windows.Forms.ToolStripMenuItem itemSuporte;
    }
}