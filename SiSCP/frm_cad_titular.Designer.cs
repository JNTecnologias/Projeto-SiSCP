namespace SiSCP
{
    partial class frm_cad_titular
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
            System.Windows.Forms.Label bairro_titularLabel;
            System.Windows.Forms.Label cep_titularLabel;
            System.Windows.Forms.Label cpf_titularLabel;
            System.Windows.Forms.Label end_titularLabel;
            System.Windows.Forms.Label nasc_titularLabel;
            System.Windows.Forms.Label nome_titularLabel;
            System.Windows.Forms.Label obs_titularLabel;
            System.Windows.Forms.Label rg_titularLabel;
            System.Windows.Forms.Label estado_titularLabel;
            System.Windows.Forms.Label cidades_titularLabel;
            System.Windows.Forms.Label email_titularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_titular));
            this.bairro_titularTextBox = new System.Windows.Forms.TextBox();
            this.cep_titularTextBox = new System.Windows.Forms.TextBox();
            this.end_titularTextBox = new System.Windows.Forms.TextBox();
            this.nome_titularTextBox = new System.Windows.Forms.TextBox();
            this.obs_titularTextBox = new System.Windows.Forms.TextBox();
            this.rg_titularTextBox = new System.Windows.Forms.TextBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.estado_titularTextBox = new System.Windows.Forms.TextBox();
            this.email_titularTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_enderecoComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descparentescoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableparentescoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNovoDependente = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabledependBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btVoltar = new System.Windows.Forms.Button();
            bairro_titularLabel = new System.Windows.Forms.Label();
            cep_titularLabel = new System.Windows.Forms.Label();
            cpf_titularLabel = new System.Windows.Forms.Label();
            end_titularLabel = new System.Windows.Forms.Label();
            nasc_titularLabel = new System.Windows.Forms.Label();
            nome_titularLabel = new System.Windows.Forms.Label();
            obs_titularLabel = new System.Windows.Forms.Label();
            rg_titularLabel = new System.Windows.Forms.Label();
            estado_titularLabel = new System.Windows.Forms.Label();
            cidades_titularLabel = new System.Windows.Forms.Label();
            email_titularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableparentescoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledependBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bairro_titularLabel
            // 
            bairro_titularLabel.AutoSize = true;
            bairro_titularLabel.Location = new System.Drawing.Point(514, 83);
            bairro_titularLabel.Name = "bairro_titularLabel";
            bairro_titularLabel.Size = new System.Drawing.Size(37, 13);
            bairro_titularLabel.TabIndex = 0;
            bairro_titularLabel.Text = "Bairro:";
            // 
            // cep_titularLabel
            // 
            cep_titularLabel.AutoSize = true;
            cep_titularLabel.Location = new System.Drawing.Point(310, 113);
            cep_titularLabel.Name = "cep_titularLabel";
            cep_titularLabel.Size = new System.Drawing.Size(31, 13);
            cep_titularLabel.TabIndex = 2;
            cep_titularLabel.Text = "CEP:";
            // 
            // cpf_titularLabel
            // 
            cpf_titularLabel.AutoSize = true;
            cpf_titularLabel.Location = new System.Drawing.Point(105, 119);
            cpf_titularLabel.Name = "cpf_titularLabel";
            cpf_titularLabel.Size = new System.Drawing.Size(30, 13);
            cpf_titularLabel.TabIndex = 4;
            cpf_titularLabel.Text = "CPF:";
            // 
            // end_titularLabel
            // 
            end_titularLabel.AutoSize = true;
            end_titularLabel.Location = new System.Drawing.Point(39, 83);
            end_titularLabel.Name = "end_titularLabel";
            end_titularLabel.Size = new System.Drawing.Size(56, 13);
            end_titularLabel.TabIndex = 12;
            end_titularLabel.Text = "Endereço:";
            // 
            // nasc_titularLabel
            // 
            nasc_titularLabel.AutoSize = true;
            nasc_titularLabel.Location = new System.Drawing.Point(364, 59);
            nasc_titularLabel.Name = "nasc_titularLabel";
            nasc_titularLabel.Size = new System.Drawing.Size(92, 13);
            nasc_titularLabel.TabIndex = 16;
            nasc_titularLabel.Text = "Data Nascimento:";
            // 
            // nome_titularLabel
            // 
            nome_titularLabel.AutoSize = true;
            nome_titularLabel.Location = new System.Drawing.Point(10, 31);
            nome_titularLabel.Name = "nome_titularLabel";
            nome_titularLabel.Size = new System.Drawing.Size(85, 13);
            nome_titularLabel.TabIndex = 18;
            nome_titularLabel.Text = "Nome do Titular:";
            // 
            // obs_titularLabel
            // 
            obs_titularLabel.AutoSize = true;
            obs_titularLabel.Location = new System.Drawing.Point(22, 169);
            obs_titularLabel.Name = "obs_titularLabel";
            obs_titularLabel.Size = new System.Drawing.Size(73, 13);
            obs_titularLabel.TabIndex = 20;
            obs_titularLabel.Text = "Observações:";
            // 
            // rg_titularLabel
            // 
            rg_titularLabel.AutoSize = true;
            rg_titularLabel.Location = new System.Drawing.Point(30, 59);
            rg_titularLabel.Name = "rg_titularLabel";
            rg_titularLabel.Size = new System.Drawing.Size(65, 13);
            rg_titularLabel.TabIndex = 22;
            rg_titularLabel.Text = "Documento:";
            // 
            // estado_titularLabel
            // 
            estado_titularLabel.AutoSize = true;
            estado_titularLabel.Location = new System.Drawing.Point(509, 110);
            estado_titularLabel.Name = "estado_titularLabel";
            estado_titularLabel.Size = new System.Drawing.Size(43, 13);
            estado_titularLabel.TabIndex = 30;
            estado_titularLabel.Text = "Estado:";
            // 
            // cidades_titularLabel
            // 
            cidades_titularLabel.AutoSize = true;
            cidades_titularLabel.Location = new System.Drawing.Point(48, 113);
            cidades_titularLabel.Name = "cidades_titularLabel";
            cidades_titularLabel.Size = new System.Drawing.Size(48, 13);
            cidades_titularLabel.TabIndex = 31;
            cidades_titularLabel.Text = "Cidades:";
            // 
            // email_titularLabel
            // 
            email_titularLabel.AutoSize = true;
            email_titularLabel.Location = new System.Drawing.Point(58, 141);
            email_titularLabel.Name = "email_titularLabel";
            email_titularLabel.Size = new System.Drawing.Size(38, 13);
            email_titularLabel.TabIndex = 32;
            email_titularLabel.Text = "E-mail:";
            // 
            // bairro_titularTextBox
            // 
            this.bairro_titularTextBox.Location = new System.Drawing.Point(557, 80);
            this.bairro_titularTextBox.Name = "bairro_titularTextBox";
            this.bairro_titularTextBox.Size = new System.Drawing.Size(104, 20);
            this.bairro_titularTextBox.TabIndex = 5;
            // 
            // cep_titularTextBox
            // 
            this.cep_titularTextBox.Location = new System.Drawing.Point(348, 110);
            this.cep_titularTextBox.Name = "cep_titularTextBox";
            this.cep_titularTextBox.Size = new System.Drawing.Size(104, 20);
            this.cep_titularTextBox.TabIndex = 3;
            // 
            // end_titularTextBox
            // 
            this.end_titularTextBox.Location = new System.Drawing.Point(104, 80);
            this.end_titularTextBox.Name = "end_titularTextBox";
            this.end_titularTextBox.Size = new System.Drawing.Size(348, 20);
            this.end_titularTextBox.TabIndex = 13;
            // 
            // nome_titularTextBox
            // 
            this.nome_titularTextBox.Location = new System.Drawing.Point(104, 28);
            this.nome_titularTextBox.Name = "nome_titularTextBox";
            this.nome_titularTextBox.Size = new System.Drawing.Size(557, 20);
            this.nome_titularTextBox.TabIndex = 19;
            // 
            // obs_titularTextBox
            // 
            this.obs_titularTextBox.Location = new System.Drawing.Point(104, 169);
            this.obs_titularTextBox.Multiline = true;
            this.obs_titularTextBox.Name = "obs_titularTextBox";
            this.obs_titularTextBox.Size = new System.Drawing.Size(557, 75);
            this.obs_titularTextBox.TabIndex = 21;
            // 
            // rg_titularTextBox
            // 
            this.rg_titularTextBox.Location = new System.Drawing.Point(104, 54);
            this.rg_titularTextBox.Name = "rg_titularTextBox";
            this.rg_titularTextBox.Size = new System.Drawing.Size(144, 20);
            this.rg_titularTextBox.TabIndex = 23;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(318, 114);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 27;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(309, 268);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 28;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(417, 268);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 29;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Manter Titulares";
            // 
            // estado_titularTextBox
            // 
            this.estado_titularTextBox.Location = new System.Drawing.Point(557, 106);
            this.estado_titularTextBox.Name = "estado_titularTextBox";
            this.estado_titularTextBox.Size = new System.Drawing.Size(104, 20);
            this.estado_titularTextBox.TabIndex = 31;
            // 
            // email_titularTextBox
            // 
            this.email_titularTextBox.Location = new System.Drawing.Point(104, 138);
            this.email_titularTextBox.Name = "email_titularTextBox";
            this.email_titularTextBox.Size = new System.Drawing.Size(348, 20);
            this.email_titularTextBox.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(462, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2016, 8, 28, 0, 0, 0, 0);
            // 
            // id_enderecoComboBox
            // 
            this.id_enderecoComboBox.DisplayMember = "id_endereco";
            this.id_enderecoComboBox.FormattingEnabled = true;
            this.id_enderecoComboBox.Location = new System.Drawing.Point(104, 110);
            this.id_enderecoComboBox.Name = "id_enderecoComboBox";
            this.id_enderecoComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_enderecoComboBox.TabIndex = 35;
            this.id_enderecoComboBox.ValueMember = "id_endereco";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.descparentescoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableparentescoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nome_depend";
            this.Column1.HeaderText = "Dependentes";
            this.Column1.Name = "Column1";
            // 
            // descparentescoDataGridViewTextBoxColumn
            // 
            this.descparentescoDataGridViewTextBoxColumn.DataPropertyName = "desc_parentesco";
            this.descparentescoDataGridViewTextBoxColumn.HeaderText = "Parentesco";
            this.descparentescoDataGridViewTextBoxColumn.Name = "descparentescoDataGridViewTextBoxColumn";
            // 
            // tableparentescoBindingSource
            // 
            this.tableparentescoBindingSource.DataSource = typeof(siscp.DAL.Table_parentesco);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_enderecoComboBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(email_titularLabel);
            this.groupBox1.Controls.Add(this.email_titularTextBox);
            this.groupBox1.Controls.Add(cidades_titularLabel);
            this.groupBox1.Controls.Add(estado_titularLabel);
            this.groupBox1.Controls.Add(nome_titularLabel);
            this.groupBox1.Controls.Add(this.estado_titularTextBox);
            this.groupBox1.Controls.Add(this.nome_titularTextBox);
            this.groupBox1.Controls.Add(this.btExcluir);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(bairro_titularLabel);
            this.groupBox1.Controls.Add(this.bairro_titularTextBox);
            this.groupBox1.Controls.Add(cep_titularLabel);
            this.groupBox1.Controls.Add(this.cep_titularTextBox);
            this.groupBox1.Controls.Add(end_titularLabel);
            this.groupBox1.Controls.Add(this.end_titularTextBox);
            this.groupBox1.Controls.Add(nasc_titularLabel);
            this.groupBox1.Controls.Add(obs_titularLabel);
            this.groupBox1.Controls.Add(this.obs_titularTextBox);
            this.groupBox1.Controls.Add(rg_titularLabel);
            this.groupBox1.Controls.Add(this.rg_titularTextBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 317);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Titular";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(237, 115);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 39;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btNovoDependente
            // 
            this.btNovoDependente.Location = new System.Drawing.Point(370, 668);
            this.btNovoDependente.Name = "btNovoDependente";
            this.btNovoDependente.Size = new System.Drawing.Size(125, 23);
            this.btNovoDependente.TabIndex = 36;
            this.btNovoDependente.Text = "Novo Dependente";
            this.btNovoDependente.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 117);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBox1.TabIndex = 40;
            // 
            // tabledependBindingSource
            // 
            this.tabledependBindingSource.DataSource = typeof(siscp.DAL.Table_depend);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(729, 692);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 36;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // frm_cad_titular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 741);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btNovoDependente);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(cpf_titularLabel);
            this.Controls.Add(this.btNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_cad_titular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiSCP v0.1 - Cadastro de Titular";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableparentescoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledependBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bairro_titularTextBox;
        private System.Windows.Forms.TextBox cep_titularTextBox;
        private System.Windows.Forms.TextBox end_titularTextBox;
        private System.Windows.Forms.TextBox nome_titularTextBox;
        private System.Windows.Forms.TextBox obs_titularTextBox;
        private System.Windows.Forms.TextBox rg_titularTextBox;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox estado_titularTextBox;
        private System.Windows.Forms.TextBox email_titularTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox id_enderecoComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddependDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfdependDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedependDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.BindingSource tabledependBindingSource;
        private System.Windows.Forms.Button btNovoDependente;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource tableparentescoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descparentescoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btVoltar;
    }
}