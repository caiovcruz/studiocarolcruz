﻿namespace View
{
    partial class ViewCategoria
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
            this.tctrlCategoria = new System.Windows.Forms.TabControl();
            this.tpgListarCategoria = new System.Windows.Forms.TabPage();
            this.chkExcluirCategoria = new System.Windows.Forms.CheckBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.lblTotalCategoria = new System.Windows.Forms.Label();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.tpgConfiguracoesCategoria = new System.Windows.Forms.TabPage();
            this.gboxCategoria = new System.Windows.Forms.GroupBox();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btnNovoCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.lblNomeCategoria = new System.Windows.Forms.Label();
            this.lblCodigoCategoria = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.lblDescricaoCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.tctrlCategoria.SuspendLayout();
            this.tpgListarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.tpgConfiguracoesCategoria.SuspendLayout();
            this.gboxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlCategoria
            // 
            this.tctrlCategoria.Controls.Add(this.tpgListarCategoria);
            this.tctrlCategoria.Controls.Add(this.tpgConfiguracoesCategoria);
            this.tctrlCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlCategoria.Location = new System.Drawing.Point(0, 3);
            this.tctrlCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlCategoria.Name = "tctrlCategoria";
            this.tctrlCategoria.SelectedIndex = 0;
            this.tctrlCategoria.Size = new System.Drawing.Size(1095, 683);
            this.tctrlCategoria.TabIndex = 21;
            this.tctrlCategoria.SelectedIndexChanged += new System.EventHandler(this.tctrlCategoria_SelectedIndexChanged);
            // 
            // tpgListarCategoria
            // 
            this.tpgListarCategoria.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarCategoria.Controls.Add(this.chkExcluirCategoria);
            this.tpgListarCategoria.Controls.Add(this.dgvCategoria);
            this.tpgListarCategoria.Controls.Add(this.txtBuscarCategoria);
            this.tpgListarCategoria.Controls.Add(this.lblTotalCategoria);
            this.tpgListarCategoria.Controls.Add(this.btnBuscarCategoria);
            this.tpgListarCategoria.Controls.Add(this.btnExcluirCategoria);
            this.tpgListarCategoria.Controls.Add(this.lblBuscarCategoria);
            this.tpgListarCategoria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarCategoria.Location = new System.Drawing.Point(4, 31);
            this.tpgListarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarCategoria.Name = "tpgListarCategoria";
            this.tpgListarCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarCategoria.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarCategoria.TabIndex = 0;
            this.tpgListarCategoria.Text = "Listar";
            // 
            // chkExcluirCategoria
            // 
            this.chkExcluirCategoria.AutoSize = true;
            this.chkExcluirCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirCategoria.Location = new System.Drawing.Point(2, 79);
            this.chkExcluirCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirCategoria.Name = "chkExcluirCategoria";
            this.chkExcluirCategoria.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirCategoria.TabIndex = 3;
            this.chkExcluirCategoria.Text = "Excluir";
            this.chkExcluirCategoria.UseVisualStyleBackColor = true;
            this.chkExcluirCategoria.CheckedChanged += new System.EventHandler(this.chkExcluirCategoria_CheckedChanged);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToOrderColumns = true;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.ColumnHeadersHeight = 50;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoria.EnableHeadersVisualStyles = false;
            this.dgvCategoria.GridColor = System.Drawing.Color.Black;
            this.dgvCategoria.Location = new System.Drawing.Point(0, 107);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategoria.RowTemplate.Height = 24;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(1089, 541);
            this.dgvCategoria.TabIndex = 5;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            this.dgvCategoria.DoubleClick += new System.EventHandler(this.dgvCategoria_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(88, 19);
            this.txtBuscarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarCategoria.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.txtBuscarCategoria, "Digite o nome da categoria desejada");
            this.txtBuscarCategoria.TextChanged += new System.EventHandler(this.txtBuscarCategoria_TextChanged);
            // 
            // lblTotalCategoria
            // 
            this.lblTotalCategoria.AutoSize = true;
            this.lblTotalCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategoria.Location = new System.Drawing.Point(339, 72);
            this.lblTotalCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCategoria.Name = "lblTotalCategoria";
            this.lblTotalCategoria.Size = new System.Drawing.Size(155, 20);
            this.lblTotalCategoria.TabIndex = 5;
            this.lblTotalCategoria.Text = "Total de Categorias:";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarCategoria.FlatAppearance.BorderSize = 0;
            this.btnBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(389, 17);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarCategoria.TabIndex = 2;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirCategoria.FlatAppearance.BorderSize = 0;
            this.btnExcluirCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirCategoria.Location = new System.Drawing.Point(88, 72);
            this.btnExcluirCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirCategoria.TabIndex = 4;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = false;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCategoria.Location = new System.Drawing.Point(26, 22);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarCategoria.TabIndex = 0;
            this.lblBuscarCategoria.Text = "Buscar";
            // 
            // tpgConfiguracoesCategoria
            // 
            this.tpgConfiguracoesCategoria.BackColor = System.Drawing.Color.Transparent;
            this.tpgConfiguracoesCategoria.Controls.Add(this.gboxCategoria);
            this.tpgConfiguracoesCategoria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesCategoria.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCategoria.Name = "tpgConfiguracoesCategoria";
            this.tpgConfiguracoesCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesCategoria.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesCategoria.TabIndex = 1;
            this.tpgConfiguracoesCategoria.Text = "Configurações";
            // 
            // gboxCategoria
            // 
            this.gboxCategoria.BackColor = System.Drawing.Color.White;
            this.gboxCategoria.Controls.Add(this.btnCancelarCategoria);
            this.gboxCategoria.Controls.Add(this.btnNovoCategoria);
            this.gboxCategoria.Controls.Add(this.btnEditarCategoria);
            this.gboxCategoria.Controls.Add(this.btnSalvarCategoria);
            this.gboxCategoria.Controls.Add(this.lblNomeCategoria);
            this.gboxCategoria.Controls.Add(this.lblCodigoCategoria);
            this.gboxCategoria.Controls.Add(this.txtDescricaoCategoria);
            this.gboxCategoria.Controls.Add(this.lblDescricaoCategoria);
            this.gboxCategoria.Controls.Add(this.txtNomeCategoria);
            this.gboxCategoria.Controls.Add(this.txtCodigoCategoria);
            this.gboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCategoria.Location = new System.Drawing.Point(-4, 0);
            this.gboxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.gboxCategoria.Name = "gboxCategoria";
            this.gboxCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.gboxCategoria.Size = new System.Drawing.Size(1095, 703);
            this.gboxCategoria.TabIndex = 0;
            this.gboxCategoria.TabStop = false;
            this.gboxCategoria.Text = "Categoria";
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarCategoria.FlatAppearance.BorderSize = 0;
            this.btnCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarCategoria.Location = new System.Drawing.Point(771, 285);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarCategoria.TabIndex = 6;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btnNovoCategoria
            // 
            this.btnNovoCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnNovoCategoria.FlatAppearance.BorderSize = 0;
            this.btnNovoCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnNovoCategoria.Location = new System.Drawing.Point(771, 71);
            this.btnNovoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoCategoria.Name = "btnNovoCategoria";
            this.btnNovoCategoria.Size = new System.Drawing.Size(160, 50);
            this.btnNovoCategoria.TabIndex = 4;
            this.btnNovoCategoria.Text = "Novo";
            this.btnNovoCategoria.UseVisualStyleBackColor = false;
            this.btnNovoCategoria.Click += new System.EventHandler(this.btnNovoCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnEditarCategoria.Location = new System.Drawing.Point(771, 180);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(160, 50);
            this.btnEditarCategoria.TabIndex = 5;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarCategoria.FlatAppearance.BorderSize = 0;
            this.btnSalvarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCategoria.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCategoria.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarCategoria.Location = new System.Drawing.Point(771, 401);
            this.btnSalvarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarCategoria.TabIndex = 7;
            this.btnSalvarCategoria.Text = "Salvar";
            this.btnSalvarCategoria.UseVisualStyleBackColor = false;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // lblNomeCategoria
            // 
            this.lblNomeCategoria.AutoSize = true;
            this.lblNomeCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCategoria.Location = new System.Drawing.Point(81, 116);
            this.lblNomeCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCategoria.Name = "lblNomeCategoria";
            this.lblNomeCategoria.Size = new System.Drawing.Size(53, 20);
            this.lblNomeCategoria.TabIndex = 108;
            this.lblNomeCategoria.Text = "Nome";
            // 
            // lblCodigoCategoria
            // 
            this.lblCodigoCategoria.AutoSize = true;
            this.lblCodigoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCategoria.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoCategoria.Name = "lblCodigoCategoria";
            this.lblCodigoCategoria.Size = new System.Drawing.Size(64, 20);
            this.lblCodigoCategoria.TabIndex = 107;
            this.lblCodigoCategoria.Text = "Código";
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(138, 161);
            this.txtDescricaoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoCategoria.Multiline = true;
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(580, 290);
            this.txtDescricaoCategoria.TabIndex = 3;
            // 
            // lblDescricaoCategoria
            // 
            this.lblDescricaoCategoria.AutoSize = true;
            this.lblDescricaoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCategoria.Location = new System.Drawing.Point(50, 164);
            this.lblDescricaoCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            this.lblDescricaoCategoria.Size = new System.Drawing.Size(84, 20);
            this.lblDescricaoCategoria.TabIndex = 100;
            this.lblDescricaoCategoria.Text = "Descrição";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(138, 113);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(240, 26);
            this.txtNomeCategoria.TabIndex = 2;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCategoria.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoCategoria.TabIndex = 1;
            this.txtCodigoCategoria.TabStop = false;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // ViewCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCategoria";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.ViewCategoria_Load);
            this.tctrlCategoria.ResumeLayout(false);
            this.tpgListarCategoria.ResumeLayout(false);
            this.tpgListarCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.tpgConfiguracoesCategoria.ResumeLayout(false);
            this.gboxCategoria.ResumeLayout(false);
            this.gboxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlCategoria;
        private System.Windows.Forms.TabPage tpgListarCategoria;
        private System.Windows.Forms.CheckBox chkExcluirCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Label lblTotalCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.TabPage tpgConfiguracoesCategoria;
        private System.Windows.Forms.GroupBox gboxCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btnNovoCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.Label lblCodigoCategoria;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.Label lblDescricaoCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
    }
}