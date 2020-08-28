namespace View
{
    partial class ViewBaixaEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtInicioBuscar = new System.Windows.Forms.DateTimePicker();
            this.tctrlBaixaEstoque = new System.Windows.Forms.TabControl();
            this.tpgListarBaixaEstoque = new System.Windows.Forms.TabPage();
            this.lblBuscarProdutoBaixaEstoque = new System.Windows.Forms.Label();
            this.txtBuscarProdutoBaixaEstoque = new System.Windows.Forms.TextBox();
            this.btnBuscarBaixaEstoque = new System.Windows.Forms.Button();
            this.chkBuscarBaixaEstoque = new System.Windows.Forms.CheckBox();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtFinalBuscar = new System.Windows.Forms.DateTimePicker();
            this.chkExcluirBaixaEstoque = new System.Windows.Forms.CheckBox();
            this.dgvBaixaEstoque = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalBaixaEstoque = new System.Windows.Forms.Label();
            this.btnExcluirBaixaEstoque = new System.Windows.Forms.Button();
            this.tpgConfiguracoesBaixaEstoque = new System.Windows.Forms.TabPage();
            this.gboxBaixaEstoque = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeLoteProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLoteProduto = new System.Windows.Forms.Label();
            this.cboxLoteProdutoBaixaEstoque = new System.Windows.Forms.ComboBox();
            this.lblLoteProdutoBaixaEstoque = new System.Windows.Forms.Label();
            this.txtQuantidadeProdutoBaixaEstoque = new System.Windows.Forms.TextBox();
            this.lblQuantidadeProdutoBaixaEstoque = new System.Windows.Forms.Label();
            this.cboxProdutoBaixaEstoque = new System.Windows.Forms.ComboBox();
            this.btnCancelarBaixaEstoque = new System.Windows.Forms.Button();
            this.btnNovoBaixaEstoque = new System.Windows.Forms.Button();
            this.btnSalvarBaixaEstoque = new System.Windows.Forms.Button();
            this.lblProdutoBaixaEstoque = new System.Windows.Forms.Label();
            this.lblCodigoBaixaEstoque = new System.Windows.Forms.Label();
            this.txtCodigoBaixaEstoque = new System.Windows.Forms.TextBox();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tctrlBaixaEstoque.SuspendLayout();
            this.tpgListarBaixaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixaEstoque)).BeginInit();
            this.tpgConfiguracoesBaixaEstoque.SuspendLayout();
            this.gboxBaixaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicioBuscar
            // 
            this.dtInicioBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioBuscar.Location = new System.Drawing.Point(178, 20);
            this.dtInicioBuscar.Name = "dtInicioBuscar";
            this.dtInicioBuscar.Size = new System.Drawing.Size(120, 26);
            this.dtInicioBuscar.TabIndex = 2;
            // 
            // tctrlBaixaEstoque
            // 
            this.tctrlBaixaEstoque.Controls.Add(this.tpgListarBaixaEstoque);
            this.tctrlBaixaEstoque.Controls.Add(this.tpgConfiguracoesBaixaEstoque);
            this.tctrlBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlBaixaEstoque.Location = new System.Drawing.Point(0, 3);
            this.tctrlBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlBaixaEstoque.Name = "tctrlBaixaEstoque";
            this.tctrlBaixaEstoque.SelectedIndex = 0;
            this.tctrlBaixaEstoque.Size = new System.Drawing.Size(1095, 683);
            this.tctrlBaixaEstoque.TabIndex = 24;
            this.tctrlBaixaEstoque.SelectedIndexChanged += new System.EventHandler(this.tctrlBaixaEstoque_SelectedIndexChanged);
            // 
            // tpgListarBaixaEstoque
            // 
            this.tpgListarBaixaEstoque.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarBaixaEstoque.Controls.Add(this.lblBuscarProdutoBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.txtBuscarProdutoBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.btnBuscarBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.chkBuscarBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.lblDataFinal);
            this.tpgListarBaixaEstoque.Controls.Add(this.lblDataInicio);
            this.tpgListarBaixaEstoque.Controls.Add(this.dtFinalBuscar);
            this.tpgListarBaixaEstoque.Controls.Add(this.dtInicioBuscar);
            this.tpgListarBaixaEstoque.Controls.Add(this.chkExcluirBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.dgvBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.lblTotalBaixaEstoque);
            this.tpgListarBaixaEstoque.Controls.Add(this.btnExcluirBaixaEstoque);
            this.tpgListarBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarBaixaEstoque.Location = new System.Drawing.Point(4, 31);
            this.tpgListarBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarBaixaEstoque.Name = "tpgListarBaixaEstoque";
            this.tpgListarBaixaEstoque.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarBaixaEstoque.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarBaixaEstoque.TabIndex = 0;
            this.tpgListarBaixaEstoque.Text = "Listar";
            // 
            // lblBuscarProdutoBaixaEstoque
            // 
            this.lblBuscarProdutoBaixaEstoque.AutoSize = true;
            this.lblBuscarProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProdutoBaixaEstoque.Location = new System.Drawing.Point(322, 75);
            this.lblBuscarProdutoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarProdutoBaixaEstoque.Name = "lblBuscarProdutoBaixaEstoque";
            this.lblBuscarProdutoBaixaEstoque.Size = new System.Drawing.Size(67, 20);
            this.lblBuscarProdutoBaixaEstoque.TabIndex = 326;
            this.lblBuscarProdutoBaixaEstoque.Text = "Produto";
            // 
            // txtBuscarProdutoBaixaEstoque
            // 
            this.txtBuscarProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProdutoBaixaEstoque.Location = new System.Drawing.Point(393, 72);
            this.txtBuscarProdutoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProdutoBaixaEstoque.Name = "txtBuscarProdutoBaixaEstoque";
            this.txtBuscarProdutoBaixaEstoque.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarProdutoBaixaEstoque.TabIndex = 325;
            this.txtBuscarProdutoBaixaEstoque.TextChanged += new System.EventHandler(this.txtBuscarProdutoBaixaEstoque_TextChanged);
            // 
            // btnBuscarBaixaEstoque
            // 
            this.btnBuscarBaixaEstoque.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarBaixaEstoque.FlatAppearance.BorderSize = 0;
            this.btnBuscarBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBaixaEstoque.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarBaixaEstoque.Location = new System.Drawing.Point(528, 17);
            this.btnBuscarBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarBaixaEstoque.Name = "btnBuscarBaixaEstoque";
            this.btnBuscarBaixaEstoque.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarBaixaEstoque.TabIndex = 4;
            this.btnBuscarBaixaEstoque.Text = "Buscar";
            this.btnBuscarBaixaEstoque.UseVisualStyleBackColor = false;
            this.btnBuscarBaixaEstoque.Click += new System.EventHandler(this.btnBuscarBaixaEstoque_Click);
            // 
            // chkBuscarBaixaEstoque
            // 
            this.chkBuscarBaixaEstoque.AutoSize = true;
            this.chkBuscarBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBuscarBaixaEstoque.Location = new System.Drawing.Point(2, 24);
            this.chkBuscarBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.chkBuscarBaixaEstoque.Name = "chkBuscarBaixaEstoque";
            this.chkBuscarBaixaEstoque.Size = new System.Drawing.Size(77, 24);
            this.chkBuscarBaixaEstoque.TabIndex = 1;
            this.chkBuscarBaixaEstoque.Text = "Buscar";
            this.chkBuscarBaixaEstoque.UseVisualStyleBackColor = true;
            this.chkBuscarBaixaEstoque.CheckedChanged += new System.EventHandler(this.cboxBuscarBaixaEstoque_CheckedChanged);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(303, 25);
            this.lblDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(81, 20);
            this.lblDataFinal.TabIndex = 131;
            this.lblDataFinal.Text = "Data Final";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(84, 25);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(89, 20);
            this.lblDataInicio.TabIndex = 130;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dtFinalBuscar
            // 
            this.dtFinalBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinalBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalBuscar.Location = new System.Drawing.Point(389, 20);
            this.dtFinalBuscar.Name = "dtFinalBuscar";
            this.dtFinalBuscar.Size = new System.Drawing.Size(120, 26);
            this.dtFinalBuscar.TabIndex = 3;
            // 
            // chkExcluirBaixaEstoque
            // 
            this.chkExcluirBaixaEstoque.AutoSize = true;
            this.chkExcluirBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirBaixaEstoque.Location = new System.Drawing.Point(2, 79);
            this.chkExcluirBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirBaixaEstoque.Name = "chkExcluirBaixaEstoque";
            this.chkExcluirBaixaEstoque.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirBaixaEstoque.TabIndex = 5;
            this.chkExcluirBaixaEstoque.Text = "Excluir";
            this.chkExcluirBaixaEstoque.UseVisualStyleBackColor = true;
            this.chkExcluirBaixaEstoque.CheckedChanged += new System.EventHandler(this.chkExcluirBaixaEstoque_CheckedChanged);
            // 
            // dgvBaixaEstoque
            // 
            this.dgvBaixaEstoque.AllowUserToAddRows = false;
            this.dgvBaixaEstoque.AllowUserToDeleteRows = false;
            this.dgvBaixaEstoque.AllowUserToOrderColumns = true;
            this.dgvBaixaEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaixaEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaixaEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaixaEstoque.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaixaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvBaixaEstoque.ColumnHeadersHeight = 50;
            this.dgvBaixaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvBaixaEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaixaEstoque.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvBaixaEstoque.EnableHeadersVisualStyles = false;
            this.dgvBaixaEstoque.GridColor = System.Drawing.Color.Black;
            this.dgvBaixaEstoque.Location = new System.Drawing.Point(0, 107);
            this.dgvBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBaixaEstoque.MultiSelect = false;
            this.dgvBaixaEstoque.Name = "dgvBaixaEstoque";
            this.dgvBaixaEstoque.ReadOnly = true;
            this.dgvBaixaEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaixaEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvBaixaEstoque.RowHeadersVisible = false;
            this.dgvBaixaEstoque.RowHeadersWidth = 51;
            this.dgvBaixaEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaixaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvBaixaEstoque.RowTemplate.Height = 24;
            this.dgvBaixaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaixaEstoque.Size = new System.Drawing.Size(1089, 541);
            this.dgvBaixaEstoque.TabIndex = 8;
            this.dgvBaixaEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaixaEstoque_CellContentClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // lblTotalBaixaEstoque
            // 
            this.lblTotalBaixaEstoque.AutoSize = true;
            this.lblTotalBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBaixaEstoque.Location = new System.Drawing.Point(646, 72);
            this.lblTotalBaixaEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBaixaEstoque.Name = "lblTotalBaixaEstoque";
            this.lblTotalBaixaEstoque.Size = new System.Drawing.Size(119, 20);
            this.lblTotalBaixaEstoque.TabIndex = 5;
            this.lblTotalBaixaEstoque.Text = "Total de Baixas:";
            // 
            // btnExcluirBaixaEstoque
            // 
            this.btnExcluirBaixaEstoque.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirBaixaEstoque.FlatAppearance.BorderSize = 0;
            this.btnExcluirBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirBaixaEstoque.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirBaixaEstoque.Location = new System.Drawing.Point(88, 72);
            this.btnExcluirBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirBaixaEstoque.Name = "btnExcluirBaixaEstoque";
            this.btnExcluirBaixaEstoque.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirBaixaEstoque.TabIndex = 6;
            this.btnExcluirBaixaEstoque.Text = "Excluir";
            this.btnExcluirBaixaEstoque.UseVisualStyleBackColor = false;
            this.btnExcluirBaixaEstoque.Click += new System.EventHandler(this.btnExcluirBaixaEstoque_Click);
            // 
            // tpgConfiguracoesBaixaEstoque
            // 
            this.tpgConfiguracoesBaixaEstoque.BackColor = System.Drawing.Color.Transparent;
            this.tpgConfiguracoesBaixaEstoque.Controls.Add(this.gboxBaixaEstoque);
            this.tpgConfiguracoesBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesBaixaEstoque.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesBaixaEstoque.Name = "tpgConfiguracoesBaixaEstoque";
            this.tpgConfiguracoesBaixaEstoque.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesBaixaEstoque.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesBaixaEstoque.TabIndex = 1;
            this.tpgConfiguracoesBaixaEstoque.Text = "Configurações";
            // 
            // gboxBaixaEstoque
            // 
            this.gboxBaixaEstoque.BackColor = System.Drawing.Color.White;
            this.gboxBaixaEstoque.Controls.Add(this.txtQuantidadeLoteProduto);
            this.gboxBaixaEstoque.Controls.Add(this.lblQuantidadeLoteProduto);
            this.gboxBaixaEstoque.Controls.Add(this.cboxLoteProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.lblLoteProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.txtQuantidadeProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.lblQuantidadeProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.cboxProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.btnCancelarBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.btnNovoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.btnSalvarBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.lblProdutoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.lblCodigoBaixaEstoque);
            this.gboxBaixaEstoque.Controls.Add(this.txtCodigoBaixaEstoque);
            this.gboxBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxBaixaEstoque.Location = new System.Drawing.Point(-4, 0);
            this.gboxBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.gboxBaixaEstoque.Name = "gboxBaixaEstoque";
            this.gboxBaixaEstoque.Padding = new System.Windows.Forms.Padding(2);
            this.gboxBaixaEstoque.Size = new System.Drawing.Size(1095, 703);
            this.gboxBaixaEstoque.TabIndex = 0;
            this.gboxBaixaEstoque.TabStop = false;
            this.gboxBaixaEstoque.Text = "Baixa Estoque";
            // 
            // txtQuantidadeLoteProduto
            // 
            this.txtQuantidadeLoteProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeLoteProduto.Location = new System.Drawing.Point(138, 234);
            this.txtQuantidadeLoteProduto.Name = "txtQuantidadeLoteProduto";
            this.txtQuantidadeLoteProduto.Size = new System.Drawing.Size(240, 26);
            this.txtQuantidadeLoteProduto.TabIndex = 4;
            // 
            // lblQuantidadeLoteProduto
            // 
            this.lblQuantidadeLoteProduto.AutoSize = true;
            this.lblQuantidadeLoteProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLoteProduto.Location = new System.Drawing.Point(45, 237);
            this.lblQuantidadeLoteProduto.Name = "lblQuantidadeLoteProduto";
            this.lblQuantidadeLoteProduto.Size = new System.Drawing.Size(87, 20);
            this.lblQuantidadeLoteProduto.TabIndex = 136;
            this.lblQuantidadeLoteProduto.Text = "Qtde. Lote";
            // 
            // cboxLoteProdutoBaixaEstoque
            // 
            this.cboxLoteProdutoBaixaEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLoteProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLoteProdutoBaixaEstoque.FormattingEnabled = true;
            this.cboxLoteProdutoBaixaEstoque.Location = new System.Drawing.Point(138, 179);
            this.cboxLoteProdutoBaixaEstoque.Name = "cboxLoteProdutoBaixaEstoque";
            this.cboxLoteProdutoBaixaEstoque.Size = new System.Drawing.Size(240, 28);
            this.cboxLoteProdutoBaixaEstoque.TabIndex = 3;
            this.ttmesagem.SetToolTip(this.cboxLoteProdutoBaixaEstoque, "Selecione o lote do produto \r\nque deseja realizar a baixa");
            this.cboxLoteProdutoBaixaEstoque.SelectedIndexChanged += new System.EventHandler(this.cboxLoteProdutoBaixaEstoque_SelectedIndexChanged);
            this.cboxLoteProdutoBaixaEstoque.Click += new System.EventHandler(this.cboxLoteProdutoBaixaEstoque_Click);
            // 
            // lblLoteProdutoBaixaEstoque
            // 
            this.lblLoteProdutoBaixaEstoque.AutoSize = true;
            this.lblLoteProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoteProdutoBaixaEstoque.Location = new System.Drawing.Point(91, 182);
            this.lblLoteProdutoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoteProdutoBaixaEstoque.Name = "lblLoteProdutoBaixaEstoque";
            this.lblLoteProdutoBaixaEstoque.Size = new System.Drawing.Size(41, 20);
            this.lblLoteProdutoBaixaEstoque.TabIndex = 134;
            this.lblLoteProdutoBaixaEstoque.Text = "Lote";
            // 
            // txtQuantidadeProdutoBaixaEstoque
            // 
            this.txtQuantidadeProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeProdutoBaixaEstoque.Location = new System.Drawing.Point(138, 285);
            this.txtQuantidadeProdutoBaixaEstoque.Name = "txtQuantidadeProdutoBaixaEstoque";
            this.txtQuantidadeProdutoBaixaEstoque.Size = new System.Drawing.Size(240, 26);
            this.txtQuantidadeProdutoBaixaEstoque.TabIndex = 5;
            // 
            // lblQuantidadeProdutoBaixaEstoque
            // 
            this.lblQuantidadeProdutoBaixaEstoque.AutoSize = true;
            this.lblQuantidadeProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProdutoBaixaEstoque.Location = new System.Drawing.Point(38, 288);
            this.lblQuantidadeProdutoBaixaEstoque.Name = "lblQuantidadeProdutoBaixaEstoque";
            this.lblQuantidadeProdutoBaixaEstoque.Size = new System.Drawing.Size(94, 20);
            this.lblQuantidadeProdutoBaixaEstoque.TabIndex = 130;
            this.lblQuantidadeProdutoBaixaEstoque.Text = "Qtde. Baixa";
            // 
            // cboxProdutoBaixaEstoque
            // 
            this.cboxProdutoBaixaEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProdutoBaixaEstoque.FormattingEnabled = true;
            this.cboxProdutoBaixaEstoque.Location = new System.Drawing.Point(138, 125);
            this.cboxProdutoBaixaEstoque.Name = "cboxProdutoBaixaEstoque";
            this.cboxProdutoBaixaEstoque.Size = new System.Drawing.Size(240, 28);
            this.cboxProdutoBaixaEstoque.TabIndex = 2;
            this.ttmesagem.SetToolTip(this.cboxProdutoBaixaEstoque, "Selecione o produto da compra");
            this.cboxProdutoBaixaEstoque.SelectedIndexChanged += new System.EventHandler(this.cboxProdutoBaixaEstoque_SelectedIndexChanged);
            // 
            // btnCancelarBaixaEstoque
            // 
            this.btnCancelarBaixaEstoque.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarBaixaEstoque.FlatAppearance.BorderSize = 0;
            this.btnCancelarBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBaixaEstoque.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarBaixaEstoque.Location = new System.Drawing.Point(442, 165);
            this.btnCancelarBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarBaixaEstoque.Name = "btnCancelarBaixaEstoque";
            this.btnCancelarBaixaEstoque.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarBaixaEstoque.TabIndex = 7;
            this.btnCancelarBaixaEstoque.Text = "Cancelar";
            this.btnCancelarBaixaEstoque.UseVisualStyleBackColor = false;
            this.btnCancelarBaixaEstoque.Click += new System.EventHandler(this.btnCancelarBaixaEstoque_Click);
            // 
            // btnNovoBaixaEstoque
            // 
            this.btnNovoBaixaEstoque.BackColor = System.Drawing.Color.Wheat;
            this.btnNovoBaixaEstoque.FlatAppearance.BorderSize = 0;
            this.btnNovoBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoBaixaEstoque.ForeColor = System.Drawing.Color.Sienna;
            this.btnNovoBaixaEstoque.Location = new System.Drawing.Point(442, 67);
            this.btnNovoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoBaixaEstoque.Name = "btnNovoBaixaEstoque";
            this.btnNovoBaixaEstoque.Size = new System.Drawing.Size(160, 50);
            this.btnNovoBaixaEstoque.TabIndex = 6;
            this.btnNovoBaixaEstoque.Text = "Novo";
            this.btnNovoBaixaEstoque.UseVisualStyleBackColor = false;
            this.btnNovoBaixaEstoque.Click += new System.EventHandler(this.btnNovoBaixaEstoque_Click);
            // 
            // btnSalvarBaixaEstoque
            // 
            this.btnSalvarBaixaEstoque.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarBaixaEstoque.FlatAppearance.BorderSize = 0;
            this.btnSalvarBaixaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarBaixaEstoque.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarBaixaEstoque.Location = new System.Drawing.Point(442, 261);
            this.btnSalvarBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarBaixaEstoque.Name = "btnSalvarBaixaEstoque";
            this.btnSalvarBaixaEstoque.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarBaixaEstoque.TabIndex = 8;
            this.btnSalvarBaixaEstoque.Text = "Salvar";
            this.btnSalvarBaixaEstoque.UseVisualStyleBackColor = false;
            this.btnSalvarBaixaEstoque.Click += new System.EventHandler(this.btnSalvarBaixaEstoque_Click);
            // 
            // lblProdutoBaixaEstoque
            // 
            this.lblProdutoBaixaEstoque.AutoSize = true;
            this.lblProdutoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoBaixaEstoque.Location = new System.Drawing.Point(66, 128);
            this.lblProdutoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdutoBaixaEstoque.Name = "lblProdutoBaixaEstoque";
            this.lblProdutoBaixaEstoque.Size = new System.Drawing.Size(67, 20);
            this.lblProdutoBaixaEstoque.TabIndex = 108;
            this.lblProdutoBaixaEstoque.Text = "Produto";
            // 
            // lblCodigoBaixaEstoque
            // 
            this.lblCodigoBaixaEstoque.AutoSize = true;
            this.lblCodigoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBaixaEstoque.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoBaixaEstoque.Name = "lblCodigoBaixaEstoque";
            this.lblCodigoBaixaEstoque.Size = new System.Drawing.Size(64, 20);
            this.lblCodigoBaixaEstoque.TabIndex = 107;
            this.lblCodigoBaixaEstoque.Text = "Código";
            // 
            // txtCodigoBaixaEstoque
            // 
            this.txtCodigoBaixaEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBaixaEstoque.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoBaixaEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoBaixaEstoque.Name = "txtCodigoBaixaEstoque";
            this.txtCodigoBaixaEstoque.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoBaixaEstoque.TabIndex = 1;
            this.txtCodigoBaixaEstoque.TabStop = false;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ViewBaixaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlBaixaEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBaixaEstoque";
            this.Text = "Baixa Estoque";
            this.Load += new System.EventHandler(this.ViewBaixaEstoque_Load);
            this.tctrlBaixaEstoque.ResumeLayout(false);
            this.tpgListarBaixaEstoque.ResumeLayout(false);
            this.tpgListarBaixaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixaEstoque)).EndInit();
            this.tpgConfiguracoesBaixaEstoque.ResumeLayout(false);
            this.gboxBaixaEstoque.ResumeLayout(false);
            this.gboxBaixaEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicioBuscar;
        private System.Windows.Forms.TabControl tctrlBaixaEstoque;
        private System.Windows.Forms.TabPage tpgListarBaixaEstoque;
        private System.Windows.Forms.CheckBox chkBuscarBaixaEstoque;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtFinalBuscar;
        private System.Windows.Forms.CheckBox chkExcluirBaixaEstoque;
        private System.Windows.Forms.DataGridView dgvBaixaEstoque;
        private System.Windows.Forms.Label lblTotalBaixaEstoque;
        private System.Windows.Forms.Button btnExcluirBaixaEstoque;
        private System.Windows.Forms.TabPage tpgConfiguracoesBaixaEstoque;
        private System.Windows.Forms.GroupBox gboxBaixaEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeProdutoBaixaEstoque;
        private System.Windows.Forms.Label lblQuantidadeProdutoBaixaEstoque;
        private System.Windows.Forms.ComboBox cboxProdutoBaixaEstoque;
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.Button btnCancelarBaixaEstoque;
        private System.Windows.Forms.Button btnNovoBaixaEstoque;
        private System.Windows.Forms.Button btnSalvarBaixaEstoque;
        private System.Windows.Forms.Label lblProdutoBaixaEstoque;
        private System.Windows.Forms.Label lblCodigoBaixaEstoque;
        private System.Windows.Forms.TextBox txtCodigoBaixaEstoque;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ComboBox cboxLoteProdutoBaixaEstoque;
        private System.Windows.Forms.Label lblLoteProdutoBaixaEstoque;
        private System.Windows.Forms.Button btnBuscarBaixaEstoque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.TextBox txtQuantidadeLoteProduto;
        private System.Windows.Forms.Label lblQuantidadeLoteProduto;
        private System.Windows.Forms.Label lblBuscarProdutoBaixaEstoque;
        private System.Windows.Forms.TextBox txtBuscarProdutoBaixaEstoque;
    }
}