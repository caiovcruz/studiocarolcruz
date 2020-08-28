namespace View
{
    partial class ViewProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpgListarProduto = new System.Windows.Forms.TabPage();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gboxLote = new System.Windows.Forms.GroupBox();
            this.lblTotalLote = new System.Windows.Forms.Label();
            this.gboxListaProduto = new System.Windows.Forms.GroupBox();
            this.txtBuscarProduto = new System.Windows.Forms.TextBox();
            this.chkExcluirProduto = new System.Windows.Forms.CheckBox();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.lblBuscarProduto = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.tctrlProduto = new System.Windows.Forms.TabControl();
            this.tpgConfiguracoesProduto = new System.Windows.Forms.TabPage();
            this.gboxProduto = new System.Windows.Forms.GroupBox();
            this.txtArmazenamentoProduto = new System.Windows.Forms.TextBox();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblArmazenamentoProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpgListarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gboxLote.SuspendLayout();
            this.gboxListaProduto.SuspendLayout();
            this.tctrlProduto.SuspendLayout();
            this.tpgConfiguracoesProduto.SuspendLayout();
            this.gboxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // tpgListarProduto
            // 
            this.tpgListarProduto.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarProduto.Controls.Add(this.dgvProduto);
            this.tpgListarProduto.Controls.Add(this.gboxLote);
            this.tpgListarProduto.Controls.Add(this.btnBuscarProduto);
            this.tpgListarProduto.Controls.Add(this.gboxListaProduto);
            this.tpgListarProduto.Controls.Add(this.lblBuscarProduto);
            this.tpgListarProduto.Controls.Add(this.txtBuscarProduto);
            this.tpgListarProduto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarProduto.Location = new System.Drawing.Point(4, 31);
            this.tpgListarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarProduto.Name = "tpgListarProduto";
            this.tpgListarProduto.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarProduto.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarProduto.TabIndex = 0;
            this.tpgListarProduto.Text = "Listar";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.AllowUserToOrderColumns = true;
            this.dgvLote.BackgroundColor = System.Drawing.Color.White;
            this.dgvLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLote.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLote.ColumnHeadersHeight = 50;
            this.dgvLote.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvLote.EnableHeadersVisualStyles = false;
            this.dgvLote.GridColor = System.Drawing.Color.Black;
            this.dgvLote.Location = new System.Drawing.Point(72, 57);
            this.dgvLote.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLote.MultiSelect = false;
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.ReadOnly = true;
            this.dgvLote.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvLote.RowHeadersVisible = false;
            this.dgvLote.RowHeadersWidth = 51;
            this.dgvLote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLote.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvLote.RowTemplate.Height = 24;
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(472, 486);
            this.dgvLote.TabIndex = 6;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToOrderColumns = true;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProduto.ColumnHeadersHeight = 50;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProduto.EnableHeadersVisualStyles = false;
            this.dgvProduto.GridColor = System.Drawing.Color.Black;
            this.dgvProduto.Location = new System.Drawing.Point(0, 162);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProduto.RowTemplate.Height = 24;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(472, 486);
            this.dgvProduto.TabIndex = 5;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // gboxLote
            // 
            this.gboxLote.BackColor = System.Drawing.Color.White;
            this.gboxLote.Controls.Add(this.lblTotalLote);
            this.gboxLote.Controls.Add(this.dgvLote);
            this.gboxLote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxLote.Location = new System.Drawing.Point(547, 105);
            this.gboxLote.Name = "gboxLote";
            this.gboxLote.Size = new System.Drawing.Size(542, 551);
            this.gboxLote.TabIndex = 19;
            this.gboxLote.TabStop = false;
            this.gboxLote.Text = "Lote";
            // 
            // lblTotalLote
            // 
            this.lblTotalLote.AutoSize = true;
            this.lblTotalLote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLote.Location = new System.Drawing.Point(346, 30);
            this.lblTotalLote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLote.Name = "lblTotalLote";
            this.lblTotalLote.Size = new System.Drawing.Size(116, 20);
            this.lblTotalLote.TabIndex = 17;
            this.lblTotalLote.Text = "Total de Lotes: ";
            // 
            // gboxListaProduto
            // 
            this.gboxListaProduto.BackColor = System.Drawing.Color.White;
            this.gboxListaProduto.Controls.Add(this.chkExcluirProduto);
            this.gboxListaProduto.Controls.Add(this.btnExcluirProduto);
            this.gboxListaProduto.Controls.Add(this.lblTotalProduto);
            this.gboxListaProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxListaProduto.Location = new System.Drawing.Point(0, 105);
            this.gboxListaProduto.Name = "gboxListaProduto";
            this.gboxListaProduto.Size = new System.Drawing.Size(1087, 551);
            this.gboxListaProduto.TabIndex = 20;
            this.gboxListaProduto.TabStop = false;
            this.gboxListaProduto.Text = "Produto";
            // 
            // txtBuscarProduto
            // 
            this.txtBuscarProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduto.Location = new System.Drawing.Point(88, 19);
            this.txtBuscarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProduto.Name = "txtBuscarProduto";
            this.txtBuscarProduto.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarProduto.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.txtBuscarProduto, "Digite o nome do produto desejado");
            this.txtBuscarProduto.TextChanged += new System.EventHandler(this.txtBuscarProduto_TextChanged);
            // 
            // chkExcluirProduto
            // 
            this.chkExcluirProduto.AutoSize = true;
            this.chkExcluirProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirProduto.Location = new System.Drawing.Point(2, 29);
            this.chkExcluirProduto.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirProduto.Name = "chkExcluirProduto";
            this.chkExcluirProduto.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirProduto.TabIndex = 3;
            this.chkExcluirProduto.Text = "Excluir";
            this.chkExcluirProduto.UseVisualStyleBackColor = true;
            this.chkExcluirProduto.CheckedChanged += new System.EventHandler(this.chkExcluirProduto_CheckedChanged);
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProduto.Location = new System.Drawing.Point(254, 30);
            this.lblTotalProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(142, 20);
            this.lblTotalProduto.TabIndex = 5;
            this.lblTotalProduto.Text = "Total de Produtos: ";
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarProduto.Location = new System.Drawing.Point(389, 17);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarProduto.TabIndex = 2;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // lblBuscarProduto
            // 
            this.lblBuscarProduto.AutoSize = true;
            this.lblBuscarProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProduto.Location = new System.Drawing.Point(26, 22);
            this.lblBuscarProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarProduto.Name = "lblBuscarProduto";
            this.lblBuscarProduto.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarProduto.TabIndex = 0;
            this.lblBuscarProduto.Text = "Buscar";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirProduto.Location = new System.Drawing.Point(88, 22);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // tctrlProduto
            // 
            this.tctrlProduto.Controls.Add(this.tpgListarProduto);
            this.tctrlProduto.Controls.Add(this.tpgConfiguracoesProduto);
            this.tctrlProduto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlProduto.Location = new System.Drawing.Point(0, 3);
            this.tctrlProduto.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlProduto.Name = "tctrlProduto";
            this.tctrlProduto.SelectedIndex = 0;
            this.tctrlProduto.Size = new System.Drawing.Size(1095, 683);
            this.tctrlProduto.TabIndex = 21;
            this.tctrlProduto.SelectedIndexChanged += new System.EventHandler(this.tctrlProduto_SelectedIndexChanged);
            // 
            // tpgConfiguracoesProduto
            // 
            this.tpgConfiguracoesProduto.Controls.Add(this.gboxProduto);
            this.tpgConfiguracoesProduto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesProduto.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesProduto.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesProduto.Name = "tpgConfiguracoesProduto";
            this.tpgConfiguracoesProduto.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesProduto.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesProduto.TabIndex = 1;
            this.tpgConfiguracoesProduto.Text = "Configurações";
            this.tpgConfiguracoesProduto.UseVisualStyleBackColor = true;
            // 
            // gboxProduto
            // 
            this.gboxProduto.BackColor = System.Drawing.Color.White;
            this.gboxProduto.Controls.Add(this.txtArmazenamentoProduto);
            this.gboxProduto.Controls.Add(this.btnCancelarProduto);
            this.gboxProduto.Controls.Add(this.btnNovoProduto);
            this.gboxProduto.Controls.Add(this.btnEditarProduto);
            this.gboxProduto.Controls.Add(this.btnSalvarProduto);
            this.gboxProduto.Controls.Add(this.lblNomeProduto);
            this.gboxProduto.Controls.Add(this.lblCodigoProduto);
            this.gboxProduto.Controls.Add(this.lblArmazenamentoProduto);
            this.gboxProduto.Controls.Add(this.txtNomeProduto);
            this.gboxProduto.Controls.Add(this.txtCodigoProduto);
            this.gboxProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxProduto.Location = new System.Drawing.Point(2, 0);
            this.gboxProduto.Margin = new System.Windows.Forms.Padding(2);
            this.gboxProduto.Name = "gboxProduto";
            this.gboxProduto.Padding = new System.Windows.Forms.Padding(2);
            this.gboxProduto.Size = new System.Drawing.Size(1300, 692);
            this.gboxProduto.TabIndex = 0;
            this.gboxProduto.TabStop = false;
            this.gboxProduto.Text = "Produto";
            // 
            // txtArmazenamentoProduto
            // 
            this.txtArmazenamentoProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmazenamentoProduto.Location = new System.Drawing.Point(138, 162);
            this.txtArmazenamentoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtArmazenamentoProduto.Name = "txtArmazenamentoProduto";
            this.txtArmazenamentoProduto.Size = new System.Drawing.Size(221, 26);
            this.txtArmazenamentoProduto.TabIndex = 3;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarProduto.FlatAppearance.BorderSize = 0;
            this.btnCancelarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarProduto.Location = new System.Drawing.Point(427, 262);
            this.btnCancelarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarProduto.TabIndex = 6;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = false;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnNovoProduto.Location = new System.Drawing.Point(427, 67);
            this.btnNovoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(160, 50);
            this.btnNovoProduto.TabIndex = 4;
            this.btnNovoProduto.Text = "Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarProduto.FlatAppearance.BorderSize = 0;
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnEditarProduto.Location = new System.Drawing.Point(427, 165);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(160, 50);
            this.btnEditarProduto.TabIndex = 5;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarProduto.FlatAppearance.BorderSize = 0;
            this.btnSalvarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProduto.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarProduto.Location = new System.Drawing.Point(427, 358);
            this.btnSalvarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarProduto.TabIndex = 7;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(81, 117);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(53, 20);
            this.lblNomeProduto.TabIndex = 108;
            this.lblNomeProduto.Text = "Nome";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(64, 20);
            this.lblCodigoProduto.TabIndex = 107;
            this.lblCodigoProduto.Text = "Código";
            // 
            // lblArmazenamentoProduto
            // 
            this.lblArmazenamentoProduto.AutoSize = true;
            this.lblArmazenamentoProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmazenamentoProduto.Location = new System.Drawing.Point(4, 165);
            this.lblArmazenamentoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArmazenamentoProduto.Name = "lblArmazenamentoProduto";
            this.lblArmazenamentoProduto.Size = new System.Drawing.Size(130, 20);
            this.lblArmazenamentoProduto.TabIndex = 100;
            this.lblArmazenamentoProduto.Text = "Armazenamento";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(138, 114);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(221, 26);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.TabStop = false;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ViewProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProduto";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ViewProduto_Load);
            this.tpgListarProduto.ResumeLayout(false);
            this.tpgListarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gboxLote.ResumeLayout(false);
            this.gboxLote.PerformLayout();
            this.gboxListaProduto.ResumeLayout(false);
            this.gboxListaProduto.PerformLayout();
            this.tctrlProduto.ResumeLayout(false);
            this.tpgConfiguracoesProduto.ResumeLayout(false);
            this.gboxProduto.ResumeLayout(false);
            this.gboxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpgListarProduto;
        private System.Windows.Forms.CheckBox chkExcluirProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtBuscarProduto;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label lblBuscarProduto;
        private System.Windows.Forms.TabControl tctrlProduto;
        private System.Windows.Forms.TabPage tpgConfiguracoesProduto;
        private System.Windows.Forms.GroupBox gboxProduto;
        private System.Windows.Forms.TextBox txtArmazenamentoProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblArmazenamentoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.Label lblTotalLote;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.GroupBox gboxLote;
        private System.Windows.Forms.GroupBox gboxListaProduto;
    }
}