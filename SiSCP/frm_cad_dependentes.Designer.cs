namespace SiSCP
{
    partial class frm_cad_dependentes
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
            System.Windows.Forms.Label nome_dependLabel;
            System.Windows.Forms.Label id_endereco_denpendLabel1;
            System.Windows.Forms.Label id_parentesco_dependLabel;
            System.Windows.Forms.Label id_endereco_denpendLabel;
            System.Windows.Forms.Label id_titular_dependLabel;
            System.Windows.Forms.Label bairro_dependLabel;
            System.Windows.Forms.Label cep_dependLabel;
            System.Windows.Forms.Label cpf_dependLabel;
            System.Windows.Forms.Label email_dependLabel;
            System.Windows.Forms.Label end_dependLabel;
            System.Windows.Forms.Label nasc_dependLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_dependentes));
            this.table_dependBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.table_dependBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_dependBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nome_dependTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.table_titularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_parentescoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_endereco_denpendComboBox1 = new System.Windows.Forms.ComboBox();
            this.id_parentesco_dependComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.id_endereco_denpendComboBox = new System.Windows.Forms.ComboBox();
            this.bairro_dependTextBox = new System.Windows.Forms.TextBox();
            this.cep_dependTextBox = new System.Windows.Forms.TextBox();
            this.email_dependTextBox = new System.Windows.Forms.TextBox();
            this.end_dependTextBox = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            nome_dependLabel = new System.Windows.Forms.Label();
            id_endereco_denpendLabel1 = new System.Windows.Forms.Label();
            id_parentesco_dependLabel = new System.Windows.Forms.Label();
            id_endereco_denpendLabel = new System.Windows.Forms.Label();
            id_titular_dependLabel = new System.Windows.Forms.Label();
            bairro_dependLabel = new System.Windows.Forms.Label();
            cep_dependLabel = new System.Windows.Forms.Label();
            cpf_dependLabel = new System.Windows.Forms.Label();
            email_dependLabel = new System.Windows.Forms.Label();
            end_dependLabel = new System.Windows.Forms.Label();
            nasc_dependLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_dependBindingNavigator)).BeginInit();
            this.table_dependBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_dependBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_titularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_parentescoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_dependLabel
            // 
            nome_dependLabel.AutoSize = true;
            nome_dependLabel.Location = new System.Drawing.Point(51, 62);
            nome_dependLabel.Name = "nome_dependLabel";
            nome_dependLabel.Size = new System.Drawing.Size(38, 13);
            nome_dependLabel.TabIndex = 19;
            nome_dependLabel.Text = "Nome:";
            nome_dependLabel.Click += new System.EventHandler(this.nome_dependLabel_Click);
            // 
            // id_endereco_denpendLabel1
            // 
            id_endereco_denpendLabel1.AutoSize = true;
            id_endereco_denpendLabel1.Location = new System.Drawing.Point(538, 171);
            id_endereco_denpendLabel1.Name = "id_endereco_denpendLabel1";
            id_endereco_denpendLabel1.Size = new System.Drawing.Size(43, 13);
            id_endereco_denpendLabel1.TabIndex = 56;
            id_endereco_denpendLabel1.Text = "Estado:";
            // 
            // id_parentesco_dependLabel
            // 
            id_parentesco_dependLabel.AutoSize = true;
            id_parentesco_dependLabel.Location = new System.Drawing.Point(231, 102);
            id_parentesco_dependLabel.Name = "id_parentesco_dependLabel";
            id_parentesco_dependLabel.Size = new System.Drawing.Size(64, 13);
            id_parentesco_dependLabel.TabIndex = 54;
            id_parentesco_dependLabel.Text = "Parentesco:";
            // 
            // id_endereco_denpendLabel
            // 
            id_endereco_denpendLabel.AutoSize = true;
            id_endereco_denpendLabel.Location = new System.Drawing.Point(538, 135);
            id_endereco_denpendLabel.Name = "id_endereco_denpendLabel";
            id_endereco_denpendLabel.Size = new System.Drawing.Size(43, 13);
            id_endereco_denpendLabel.TabIndex = 52;
            id_endereco_denpendLabel.Text = "Cidade:";
            // 
            // id_titular_dependLabel
            // 
            id_titular_dependLabel.AutoSize = true;
            id_titular_dependLabel.Location = new System.Drawing.Point(51, 29);
            id_titular_dependLabel.Name = "id_titular_dependLabel";
            id_titular_dependLabel.Size = new System.Drawing.Size(39, 13);
            id_titular_dependLabel.TabIndex = 50;
            id_titular_dependLabel.Text = "Titular:";
            // 
            // bairro_dependLabel
            // 
            bairro_dependLabel.AutoSize = true;
            bairro_dependLabel.Location = new System.Drawing.Point(539, 103);
            bairro_dependLabel.Name = "bairro_dependLabel";
            bairro_dependLabel.Size = new System.Drawing.Size(37, 13);
            bairro_dependLabel.TabIndex = 35;
            bairro_dependLabel.Text = "Bairro:";
            // 
            // cep_dependLabel
            // 
            cep_dependLabel.AutoSize = true;
            cep_dependLabel.Location = new System.Drawing.Point(323, 171);
            cep_dependLabel.Name = "cep_dependLabel";
            cep_dependLabel.Size = new System.Drawing.Size(31, 13);
            cep_dependLabel.TabIndex = 37;
            cep_dependLabel.Text = "CEP:";
            // 
            // cpf_dependLabel
            // 
            cpf_dependLabel.AutoSize = true;
            cpf_dependLabel.Location = new System.Drawing.Point(75, 107);
            cpf_dependLabel.Name = "cpf_dependLabel";
            cpf_dependLabel.Size = new System.Drawing.Size(30, 13);
            cpf_dependLabel.TabIndex = 39;
            cpf_dependLabel.Text = "CPF:";
            // 
            // email_dependLabel
            // 
            email_dependLabel.AutoSize = true;
            email_dependLabel.Location = new System.Drawing.Point(58, 168);
            email_dependLabel.Name = "email_dependLabel";
            email_dependLabel.Size = new System.Drawing.Size(38, 13);
            email_dependLabel.TabIndex = 41;
            email_dependLabel.Text = "E-mail:";
            // 
            // end_dependLabel
            // 
            end_dependLabel.AutoSize = true;
            end_dependLabel.Location = new System.Drawing.Point(38, 133);
            end_dependLabel.Name = "end_dependLabel";
            end_dependLabel.Size = new System.Drawing.Size(56, 13);
            end_dependLabel.TabIndex = 43;
            end_dependLabel.Text = "Endereço:";
            // 
            // nasc_dependLabel
            // 
            nasc_dependLabel.AutoSize = true;
            nasc_dependLabel.Location = new System.Drawing.Point(25, 101);
            nasc_dependLabel.Name = "nasc_dependLabel";
            nasc_dependLabel.Size = new System.Drawing.Size(64, 13);
            nasc_dependLabel.TabIndex = 45;
            nasc_dependLabel.Text = "Data Nasc.:";
            nasc_dependLabel.Click += new System.EventHandler(this.nasc_dependLabel_Click);
            // 
            // table_dependBindingNavigator
            // 
            this.table_dependBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_dependBindingNavigator.BindingSource = this.table_dependBindingSource;
            this.table_dependBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_dependBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_dependBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table_dependBindingNavigatorSaveItem});
            this.table_dependBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_dependBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_dependBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_dependBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_dependBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_dependBindingNavigator.Name = "table_dependBindingNavigator";
            this.table_dependBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_dependBindingNavigator.Size = new System.Drawing.Size(831, 25);
            this.table_dependBindingNavigator.TabIndex = 0;
            this.table_dependBindingNavigator.Text = "bindingNavigator1";
            this.table_dependBindingNavigator.RefreshItems += new System.EventHandler(this.table_dependBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // table_dependBindingSource
            // 
            this.table_dependBindingSource.DataSource = typeof(siscp.DAL.Table_depend);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table_dependBindingNavigatorSaveItem
            // 
            this.table_dependBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_dependBindingNavigatorSaveItem.Enabled = false;
            this.table_dependBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_dependBindingNavigatorSaveItem.Image")));
            this.table_dependBindingNavigatorSaveItem.Name = "table_dependBindingNavigatorSaveItem";
            this.table_dependBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_dependBindingNavigatorSaveItem.Text = "Salvar Dados";
            // 
            // nome_dependTextBox
            // 
            this.nome_dependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "nome_depend", true));
            this.nome_dependTextBox.Enabled = false;
            this.nome_dependTextBox.Location = new System.Drawing.Point(96, 59);
            this.nome_dependTextBox.Name = "nome_dependTextBox";
            this.nome_dependTextBox.Size = new System.Drawing.Size(459, 20);
            this.nome_dependTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Manter Dependentes";
            // 
            // table_titularBindingSource
            // 
            this.table_titularBindingSource.DataSource = typeof(siscp.DAL.Table_titular);
            // 
            // table_enderecoBindingSource
            // 
            this.table_enderecoBindingSource.DataSource = typeof(siscp.DAL.Table_endereco);
            // 
            // table_parentescoBindingSource
            // 
            this.table_parentescoBindingSource.DataSource = typeof(siscp.DAL.Table_parentesco);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(id_endereco_denpendLabel1);
            this.groupBox1.Controls.Add(id_titular_dependLabel);
            this.groupBox1.Controls.Add(this.id_endereco_denpendComboBox1);
            this.groupBox1.Controls.Add(id_parentesco_dependLabel);
            this.groupBox1.Controls.Add(this.id_parentesco_dependComboBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(nome_dependLabel);
            this.groupBox1.Controls.Add(id_endereco_denpendLabel);
            this.groupBox1.Controls.Add(this.nome_dependTextBox);
            this.groupBox1.Controls.Add(this.id_endereco_denpendComboBox);
            this.groupBox1.Controls.Add(bairro_dependLabel);
            this.groupBox1.Controls.Add(this.bairro_dependTextBox);
            this.groupBox1.Controls.Add(cep_dependLabel);
            this.groupBox1.Controls.Add(this.cep_dependTextBox);
            this.groupBox1.Controls.Add(email_dependLabel);
            this.groupBox1.Controls.Add(this.email_dependTextBox);
            this.groupBox1.Controls.Add(end_dependLabel);
            this.groupBox1.Controls.Add(this.end_dependTextBox);
            this.groupBox1.Controls.Add(nasc_dependLabel);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 255);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "nome_depend", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(96, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 59;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "nasc_depend", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.Value = new System.DateTime(2016, 8, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // id_endereco_denpendComboBox1
            // 
            this.id_endereco_denpendComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "id_endereco_denpend", true));
            this.id_endereco_denpendComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_dependBindingSource, "id_endereco_denpend", true));
            this.id_endereco_denpendComboBox1.DataSource = this.table_enderecoBindingSource;
            this.id_endereco_denpendComboBox1.DisplayMember = "estados";
            this.id_endereco_denpendComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_endereco_denpendComboBox1.Enabled = false;
            this.id_endereco_denpendComboBox1.FormattingEnabled = true;
            this.id_endereco_denpendComboBox1.Location = new System.Drawing.Point(585, 165);
            this.id_endereco_denpendComboBox1.Name = "id_endereco_denpendComboBox1";
            this.id_endereco_denpendComboBox1.Size = new System.Drawing.Size(200, 21);
            this.id_endereco_denpendComboBox1.TabIndex = 57;
            this.id_endereco_denpendComboBox1.ValueMember = "id_endereco";
            // 
            // id_parentesco_dependComboBox
            // 
            this.id_parentesco_dependComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_dependBindingSource, "id_parentesco_depend", true));
            this.id_parentesco_dependComboBox.DataSource = this.table_parentescoBindingSource;
            this.id_parentesco_dependComboBox.DisplayMember = "desc_parentesco";
            this.id_parentesco_dependComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_parentesco_dependComboBox.Enabled = false;
            this.id_parentesco_dependComboBox.FormattingEnabled = true;
            this.id_parentesco_dependComboBox.Location = new System.Drawing.Point(299, 98);
            this.id_parentesco_dependComboBox.Name = "id_parentesco_dependComboBox";
            this.id_parentesco_dependComboBox.Size = new System.Drawing.Size(174, 21);
            this.id_parentesco_dependComboBox.TabIndex = 55;
            this.id_parentesco_dependComboBox.ValueMember = "id_parentesco";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_endereco_denpendComboBox
            // 
            this.id_endereco_denpendComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.table_dependBindingSource, "id_endereco_denpend", true));
            this.id_endereco_denpendComboBox.DataSource = this.table_enderecoBindingSource;
            this.id_endereco_denpendComboBox.DisplayMember = "cidades";
            this.id_endereco_denpendComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_endereco_denpendComboBox.Enabled = false;
            this.id_endereco_denpendComboBox.FormattingEnabled = true;
            this.id_endereco_denpendComboBox.Location = new System.Drawing.Point(585, 131);
            this.id_endereco_denpendComboBox.Name = "id_endereco_denpendComboBox";
            this.id_endereco_denpendComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_endereco_denpendComboBox.TabIndex = 53;
            this.id_endereco_denpendComboBox.ValueMember = "id_endereco";
            // 
            // bairro_dependTextBox
            // 
            this.bairro_dependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "bairro_depend", true));
            this.bairro_dependTextBox.Enabled = false;
            this.bairro_dependTextBox.Location = new System.Drawing.Point(585, 99);
            this.bairro_dependTextBox.Name = "bairro_dependTextBox";
            this.bairro_dependTextBox.Size = new System.Drawing.Size(200, 20);
            this.bairro_dependTextBox.TabIndex = 36;
            // 
            // cep_dependTextBox
            // 
            this.cep_dependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "cep_depend", true));
            this.cep_dependTextBox.Enabled = false;
            this.cep_dependTextBox.Location = new System.Drawing.Point(364, 168);
            this.cep_dependTextBox.Name = "cep_dependTextBox";
            this.cep_dependTextBox.Size = new System.Drawing.Size(136, 20);
            this.cep_dependTextBox.TabIndex = 38;
            // 
            // email_dependTextBox
            // 
            this.email_dependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "email_depend", true));
            this.email_dependTextBox.Enabled = false;
            this.email_dependTextBox.Location = new System.Drawing.Point(96, 164);
            this.email_dependTextBox.Name = "email_dependTextBox";
            this.email_dependTextBox.Size = new System.Drawing.Size(169, 20);
            this.email_dependTextBox.TabIndex = 42;
            // 
            // end_dependTextBox
            // 
            this.end_dependTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_dependBindingSource, "end_depend", true));
            this.end_dependTextBox.Enabled = false;
            this.end_dependTextBox.Location = new System.Drawing.Point(96, 131);
            this.end_dependTextBox.Name = "end_dependTextBox";
            this.end_dependTextBox.Size = new System.Drawing.Size(404, 20);
            this.end_dependTextBox.TabIndex = 44;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(227, 101);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 47;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(108, 99);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBox1.TabIndex = 48;
            // 
            // frm_cad_dependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 741);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_dependBindingNavigator);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(cpf_dependLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cad_dependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiSCP v0.1 - Cadastro de Dependentes";
            this.Load += new System.EventHandler(this.frm_cad_dependentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_dependBindingNavigator)).EndInit();
            this.table_dependBindingNavigator.ResumeLayout(false);
            this.table_dependBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_dependBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_titularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_parentescoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource table_dependBindingSource;
        private System.Windows.Forms.BindingNavigator table_dependBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_dependBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nome_dependTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource table_titularBindingSource;
        private System.Windows.Forms.BindingSource table_enderecoBindingSource;
        private System.Windows.Forms.BindingSource table_parentescoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox id_endereco_denpendComboBox1;
        private System.Windows.Forms.ComboBox id_parentesco_dependComboBox;
        private System.Windows.Forms.ComboBox id_endereco_denpendComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox bairro_dependTextBox;
        private System.Windows.Forms.TextBox cep_dependTextBox;
        private System.Windows.Forms.TextBox email_dependTextBox;
        private System.Windows.Forms.TextBox end_dependTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;

    }
}