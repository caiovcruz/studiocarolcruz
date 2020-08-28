﻿namespace View
{
    partial class ViewCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboxBuscarCliente = new System.Windows.Forms.ComboBox();
            this.dtpNascimentoCliente = new System.Windows.Forms.DateTimePicker();
            this.txtCEPCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimentoCliente = new System.Windows.Forms.Label();
            this.cboxUFCliente = new System.Windows.Forms.ComboBox();
            this.lblUFCliente = new System.Windows.Forms.Label();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.lblComplementoCliente = new System.Windows.Forms.Label();
            this.chkExcluirCliente = new System.Windows.Forms.CheckBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtComplementoCliente = new System.Windows.Forms.TextBox();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.lblNumCasaCliente = new System.Windows.Forms.Label();
            this.txtNumCasaCliente = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalCliente = new System.Windows.Forms.Label();
            this.gboxCliente = new System.Windows.Forms.GroupBox();
            this.lblRuaCliente = new System.Windows.Forms.Label();
            this.txtRuaCliente = new System.Windows.Forms.TextBox();
            this.cboxSexoCliente = new System.Windows.Forms.ComboBox();
            this.lblCEPCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblSexoCliente = new System.Windows.Forms.Label();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.tctrlCliente = new System.Windows.Forms.TabControl();
            this.tpgListarCliente = new System.Windows.Forms.TabPage();
            this.txtBuscarNomeCliente = new System.Windows.Forms.TextBox();
            this.txtBuscarCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.tpgConfiguracoesCliente = new System.Windows.Forms.TabPage();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gboxCliente.SuspendLayout();
            this.tctrlCliente.SuspendLayout();
            this.tpgListarCliente.SuspendLayout();
            this.tpgConfiguracoesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxBuscarCliente
            // 
            this.cboxBuscarCliente.BackColor = System.Drawing.Color.White;
            this.cboxBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBuscarCliente.FormattingEnabled = true;
            this.cboxBuscarCliente.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cboxBuscarCliente.Location = new System.Drawing.Point(88, 19);
            this.cboxBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuscarCliente.Name = "cboxBuscarCliente";
            this.cboxBuscarCliente.Size = new System.Drawing.Size(68, 28);
            this.cboxBuscarCliente.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.cboxBuscarCliente, "Selecione o método de busca desejado");
            this.cboxBuscarCliente.SelectedIndexChanged += new System.EventHandler(this.cboBuscarCliente_SelectedIndexChanged);
            // 
            // dtpNascimentoCliente
            // 
            this.dtpNascimentoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimentoCliente.Location = new System.Drawing.Point(365, 153);
            this.dtpNascimentoCliente.MaxDate = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            this.dtpNascimentoCliente.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimentoCliente.Name = "dtpNascimentoCliente";
            this.dtpNascimentoCliente.Size = new System.Drawing.Size(117, 26);
            this.dtpNascimentoCliente.TabIndex = 3;
            this.dtpNascimentoCliente.Value = new System.DateTime(2020, 5, 19, 0, 0, 0, 0);
            // 
            // txtCEPCliente
            // 
            this.txtCEPCliente.BeepOnError = true;
            this.txtCEPCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEPCliente.Location = new System.Drawing.Point(137, 282);
            this.txtCEPCliente.Mask = "00000-000";
            this.txtCEPCliente.Name = "txtCEPCliente";
            this.txtCEPCliente.Size = new System.Drawing.Size(85, 26);
            this.txtCEPCliente.TabIndex = 7;
            this.txtCEPCliente.Text = "99999999";
            this.txtCEPCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCEPCliente.ValidatingType = typeof(System.DateTime);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.BeepOnError = true;
            this.txtCPFCliente.Culture = new System.Globalization.CultureInfo("en-US");
            this.txtCPFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFCliente.Location = new System.Drawing.Point(138, 153);
            this.txtCPFCliente.Mask = "000.000.000-00";
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(120, 26);
            this.txtCPFCliente.TabIndex = 2;
            this.txtCPFCliente.Text = "99999999999";
            this.txtCPFCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.BeepOnError = true;
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(137, 197);
            this.txtTelefoneCliente.Mask = "(00) 00000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(120, 26);
            this.txtTelefoneCliente.TabIndex = 5;
            this.txtTelefoneCliente.Text = "99999999999";
            this.txtTelefoneCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNascimentoCliente
            // 
            this.lblNascimentoCliente.AutoSize = true;
            this.lblNascimentoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimentoCliente.Location = new System.Drawing.Point(270, 156);
            this.lblNascimentoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNascimentoCliente.Name = "lblNascimentoCliente";
            this.lblNascimentoCliente.Size = new System.Drawing.Size(90, 20);
            this.lblNascimentoCliente.TabIndex = 142;
            this.lblNascimentoCliente.Text = "Data Nasc.";
            // 
            // cboxUFCliente
            // 
            this.cboxUFCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUFCliente.FormattingEnabled = true;
            this.cboxUFCliente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cboxUFCliente.Location = new System.Drawing.Point(413, 419);
            this.cboxUFCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboxUFCliente.Name = "cboxUFCliente";
            this.cboxUFCliente.Size = new System.Drawing.Size(100, 28);
            this.cboxUFCliente.TabIndex = 13;
            this.ttmesagem.SetToolTip(this.cboxUFCliente, "Selecione a UF da Cidade do cliente");
            // 
            // lblUFCliente
            // 
            this.lblUFCliente.AutoSize = true;
            this.lblUFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFCliente.Location = new System.Drawing.Point(353, 422);
            this.lblUFCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUFCliente.Name = "lblUFCliente";
            this.lblUFCliente.Size = new System.Drawing.Size(58, 20);
            this.lblUFCliente.TabIndex = 139;
            this.lblUFCliente.Text = "Estado";
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(67, 422);
            this.lblCidadeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(64, 20);
            this.lblCidadeCliente.TabIndex = 137;
            this.lblCidadeCliente.Text = "Cidade";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCliente.Location = new System.Drawing.Point(137, 419);
            this.txtCidadeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(202, 26);
            this.txtCidadeCliente.TabIndex = 12;
            // 
            // lblComplementoCliente
            // 
            this.lblComplementoCliente.AutoSize = true;
            this.lblComplementoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplementoCliente.Location = new System.Drawing.Point(350, 376);
            this.lblComplementoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplementoCliente.Name = "lblComplementoCliente";
            this.lblComplementoCliente.Size = new System.Drawing.Size(114, 20);
            this.lblComplementoCliente.TabIndex = 135;
            this.lblComplementoCliente.Text = "Complemento";
            // 
            // chkExcluirCliente
            // 
            this.chkExcluirCliente.AutoSize = true;
            this.chkExcluirCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirCliente.Location = new System.Drawing.Point(2, 79);
            this.chkExcluirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirCliente.Name = "chkExcluirCliente";
            this.chkExcluirCliente.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirCliente.TabIndex = 4;
            this.chkExcluirCliente.Text = "Excluir";
            this.chkExcluirCliente.UseVisualStyleBackColor = true;
            this.chkExcluirCliente.CheckedChanged += new System.EventHandler(this.chkExcluirCliente_CheckedChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarCliente.Location = new System.Drawing.Point(475, 17);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirCliente.Location = new System.Drawing.Point(88, 72);
            this.btnExcluirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirCliente.TabIndex = 5;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.Location = new System.Drawing.Point(26, 22);
            this.lblBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Buscar";
            // 
            // txtComplementoCliente
            // 
            this.txtComplementoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoCliente.Location = new System.Drawing.Point(468, 373);
            this.txtComplementoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtComplementoCliente.Name = "txtComplementoCliente";
            this.txtComplementoCliente.Size = new System.Drawing.Size(253, 26);
            this.txtComplementoCliente.TabIndex = 11;
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCliente.Location = new System.Drawing.Point(83, 376);
            this.lblBairroCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(51, 20);
            this.lblBairroCliente.TabIndex = 133;
            this.lblBairroCliente.Text = "Bairro";
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCliente.Location = new System.Drawing.Point(137, 373);
            this.txtBairroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(203, 26);
            this.txtBairroCliente.TabIndex = 10;
            // 
            // lblNumCasaCliente
            // 
            this.lblNumCasaCliente.AutoSize = true;
            this.lblNumCasaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCasaCliente.Location = new System.Drawing.Point(606, 331);
            this.lblNumCasaCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCasaCliente.Name = "lblNumCasaCliente";
            this.lblNumCasaCliente.Size = new System.Drawing.Size(26, 20);
            this.lblNumCasaCliente.TabIndex = 131;
            this.lblNumCasaCliente.Text = "Nº";
            // 
            // txtNumCasaCliente
            // 
            this.txtNumCasaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCasaCliente.Location = new System.Drawing.Point(636, 328);
            this.txtNumCasaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCasaCliente.Name = "txtNumCasaCliente";
            this.txtNumCasaCliente.Size = new System.Drawing.Size(85, 26);
            this.txtNumCasaCliente.TabIndex = 9;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeight = 50;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.Black;
            this.dgvCliente.Location = new System.Drawing.Point(0, 107);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1089, 541);
            this.dgvCliente.TabIndex = 6;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // lblTotalCliente
            // 
            this.lblTotalCliente.AutoSize = true;
            this.lblTotalCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCliente.Location = new System.Drawing.Point(444, 72);
            this.lblTotalCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCliente.Name = "lblTotalCliente";
            this.lblTotalCliente.Size = new System.Drawing.Size(136, 20);
            this.lblTotalCliente.TabIndex = 5;
            this.lblTotalCliente.Text = "Total de Clientes: ";
            // 
            // gboxCliente
            // 
            this.gboxCliente.BackColor = System.Drawing.Color.White;
            this.gboxCliente.Controls.Add(this.dtpNascimentoCliente);
            this.gboxCliente.Controls.Add(this.txtCEPCliente);
            this.gboxCliente.Controls.Add(this.txtCPFCliente);
            this.gboxCliente.Controls.Add(this.txtTelefoneCliente);
            this.gboxCliente.Controls.Add(this.lblNascimentoCliente);
            this.gboxCliente.Controls.Add(this.cboxUFCliente);
            this.gboxCliente.Controls.Add(this.lblUFCliente);
            this.gboxCliente.Controls.Add(this.lblCidadeCliente);
            this.gboxCliente.Controls.Add(this.txtCidadeCliente);
            this.gboxCliente.Controls.Add(this.lblComplementoCliente);
            this.gboxCliente.Controls.Add(this.txtComplementoCliente);
            this.gboxCliente.Controls.Add(this.lblBairroCliente);
            this.gboxCliente.Controls.Add(this.txtBairroCliente);
            this.gboxCliente.Controls.Add(this.lblNumCasaCliente);
            this.gboxCliente.Controls.Add(this.txtNumCasaCliente);
            this.gboxCliente.Controls.Add(this.lblRuaCliente);
            this.gboxCliente.Controls.Add(this.txtRuaCliente);
            this.gboxCliente.Controls.Add(this.cboxSexoCliente);
            this.gboxCliente.Controls.Add(this.lblCEPCliente);
            this.gboxCliente.Controls.Add(this.lblEmailCliente);
            this.gboxCliente.Controls.Add(this.txtEmailCliente);
            this.gboxCliente.Controls.Add(this.lblTelefoneCliente);
            this.gboxCliente.Controls.Add(this.lblCPFCliente);
            this.gboxCliente.Controls.Add(this.lblSexoCliente);
            this.gboxCliente.Controls.Add(this.btnCancelarCliente);
            this.gboxCliente.Controls.Add(this.btnNovoCliente);
            this.gboxCliente.Controls.Add(this.btnEditarCliente);
            this.gboxCliente.Controls.Add(this.btnSalvarCliente);
            this.gboxCliente.Controls.Add(this.lblNomeCliente);
            this.gboxCliente.Controls.Add(this.lblCodigoCliente);
            this.gboxCliente.Controls.Add(this.txtNomeCliente);
            this.gboxCliente.Controls.Add(this.txtCodigoCliente);
            this.gboxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCliente.Location = new System.Drawing.Point(-4, 0);
            this.gboxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gboxCliente.Name = "gboxCliente";
            this.gboxCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gboxCliente.Size = new System.Drawing.Size(1095, 703);
            this.gboxCliente.TabIndex = 0;
            this.gboxCliente.TabStop = false;
            this.gboxCliente.Text = "Cliente";
            // 
            // lblRuaCliente
            // 
            this.lblRuaCliente.AutoSize = true;
            this.lblRuaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaCliente.Location = new System.Drawing.Point(93, 331);
            this.lblRuaCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuaCliente.Name = "lblRuaCliente";
            this.lblRuaCliente.Size = new System.Drawing.Size(37, 20);
            this.lblRuaCliente.TabIndex = 129;
            this.lblRuaCliente.Text = "Rua";
            // 
            // txtRuaCliente
            // 
            this.txtRuaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCliente.Location = new System.Drawing.Point(138, 328);
            this.txtRuaCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtRuaCliente.Name = "txtRuaCliente";
            this.txtRuaCliente.Size = new System.Drawing.Size(464, 26);
            this.txtRuaCliente.TabIndex = 8;
            // 
            // cboxSexoCliente
            // 
            this.cboxSexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSexoCliente.FormattingEnabled = true;
            this.cboxSexoCliente.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboxSexoCliente.Location = new System.Drawing.Point(543, 153);
            this.cboxSexoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboxSexoCliente.Name = "cboxSexoCliente";
            this.cboxSexoCliente.Size = new System.Drawing.Size(78, 28);
            this.cboxSexoCliente.TabIndex = 4;
            this.ttmesagem.SetToolTip(this.cboxSexoCliente, "Selecione o sexo do cliente");
            // 
            // lblCEPCliente
            // 
            this.lblCEPCliente.AutoSize = true;
            this.lblCEPCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEPCliente.Location = new System.Drawing.Point(94, 285);
            this.lblCEPCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEPCliente.Name = "lblCEPCliente";
            this.lblCEPCliente.Size = new System.Drawing.Size(38, 20);
            this.lblCEPCliente.TabIndex = 126;
            this.lblCEPCliente.Text = "CEP";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.Location = new System.Drawing.Point(270, 200);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(51, 20);
            this.lblEmailCliente.TabIndex = 124;
            this.lblEmailCliente.Text = "E-mail";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(325, 197);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(244, 26);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(63, 200);
            this.lblTelefoneCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(71, 20);
            this.lblTelefoneCliente.TabIndex = 122;
            this.lblTelefoneCliente.Text = "Telefone";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(94, 156);
            this.lblCPFCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(37, 20);
            this.lblCPFCliente.TabIndex = 120;
            this.lblCPFCliente.Text = "CPF";
            // 
            // lblSexoCliente
            // 
            this.lblSexoCliente.AutoSize = true;
            this.lblSexoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoCliente.Location = new System.Drawing.Point(496, 156);
            this.lblSexoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexoCliente.Name = "lblSexoCliente";
            this.lblSexoCliente.Size = new System.Drawing.Size(43, 20);
            this.lblSexoCliente.TabIndex = 118;
            this.lblSexoCliente.Text = "Sexo";
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarCliente.FlatAppearance.BorderSize = 0;
            this.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarCliente.Location = new System.Drawing.Point(783, 285);
            this.btnCancelarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarCliente.TabIndex = 16;
            this.btnCancelarCliente.Text = "Cancelar";
            this.btnCancelarCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnNovoCliente.Location = new System.Drawing.Point(783, 67);
            this.btnNovoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(160, 50);
            this.btnNovoCliente.TabIndex = 14;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = false;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnEditarCliente.Location = new System.Drawing.Point(783, 173);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(160, 50);
            this.btnEditarCliente.TabIndex = 15;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarCliente.FlatAppearance.BorderSize = 0;
            this.btnSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliente.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarCliente.Location = new System.Drawing.Point(783, 397);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarCliente.TabIndex = 17;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(80, 113);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(53, 20);
            this.lblNomeCliente.TabIndex = 108;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(64, 20);
            this.lblCodigoCliente.TabIndex = 107;
            this.lblCodigoCliente.Text = "Código";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(138, 110);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(512, 26);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.TabStop = false;
            // 
            // tctrlCliente
            // 
            this.tctrlCliente.Controls.Add(this.tpgListarCliente);
            this.tctrlCliente.Controls.Add(this.tpgConfiguracoesCliente);
            this.tctrlCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlCliente.Location = new System.Drawing.Point(0, 3);
            this.tctrlCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlCliente.Name = "tctrlCliente";
            this.tctrlCliente.SelectedIndex = 0;
            this.tctrlCliente.Size = new System.Drawing.Size(1095, 683);
            this.tctrlCliente.TabIndex = 20;
            this.tctrlCliente.SelectedIndexChanged += new System.EventHandler(this.tctrlCliente_SelectedIndexChanged);
            // 
            // tpgListarCliente
            // 
            this.tpgListarCliente.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarCliente.Controls.Add(this.txtBuscarNomeCliente);
            this.tpgListarCliente.Controls.Add(this.txtBuscarCPFCliente);
            this.tpgListarCliente.Controls.Add(this.cboxBuscarCliente);
            this.tpgListarCliente.Controls.Add(this.chkExcluirCliente);
            this.tpgListarCliente.Controls.Add(this.dgvCliente);
            this.tpgListarCliente.Controls.Add(this.lblTotalCliente);
            this.tpgListarCliente.Controls.Add(this.btnBuscarCliente);
            this.tpgListarCliente.Controls.Add(this.btnExcluirCliente);
            this.tpgListarCliente.Controls.Add(this.lblBuscarCliente);
            this.tpgListarCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarCliente.Location = new System.Drawing.Point(4, 31);
            this.tpgListarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarCliente.Name = "tpgListarCliente";
            this.tpgListarCliente.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarCliente.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarCliente.TabIndex = 0;
            this.tpgListarCliente.Text = "Listar";
            // 
            // txtBuscarNomeCliente
            // 
            this.txtBuscarNomeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNomeCliente.Location = new System.Drawing.Point(173, 19);
            this.txtBuscarNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarNomeCliente.Name = "txtBuscarNomeCliente";
            this.txtBuscarNomeCliente.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarNomeCliente.TabIndex = 2;
            this.ttmesagem.SetToolTip(this.txtBuscarNomeCliente, "Digite o nome do cliente desejado");
            this.txtBuscarNomeCliente.Visible = false;
            this.txtBuscarNomeCliente.TextChanged += new System.EventHandler(this.txtBuscarNomeCliente_TextChanged);
            // 
            // txtBuscarCPFCliente
            // 
            this.txtBuscarCPFCliente.BeepOnError = true;
            this.txtBuscarCPFCliente.Culture = new System.Globalization.CultureInfo("en-US");
            this.txtBuscarCPFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCPFCliente.Location = new System.Drawing.Point(173, 19);
            this.txtBuscarCPFCliente.Mask = "000.000.000-00";
            this.txtBuscarCPFCliente.Name = "txtBuscarCPFCliente";
            this.txtBuscarCPFCliente.Size = new System.Drawing.Size(120, 26);
            this.txtBuscarCPFCliente.TabIndex = 7;
            this.txtBuscarCPFCliente.Text = "99999999999";
            this.txtBuscarCPFCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ttmesagem.SetToolTip(this.txtBuscarCPFCliente, "Digite o CPF do cliente desejado");
            this.txtBuscarCPFCliente.Visible = false;
            this.txtBuscarCPFCliente.TextChanged += new System.EventHandler(this.txtBuscarCPFCliente_TextChanged);
            // 
            // tpgConfiguracoesCliente
            // 
            this.tpgConfiguracoesCliente.Controls.Add(this.gboxCliente);
            this.tpgConfiguracoesCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesCliente.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCliente.Name = "tpgConfiguracoesCliente";
            this.tpgConfiguracoesCliente.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCliente.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesCliente.TabIndex = 1;
            this.tpgConfiguracoesCliente.Text = "Configurações";
            this.tpgConfiguracoesCliente.UseVisualStyleBackColor = true;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ViewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ViewCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gboxCliente.ResumeLayout(false);
            this.gboxCliente.PerformLayout();
            this.tctrlCliente.ResumeLayout(false);
            this.tpgListarCliente.ResumeLayout(false);
            this.tpgListarCliente.PerformLayout();
            this.tpgConfiguracoesCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtpNascimentoCliente;
        private System.Windows.Forms.MaskedTextBox txtCEPCliente;
        private System.Windows.Forms.MaskedTextBox txtCPFCliente;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        private System.Windows.Forms.Label lblNascimentoCliente;
        private System.Windows.Forms.ComboBox cboxUFCliente;
        private System.Windows.Forms.Label lblUFCliente;
        private System.Windows.Forms.Label lblCidadeCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        private System.Windows.Forms.Label lblComplementoCliente;
        private System.Windows.Forms.CheckBox chkExcluirCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.TextBox txtComplementoCliente;
        private System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        private System.Windows.Forms.Label lblNumCasaCliente;
        private System.Windows.Forms.TextBox txtNumCasaCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblTotalCliente;
        private System.Windows.Forms.GroupBox gboxCliente;
        private System.Windows.Forms.Label lblRuaCliente;
        private System.Windows.Forms.TextBox txtRuaCliente;
        private System.Windows.Forms.ComboBox cboxSexoCliente;
        private System.Windows.Forms.Label lblCEPCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.Label lblSexoCliente;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TabControl tctrlCliente;
        private System.Windows.Forms.TabPage tpgListarCliente;
        private System.Windows.Forms.TabPage tpgConfiguracoesCliente;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPFCliente;
        private System.Windows.Forms.TextBox txtBuscarNomeCliente;
    }
}