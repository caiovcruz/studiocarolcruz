namespace View
{
    partial class ViewSessao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.cboxBuscarSessao = new System.Windows.Forms.ComboBox();
            this.txtBuscarSessao = new System.Windows.Forms.TextBox();
            this.gboxSessao = new System.Windows.Forms.GroupBox();
            this.lblCodigoProcedimentoSessao = new System.Windows.Forms.Label();
            this.txtCodigoProcedimentoSessao = new System.Windows.Forms.TextBox();
            this.dtUltimaSessao = new System.Windows.Forms.DateTimePicker();
            this.lblClienteSessao = new System.Windows.Forms.Label();
            this.txtClienteSessao = new System.Windows.Forms.TextBox();
            this.btnCancelarSessao = new System.Windows.Forms.Button();
            this.btnEditarSessao = new System.Windows.Forms.Button();
            this.btnSalvarSessao = new System.Windows.Forms.Button();
            this.txtProcedimentoSessao = new System.Windows.Forms.TextBox();
            this.txtQuantidadeSessao = new System.Windows.Forms.TextBox();
            this.lblQuantidadeSessao = new System.Windows.Forms.Label();
            this.txtSessaoAtual = new System.Windows.Forms.TextBox();
            this.lblSessaoAtual = new System.Windows.Forms.Label();
            this.lblUltimaDataSessao = new System.Windows.Forms.Label();
            this.lblCodigoVendaSessao = new System.Windows.Forms.Label();
            this.txtObservacaoSessao = new System.Windows.Forms.TextBox();
            this.lblObservacaoSessao = new System.Windows.Forms.Label();
            this.lblProcedimentoSessao = new System.Windows.Forms.Label();
            this.txtCodigoVendaSessao = new System.Windows.Forms.TextBox();
            this.tpgConfiguracoesSessao = new System.Windows.Forms.TabPage();
            this.btnExcluirSessao = new System.Windows.Forms.Button();
            this.tpgListarSessao = new System.Windows.Forms.TabPage();
            this.chkExibirTodasSessoes = new System.Windows.Forms.CheckBox();
            this.btnBuscarSessao = new System.Windows.Forms.Button();
            this.lblBuscarSessao = new System.Windows.Forms.Label();
            this.chkExcluirSessao = new System.Windows.Forms.CheckBox();
            this.dgvSessao = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalSessao = new System.Windows.Forms.Label();
            this.tctrlSessao = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.gboxSessao.SuspendLayout();
            this.tpgConfiguracoesSessao.SuspendLayout();
            this.tpgListarSessao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessao)).BeginInit();
            this.tctrlSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // cboxBuscarSessao
            // 
            this.cboxBuscarSessao.BackColor = System.Drawing.Color.White;
            this.cboxBuscarSessao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBuscarSessao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxBuscarSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBuscarSessao.FormattingEnabled = true;
            this.cboxBuscarSessao.Items.AddRange(new object[] {
            "Cliente",
            "Procedimento"});
            this.cboxBuscarSessao.Location = new System.Drawing.Point(88, 18);
            this.cboxBuscarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuscarSessao.Name = "cboxBuscarSessao";
            this.cboxBuscarSessao.Size = new System.Drawing.Size(130, 28);
            this.cboxBuscarSessao.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.cboxBuscarSessao, "Selecione o método de busca desejado");
            this.cboxBuscarSessao.SelectedIndexChanged += new System.EventHandler(this.cboxBuscarSessao_SelectedIndexChanged);
            // 
            // txtBuscarSessao
            // 
            this.txtBuscarSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSessao.Location = new System.Drawing.Point(241, 18);
            this.txtBuscarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarSessao.Name = "txtBuscarSessao";
            this.txtBuscarSessao.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarSessao.TabIndex = 2;
            this.ttmesagem.SetToolTip(this.txtBuscarSessao, "Digite o nome do cliente ou procedimento, \r\nde acordo com oque foi selecionado na" +
        " lista");
            this.txtBuscarSessao.TextChanged += new System.EventHandler(this.txtBuscarSessao_TextChanged);
            // 
            // gboxSessao
            // 
            this.gboxSessao.BackColor = System.Drawing.Color.White;
            this.gboxSessao.Controls.Add(this.lblCodigoProcedimentoSessao);
            this.gboxSessao.Controls.Add(this.txtCodigoProcedimentoSessao);
            this.gboxSessao.Controls.Add(this.dtUltimaSessao);
            this.gboxSessao.Controls.Add(this.lblClienteSessao);
            this.gboxSessao.Controls.Add(this.txtClienteSessao);
            this.gboxSessao.Controls.Add(this.btnCancelarSessao);
            this.gboxSessao.Controls.Add(this.btnEditarSessao);
            this.gboxSessao.Controls.Add(this.btnSalvarSessao);
            this.gboxSessao.Controls.Add(this.txtProcedimentoSessao);
            this.gboxSessao.Controls.Add(this.txtQuantidadeSessao);
            this.gboxSessao.Controls.Add(this.lblQuantidadeSessao);
            this.gboxSessao.Controls.Add(this.txtSessaoAtual);
            this.gboxSessao.Controls.Add(this.lblSessaoAtual);
            this.gboxSessao.Controls.Add(this.lblUltimaDataSessao);
            this.gboxSessao.Controls.Add(this.lblCodigoVendaSessao);
            this.gboxSessao.Controls.Add(this.txtObservacaoSessao);
            this.gboxSessao.Controls.Add(this.lblObservacaoSessao);
            this.gboxSessao.Controls.Add(this.lblProcedimentoSessao);
            this.gboxSessao.Controls.Add(this.txtCodigoVendaSessao);
            this.gboxSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSessao.Location = new System.Drawing.Point(-4, 0);
            this.gboxSessao.Margin = new System.Windows.Forms.Padding(2);
            this.gboxSessao.Name = "gboxSessao";
            this.gboxSessao.Padding = new System.Windows.Forms.Padding(2);
            this.gboxSessao.Size = new System.Drawing.Size(1095, 703);
            this.gboxSessao.TabIndex = 0;
            this.gboxSessao.TabStop = false;
            this.gboxSessao.Text = "Sessão";
            // 
            // lblCodigoProcedimentoSessao
            // 
            this.lblCodigoProcedimentoSessao.AutoSize = true;
            this.lblCodigoProcedimentoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProcedimentoSessao.Location = new System.Drawing.Point(241, 70);
            this.lblCodigoProcedimentoSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProcedimentoSessao.Name = "lblCodigoProcedimentoSessao";
            this.lblCodigoProcedimentoSessao.Size = new System.Drawing.Size(47, 20);
            this.lblCodigoProcedimentoSessao.TabIndex = 271;
            this.lblCodigoProcedimentoSessao.Text = "Proc.";
            // 
            // txtCodigoProcedimentoSessao
            // 
            this.txtCodigoProcedimentoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProcedimentoSessao.Location = new System.Drawing.Point(292, 67);
            this.txtCodigoProcedimentoSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProcedimentoSessao.Name = "txtCodigoProcedimentoSessao";
            this.txtCodigoProcedimentoSessao.Size = new System.Drawing.Size(86, 26);
            this.txtCodigoProcedimentoSessao.TabIndex = 2;
            this.txtCodigoProcedimentoSessao.TabStop = false;
            // 
            // dtUltimaSessao
            // 
            this.dtUltimaSessao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtUltimaSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtUltimaSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtUltimaSessao.Location = new System.Drawing.Point(138, 154);
            this.dtUltimaSessao.MaxDate = new System.DateTime(2020, 7, 30, 0, 0, 0, 0);
            this.dtUltimaSessao.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtUltimaSessao.Name = "dtUltimaSessao";
            this.dtUltimaSessao.Size = new System.Drawing.Size(240, 26);
            this.dtUltimaSessao.TabIndex = 4;
            this.dtUltimaSessao.Value = new System.DateTime(2020, 7, 30, 0, 0, 0, 0);
            // 
            // lblClienteSessao
            // 
            this.lblClienteSessao.AutoSize = true;
            this.lblClienteSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteSessao.Location = new System.Drawing.Point(68, 203);
            this.lblClienteSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteSessao.Name = "lblClienteSessao";
            this.lblClienteSessao.Size = new System.Drawing.Size(61, 20);
            this.lblClienteSessao.TabIndex = 135;
            this.lblClienteSessao.Text = "Cliente";
            // 
            // txtClienteSessao
            // 
            this.txtClienteSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteSessao.Location = new System.Drawing.Point(138, 200);
            this.txtClienteSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtClienteSessao.Name = "txtClienteSessao";
            this.txtClienteSessao.Size = new System.Drawing.Size(590, 26);
            this.txtClienteSessao.TabIndex = 7;
            // 
            // btnCancelarSessao
            // 
            this.btnCancelarSessao.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarSessao.FlatAppearance.BorderSize = 0;
            this.btnCancelarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSessao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSessao.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarSessao.Location = new System.Drawing.Point(788, 333);
            this.btnCancelarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarSessao.Name = "btnCancelarSessao";
            this.btnCancelarSessao.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarSessao.TabIndex = 10;
            this.btnCancelarSessao.Text = "Cancelar";
            this.btnCancelarSessao.UseVisualStyleBackColor = false;
            this.btnCancelarSessao.Click += new System.EventHandler(this.btnCancelarSessao_Click);
            // 
            // btnEditarSessao
            // 
            this.btnEditarSessao.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarSessao.FlatAppearance.BorderSize = 0;
            this.btnEditarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSessao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSessao.ForeColor = System.Drawing.Color.Sienna;
            this.btnEditarSessao.Location = new System.Drawing.Point(788, 221);
            this.btnEditarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarSessao.Name = "btnEditarSessao";
            this.btnEditarSessao.Size = new System.Drawing.Size(160, 50);
            this.btnEditarSessao.TabIndex = 9;
            this.btnEditarSessao.Text = "Editar";
            this.btnEditarSessao.UseVisualStyleBackColor = false;
            this.btnEditarSessao.Click += new System.EventHandler(this.btnEditarSessao_Click);
            // 
            // btnSalvarSessao
            // 
            this.btnSalvarSessao.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarSessao.FlatAppearance.BorderSize = 0;
            this.btnSalvarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSessao.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSessao.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarSessao.Location = new System.Drawing.Point(788, 448);
            this.btnSalvarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarSessao.Name = "btnSalvarSessao";
            this.btnSalvarSessao.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarSessao.TabIndex = 11;
            this.btnSalvarSessao.Text = "Salvar";
            this.btnSalvarSessao.UseVisualStyleBackColor = false;
            this.btnSalvarSessao.Click += new System.EventHandler(this.btnSalvarSessao_Click);
            // 
            // txtProcedimentoSessao
            // 
            this.txtProcedimentoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimentoSessao.Location = new System.Drawing.Point(138, 111);
            this.txtProcedimentoSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtProcedimentoSessao.Name = "txtProcedimentoSessao";
            this.txtProcedimentoSessao.Size = new System.Drawing.Size(240, 26);
            this.txtProcedimentoSessao.TabIndex = 3;
            // 
            // txtQuantidadeSessao
            // 
            this.txtQuantidadeSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeSessao.Location = new System.Drawing.Point(533, 156);
            this.txtQuantidadeSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidadeSessao.Name = "txtQuantidadeSessao";
            this.txtQuantidadeSessao.Size = new System.Drawing.Size(195, 26);
            this.txtQuantidadeSessao.TabIndex = 6;
            // 
            // lblQuantidadeSessao
            // 
            this.lblQuantidadeSessao.AutoSize = true;
            this.lblQuantidadeSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeSessao.Location = new System.Drawing.Point(428, 159);
            this.lblQuantidadeSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidadeSessao.Name = "lblQuantidadeSessao";
            this.lblQuantidadeSessao.Size = new System.Drawing.Size(101, 20);
            this.lblQuantidadeSessao.TabIndex = 129;
            this.lblQuantidadeSessao.Text = "Total Sessões";
            // 
            // txtSessaoAtual
            // 
            this.txtSessaoAtual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessaoAtual.Location = new System.Drawing.Point(533, 111);
            this.txtSessaoAtual.Margin = new System.Windows.Forms.Padding(2);
            this.txtSessaoAtual.Name = "txtSessaoAtual";
            this.txtSessaoAtual.Size = new System.Drawing.Size(195, 26);
            this.txtSessaoAtual.TabIndex = 5;
            // 
            // lblSessaoAtual
            // 
            this.lblSessaoAtual.AutoSize = true;
            this.lblSessaoAtual.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessaoAtual.Location = new System.Drawing.Point(429, 114);
            this.lblSessaoAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSessaoAtual.Name = "lblSessaoAtual";
            this.lblSessaoAtual.Size = new System.Drawing.Size(100, 20);
            this.lblSessaoAtual.TabIndex = 128;
            this.lblSessaoAtual.Text = "Sessão Atual";
            // 
            // lblUltimaDataSessao
            // 
            this.lblUltimaDataSessao.AutoSize = true;
            this.lblUltimaDataSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaDataSessao.Location = new System.Drawing.Point(35, 159);
            this.lblUltimaDataSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUltimaDataSessao.Name = "lblUltimaDataSessao";
            this.lblUltimaDataSessao.Size = new System.Drawing.Size(94, 20);
            this.lblUltimaDataSessao.TabIndex = 127;
            this.lblUltimaDataSessao.Text = "Última Data";
            // 
            // lblCodigoVendaSessao
            // 
            this.lblCodigoVendaSessao.AutoSize = true;
            this.lblCodigoVendaSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVendaSessao.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoVendaSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoVendaSessao.Name = "lblCodigoVendaSessao";
            this.lblCodigoVendaSessao.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoVendaSessao.TabIndex = 126;
            this.lblCodigoVendaSessao.Text = "Venda";
            // 
            // txtObservacaoSessao
            // 
            this.txtObservacaoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoSessao.Location = new System.Drawing.Point(138, 248);
            this.txtObservacaoSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacaoSessao.Multiline = true;
            this.txtObservacaoSessao.Name = "txtObservacaoSessao";
            this.txtObservacaoSessao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacaoSessao.Size = new System.Drawing.Size(590, 250);
            this.txtObservacaoSessao.TabIndex = 8;
            // 
            // lblObservacaoSessao
            // 
            this.lblObservacaoSessao.AutoSize = true;
            this.lblObservacaoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoSessao.Location = new System.Drawing.Point(20, 251);
            this.lblObservacaoSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacaoSessao.Name = "lblObservacaoSessao";
            this.lblObservacaoSessao.Size = new System.Drawing.Size(109, 20);
            this.lblObservacaoSessao.TabIndex = 125;
            this.lblObservacaoSessao.Text = "Observações";
            // 
            // lblProcedimentoSessao
            // 
            this.lblProcedimentoSessao.AutoSize = true;
            this.lblProcedimentoSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimentoSessao.Location = new System.Drawing.Point(16, 114);
            this.lblProcedimentoSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcedimentoSessao.Name = "lblProcedimentoSessao";
            this.lblProcedimentoSessao.Size = new System.Drawing.Size(113, 20);
            this.lblProcedimentoSessao.TabIndex = 124;
            this.lblProcedimentoSessao.Text = "Procedimento";
            // 
            // txtCodigoVendaSessao
            // 
            this.txtCodigoVendaSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVendaSessao.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoVendaSessao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVendaSessao.Name = "txtCodigoVendaSessao";
            this.txtCodigoVendaSessao.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoVendaSessao.TabIndex = 1;
            this.txtCodigoVendaSessao.TabStop = false;
            // 
            // tpgConfiguracoesSessao
            // 
            this.tpgConfiguracoesSessao.BackColor = System.Drawing.Color.Transparent;
            this.tpgConfiguracoesSessao.Controls.Add(this.gboxSessao);
            this.tpgConfiguracoesSessao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesSessao.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesSessao.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesSessao.Name = "tpgConfiguracoesSessao";
            this.tpgConfiguracoesSessao.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesSessao.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesSessao.TabIndex = 1;
            this.tpgConfiguracoesSessao.Text = "Configurações";
            // 
            // btnExcluirSessao
            // 
            this.btnExcluirSessao.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirSessao.FlatAppearance.BorderSize = 0;
            this.btnExcluirSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSessao.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirSessao.Location = new System.Drawing.Point(88, 72);
            this.btnExcluirSessao.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirSessao.Name = "btnExcluirSessao";
            this.btnExcluirSessao.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirSessao.TabIndex = 5;
            this.btnExcluirSessao.Text = "Excluir";
            this.btnExcluirSessao.UseVisualStyleBackColor = false;
            this.btnExcluirSessao.Click += new System.EventHandler(this.btnExcluirSessao_Click);
            // 
            // tpgListarSessao
            // 
            this.tpgListarSessao.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarSessao.Controls.Add(this.chkExibirTodasSessoes);
            this.tpgListarSessao.Controls.Add(this.txtBuscarSessao);
            this.tpgListarSessao.Controls.Add(this.cboxBuscarSessao);
            this.tpgListarSessao.Controls.Add(this.btnBuscarSessao);
            this.tpgListarSessao.Controls.Add(this.lblBuscarSessao);
            this.tpgListarSessao.Controls.Add(this.chkExcluirSessao);
            this.tpgListarSessao.Controls.Add(this.dgvSessao);
            this.tpgListarSessao.Controls.Add(this.lblTotalSessao);
            this.tpgListarSessao.Controls.Add(this.btnExcluirSessao);
            this.tpgListarSessao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarSessao.Location = new System.Drawing.Point(4, 31);
            this.tpgListarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarSessao.Name = "tpgListarSessao";
            this.tpgListarSessao.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarSessao.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarSessao.TabIndex = 0;
            this.tpgListarSessao.Text = "Listar";
            // 
            // chkExibirTodasSessoes
            // 
            this.chkExibirTodasSessoes.AutoSize = true;
            this.chkExibirTodasSessoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExibirTodasSessoes.Location = new System.Drawing.Point(241, 71);
            this.chkExibirTodasSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.chkExibirTodasSessoes.Name = "chkExibirTodasSessoes";
            this.chkExibirTodasSessoes.Size = new System.Drawing.Size(167, 24);
            this.chkExibirTodasSessoes.TabIndex = 6;
            this.chkExibirTodasSessoes.Text = "Exibir todas sessões";
            this.chkExibirTodasSessoes.UseVisualStyleBackColor = true;
            this.chkExibirTodasSessoes.CheckedChanged += new System.EventHandler(this.chkExibirTodasSessoes_CheckedChanged);
            // 
            // btnBuscarSessao
            // 
            this.btnBuscarSessao.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarSessao.FlatAppearance.BorderSize = 0;
            this.btnBuscarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSessao.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarSessao.Location = new System.Drawing.Point(549, 16);
            this.btnBuscarSessao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarSessao.Name = "btnBuscarSessao";
            this.btnBuscarSessao.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarSessao.TabIndex = 3;
            this.btnBuscarSessao.Text = "Buscar";
            this.btnBuscarSessao.UseVisualStyleBackColor = false;
            this.btnBuscarSessao.Click += new System.EventHandler(this.btnBuscarSessao_Click);
            // 
            // lblBuscarSessao
            // 
            this.lblBuscarSessao.AutoSize = true;
            this.lblBuscarSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarSessao.Location = new System.Drawing.Point(26, 21);
            this.lblBuscarSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarSessao.Name = "lblBuscarSessao";
            this.lblBuscarSessao.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarSessao.TabIndex = 9;
            this.lblBuscarSessao.Text = "Buscar";
            // 
            // chkExcluirSessao
            // 
            this.chkExcluirSessao.AutoSize = true;
            this.chkExcluirSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirSessao.Location = new System.Drawing.Point(2, 79);
            this.chkExcluirSessao.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirSessao.Name = "chkExcluirSessao";
            this.chkExcluirSessao.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirSessao.TabIndex = 4;
            this.chkExcluirSessao.Text = "Excluir";
            this.chkExcluirSessao.UseVisualStyleBackColor = true;
            this.chkExcluirSessao.CheckedChanged += new System.EventHandler(this.chkExcluirSessao_CheckedChanged);
            // 
            // dgvSessao
            // 
            this.dgvSessao.AllowUserToAddRows = false;
            this.dgvSessao.AllowUserToDeleteRows = false;
            this.dgvSessao.AllowUserToOrderColumns = true;
            this.dgvSessao.BackgroundColor = System.Drawing.Color.White;
            this.dgvSessao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSessao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSessao.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSessao.ColumnHeadersHeight = 50;
            this.dgvSessao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvSessao.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSessao.EnableHeadersVisualStyles = false;
            this.dgvSessao.GridColor = System.Drawing.Color.Black;
            this.dgvSessao.Location = new System.Drawing.Point(0, 107);
            this.dgvSessao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSessao.MultiSelect = false;
            this.dgvSessao.Name = "dgvSessao";
            this.dgvSessao.ReadOnly = true;
            this.dgvSessao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessao.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSessao.RowHeadersVisible = false;
            this.dgvSessao.RowHeadersWidth = 51;
            this.dgvSessao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessao.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSessao.RowTemplate.Height = 24;
            this.dgvSessao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessao.Size = new System.Drawing.Size(1089, 541);
            this.dgvSessao.TabIndex = 7;
            this.dgvSessao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessao_CellContentClick);
            this.dgvSessao.DoubleClick += new System.EventHandler(this.dgvSessao_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // lblTotalSessao
            // 
            this.lblTotalSessao.AutoSize = true;
            this.lblTotalSessao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSessao.Location = new System.Drawing.Point(521, 72);
            this.lblTotalSessao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSessao.Name = "lblTotalSessao";
            this.lblTotalSessao.Size = new System.Drawing.Size(133, 20);
            this.lblTotalSessao.TabIndex = 5;
            this.lblTotalSessao.Text = "Total de Sessões: ";
            // 
            // tctrlSessao
            // 
            this.tctrlSessao.Controls.Add(this.tpgListarSessao);
            this.tctrlSessao.Controls.Add(this.tpgConfiguracoesSessao);
            this.tctrlSessao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlSessao.Location = new System.Drawing.Point(0, 3);
            this.tctrlSessao.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlSessao.Name = "tctrlSessao";
            this.tctrlSessao.SelectedIndex = 0;
            this.tctrlSessao.Size = new System.Drawing.Size(1095, 683);
            this.tctrlSessao.TabIndex = 22;
            this.tctrlSessao.SelectedIndexChanged += new System.EventHandler(this.tctrlSessao_SelectedIndexChanged);
            // 
            // ViewSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlSessao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSessao";
            this.Text = "Sessões";
            this.Load += new System.EventHandler(this.ViewSessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.gboxSessao.ResumeLayout(false);
            this.gboxSessao.PerformLayout();
            this.tpgConfiguracoesSessao.ResumeLayout(false);
            this.tpgListarSessao.ResumeLayout(false);
            this.tpgListarSessao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessao)).EndInit();
            this.tctrlSessao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tctrlSessao;
        private System.Windows.Forms.TabPage tpgListarSessao;
        private System.Windows.Forms.CheckBox chkExcluirSessao;
        private System.Windows.Forms.DataGridView dgvSessao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.Label lblTotalSessao;
        private System.Windows.Forms.Button btnExcluirSessao;
        private System.Windows.Forms.TabPage tpgConfiguracoesSessao;
        private System.Windows.Forms.GroupBox gboxSessao;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.TextBox txtProcedimentoSessao;
        private System.Windows.Forms.TextBox txtQuantidadeSessao;
        private System.Windows.Forms.Label lblQuantidadeSessao;
        private System.Windows.Forms.TextBox txtSessaoAtual;
        private System.Windows.Forms.Label lblSessaoAtual;
        private System.Windows.Forms.Label lblUltimaDataSessao;
        private System.Windows.Forms.Label lblCodigoVendaSessao;
        private System.Windows.Forms.TextBox txtObservacaoSessao;
        private System.Windows.Forms.Label lblObservacaoSessao;
        private System.Windows.Forms.Label lblProcedimentoSessao;
        private System.Windows.Forms.TextBox txtCodigoVendaSessao;
        private System.Windows.Forms.Button btnCancelarSessao;
        private System.Windows.Forms.Button btnEditarSessao;
        private System.Windows.Forms.Button btnSalvarSessao;
        private System.Windows.Forms.TextBox txtBuscarSessao;
        private System.Windows.Forms.ComboBox cboxBuscarSessao;
        private System.Windows.Forms.Button btnBuscarSessao;
        private System.Windows.Forms.Label lblBuscarSessao;
        private System.Windows.Forms.Label lblClienteSessao;
        private System.Windows.Forms.TextBox txtClienteSessao;
        private System.Windows.Forms.DateTimePicker dtUltimaSessao;
        private System.Windows.Forms.Label lblCodigoProcedimentoSessao;
        private System.Windows.Forms.TextBox txtCodigoProcedimentoSessao;
        private System.Windows.Forms.CheckBox chkExibirTodasSessoes;
    }
}