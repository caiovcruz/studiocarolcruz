namespace View
{
    partial class ViewProcedimento
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
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.cboxCategoriaProcedimento = new System.Windows.Forms.ComboBox();
            this.txtBuscarProcedimento = new System.Windows.Forms.TextBox();
            this.cboxBuscarProcedimento = new System.Windows.Forms.ComboBox();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpgConfiguracoesProcedimento = new System.Windows.Forms.TabPage();
            this.gboxProcedimento = new System.Windows.Forms.GroupBox();
            this.btnCancelarProcedimento = new System.Windows.Forms.Button();
            this.btnNovoProcedimento = new System.Windows.Forms.Button();
            this.btnEditarProcedimento = new System.Windows.Forms.Button();
            this.btnSalvarProcedimento = new System.Windows.Forms.Button();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigoProcedimento = new System.Windows.Forms.Label();
            this.txtDescricaoProcedimento = new System.Windows.Forms.TextBox();
            this.lblDescricaoProcedimento = new System.Windows.Forms.Label();
            this.lblCategoriaProcedimento = new System.Windows.Forms.Label();
            this.txtNomeProcedimento = new System.Windows.Forms.TextBox();
            this.txtCodigoProcedimento = new System.Windows.Forms.TextBox();
            this.tpgListarProcedimento = new System.Windows.Forms.TabPage();
            this.chkBuscarProcedimento = new System.Windows.Forms.CheckBox();
            this.chkExcluirProcedimento = new System.Windows.Forms.CheckBox();
            this.dgvProcedimento = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotalProcedimento = new System.Windows.Forms.Label();
            this.btnBuscarProcedimento = new System.Windows.Forms.Button();
            this.btnExcluirProcedimento = new System.Windows.Forms.Button();
            this.tctrlProcedimento = new System.Windows.Forms.TabControl();
            this.ExcluirFichaProcedimento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.tpgConfiguracoesProcedimento.SuspendLayout();
            this.gboxProcedimento.SuspendLayout();
            this.tpgListarProcedimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimento)).BeginInit();
            this.tctrlProcedimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // cboxCategoriaProcedimento
            // 
            this.cboxCategoriaProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoriaProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCategoriaProcedimento.FormattingEnabled = true;
            this.cboxCategoriaProcedimento.Location = new System.Drawing.Point(138, 111);
            this.cboxCategoriaProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCategoriaProcedimento.Name = "cboxCategoriaProcedimento";
            this.cboxCategoriaProcedimento.Size = new System.Drawing.Size(240, 28);
            this.cboxCategoriaProcedimento.TabIndex = 2;
            this.ttmesagem.SetToolTip(this.cboxCategoriaProcedimento, "Selecione a categoria do procedimento");
            // 
            // txtBuscarProcedimento
            // 
            this.txtBuscarProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProcedimento.Location = new System.Drawing.Point(241, 18);
            this.txtBuscarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProcedimento.Name = "txtBuscarProcedimento";
            this.txtBuscarProcedimento.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarProcedimento.TabIndex = 1;
            this.ttmesagem.SetToolTip(this.txtBuscarProcedimento, "Digite o nome do procedimento desejado");
            this.txtBuscarProcedimento.TextChanged += new System.EventHandler(this.txtBuscarProcedimento_TextChanged);
            // 
            // cboxBuscarProcedimento
            // 
            this.cboxBuscarProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBuscarProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBuscarProcedimento.FormattingEnabled = true;
            this.cboxBuscarProcedimento.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cboxBuscarProcedimento.Location = new System.Drawing.Point(88, 18);
            this.cboxBuscarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuscarProcedimento.Name = "cboxBuscarProcedimento";
            this.cboxBuscarProcedimento.Size = new System.Drawing.Size(130, 28);
            this.cboxBuscarProcedimento.TabIndex = 6;
            this.ttmesagem.SetToolTip(this.cboxBuscarProcedimento, "Selecione a categoria do procedimento desejado");
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // tpgConfiguracoesProcedimento
            // 
            this.tpgConfiguracoesProcedimento.Controls.Add(this.gboxProcedimento);
            this.tpgConfiguracoesProcedimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgConfiguracoesProcedimento.Location = new System.Drawing.Point(4, 31);
            this.tpgConfiguracoesProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesProcedimento.Name = "tpgConfiguracoesProcedimento";
            this.tpgConfiguracoesProcedimento.Padding = new System.Windows.Forms.Padding(2);
            this.tpgConfiguracoesProcedimento.Size = new System.Drawing.Size(1087, 648);
            this.tpgConfiguracoesProcedimento.TabIndex = 1;
            this.tpgConfiguracoesProcedimento.Text = "Configurações";
            this.tpgConfiguracoesProcedimento.UseVisualStyleBackColor = true;
            // 
            // gboxProcedimento
            // 
            this.gboxProcedimento.BackColor = System.Drawing.Color.White;
            this.gboxProcedimento.Controls.Add(this.btnCancelarProcedimento);
            this.gboxProcedimento.Controls.Add(this.btnNovoProcedimento);
            this.gboxProcedimento.Controls.Add(this.btnEditarProcedimento);
            this.gboxProcedimento.Controls.Add(this.btnSalvarProcedimento);
            this.gboxProcedimento.Controls.Add(this.lblNomeProduto);
            this.gboxProcedimento.Controls.Add(this.lblCodigoProcedimento);
            this.gboxProcedimento.Controls.Add(this.cboxCategoriaProcedimento);
            this.gboxProcedimento.Controls.Add(this.txtDescricaoProcedimento);
            this.gboxProcedimento.Controls.Add(this.lblDescricaoProcedimento);
            this.gboxProcedimento.Controls.Add(this.lblCategoriaProcedimento);
            this.gboxProcedimento.Controls.Add(this.txtNomeProcedimento);
            this.gboxProcedimento.Controls.Add(this.txtCodigoProcedimento);
            this.gboxProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxProcedimento.Location = new System.Drawing.Point(-4, 0);
            this.gboxProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.gboxProcedimento.Name = "gboxProcedimento";
            this.gboxProcedimento.Padding = new System.Windows.Forms.Padding(2);
            this.gboxProcedimento.Size = new System.Drawing.Size(1300, 692);
            this.gboxProcedimento.TabIndex = 0;
            this.gboxProcedimento.TabStop = false;
            this.gboxProcedimento.Text = "Procedimento";
            // 
            // btnCancelarProcedimento
            // 
            this.btnCancelarProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnCancelarProcedimento.FlatAppearance.BorderSize = 0;
            this.btnCancelarProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProcedimento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnCancelarProcedimento.Location = new System.Drawing.Point(787, 288);
            this.btnCancelarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarProcedimento.Name = "btnCancelarProcedimento";
            this.btnCancelarProcedimento.Size = new System.Drawing.Size(160, 50);
            this.btnCancelarProcedimento.TabIndex = 9;
            this.btnCancelarProcedimento.Text = "Cancelar";
            this.btnCancelarProcedimento.UseVisualStyleBackColor = false;
            this.btnCancelarProcedimento.Click += new System.EventHandler(this.btnCancelarProcedimento_Click);
            // 
            // btnNovoProcedimento
            // 
            this.btnNovoProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnNovoProcedimento.FlatAppearance.BorderSize = 0;
            this.btnNovoProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProcedimento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnNovoProcedimento.Location = new System.Drawing.Point(787, 70);
            this.btnNovoProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovoProcedimento.Name = "btnNovoProcedimento";
            this.btnNovoProcedimento.Size = new System.Drawing.Size(160, 50);
            this.btnNovoProcedimento.TabIndex = 7;
            this.btnNovoProcedimento.Text = "Novo";
            this.btnNovoProcedimento.UseVisualStyleBackColor = false;
            this.btnNovoProcedimento.Click += new System.EventHandler(this.btnNovoProcedimento_Click);
            // 
            // btnEditarProcedimento
            // 
            this.btnEditarProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarProcedimento.FlatAppearance.BorderSize = 0;
            this.btnEditarProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProcedimento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnEditarProcedimento.Location = new System.Drawing.Point(787, 176);
            this.btnEditarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProcedimento.Name = "btnEditarProcedimento";
            this.btnEditarProcedimento.Size = new System.Drawing.Size(160, 50);
            this.btnEditarProcedimento.TabIndex = 8;
            this.btnEditarProcedimento.Text = "Editar";
            this.btnEditarProcedimento.UseVisualStyleBackColor = false;
            this.btnEditarProcedimento.Click += new System.EventHandler(this.btnEditarProcedimento_Click);
            // 
            // btnSalvarProcedimento
            // 
            this.btnSalvarProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnSalvarProcedimento.FlatAppearance.BorderSize = 0;
            this.btnSalvarProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProcedimento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnSalvarProcedimento.Location = new System.Drawing.Point(787, 403);
            this.btnSalvarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarProcedimento.Name = "btnSalvarProcedimento";
            this.btnSalvarProcedimento.Size = new System.Drawing.Size(160, 50);
            this.btnSalvarProcedimento.TabIndex = 10;
            this.btnSalvarProcedimento.Text = "Salvar";
            this.btnSalvarProcedimento.UseVisualStyleBackColor = false;
            this.btnSalvarProcedimento.Click += new System.EventHandler(this.btnSalvarProcedimento_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(427, 114);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(53, 20);
            this.lblNomeProduto.TabIndex = 108;
            this.lblNomeProduto.Text = "Nome";
            // 
            // lblCodigoProcedimento
            // 
            this.lblCodigoProcedimento.AutoSize = true;
            this.lblCodigoProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProcedimento.Location = new System.Drawing.Point(70, 70);
            this.lblCodigoProcedimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProcedimento.Name = "lblCodigoProcedimento";
            this.lblCodigoProcedimento.Size = new System.Drawing.Size(64, 20);
            this.lblCodigoProcedimento.TabIndex = 107;
            this.lblCodigoProcedimento.Text = "Código";
            // 
            // txtDescricaoProcedimento
            // 
            this.txtDescricaoProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProcedimento.Location = new System.Drawing.Point(138, 161);
            this.txtDescricaoProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricaoProcedimento.Multiline = true;
            this.txtDescricaoProcedimento.Name = "txtDescricaoProcedimento";
            this.txtDescricaoProcedimento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricaoProcedimento.Size = new System.Drawing.Size(590, 292);
            this.txtDescricaoProcedimento.TabIndex = 6;
            // 
            // lblDescricaoProcedimento
            // 
            this.lblDescricaoProcedimento.AutoSize = true;
            this.lblDescricaoProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProcedimento.Location = new System.Drawing.Point(50, 164);
            this.lblDescricaoProcedimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricaoProcedimento.Name = "lblDescricaoProcedimento";
            this.lblDescricaoProcedimento.Size = new System.Drawing.Size(84, 20);
            this.lblDescricaoProcedimento.TabIndex = 100;
            this.lblDescricaoProcedimento.Text = "Descrição";
            // 
            // lblCategoriaProcedimento
            // 
            this.lblCategoriaProcedimento.AutoSize = true;
            this.lblCategoriaProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProcedimento.Location = new System.Drawing.Point(48, 114);
            this.lblCategoriaProcedimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaProcedimento.Name = "lblCategoriaProcedimento";
            this.lblCategoriaProcedimento.Size = new System.Drawing.Size(84, 20);
            this.lblCategoriaProcedimento.TabIndex = 98;
            this.lblCategoriaProcedimento.Text = "Categoria";
            // 
            // txtNomeProcedimento
            // 
            this.txtNomeProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProcedimento.Location = new System.Drawing.Point(488, 111);
            this.txtNomeProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeProcedimento.Name = "txtNomeProcedimento";
            this.txtNomeProcedimento.Size = new System.Drawing.Size(240, 26);
            this.txtNomeProcedimento.TabIndex = 3;
            // 
            // txtCodigoProcedimento
            // 
            this.txtCodigoProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProcedimento.Location = new System.Drawing.Point(138, 67);
            this.txtCodigoProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProcedimento.Name = "txtCodigoProcedimento";
            this.txtCodigoProcedimento.Size = new System.Drawing.Size(99, 26);
            this.txtCodigoProcedimento.TabIndex = 1;
            this.txtCodigoProcedimento.TabStop = false;
            // 
            // tpgListarProcedimento
            // 
            this.tpgListarProcedimento.BackColor = System.Drawing.Color.BurlyWood;
            this.tpgListarProcedimento.Controls.Add(this.chkBuscarProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.cboxBuscarProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.chkExcluirProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.dgvProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.txtBuscarProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.lblTotalProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.btnBuscarProcedimento);
            this.tpgListarProcedimento.Controls.Add(this.btnExcluirProcedimento);
            this.tpgListarProcedimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgListarProcedimento.Location = new System.Drawing.Point(4, 31);
            this.tpgListarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.tpgListarProcedimento.Name = "tpgListarProcedimento";
            this.tpgListarProcedimento.Padding = new System.Windows.Forms.Padding(2);
            this.tpgListarProcedimento.Size = new System.Drawing.Size(1087, 648);
            this.tpgListarProcedimento.TabIndex = 0;
            this.tpgListarProcedimento.Text = "Listar";
            // 
            // chkBuscarProcedimento
            // 
            this.chkBuscarProcedimento.AutoSize = true;
            this.chkBuscarProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBuscarProcedimento.Location = new System.Drawing.Point(2, 20);
            this.chkBuscarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.chkBuscarProcedimento.Name = "chkBuscarProcedimento";
            this.chkBuscarProcedimento.Size = new System.Drawing.Size(77, 24);
            this.chkBuscarProcedimento.TabIndex = 328;
            this.chkBuscarProcedimento.Text = "Buscar";
            this.chkBuscarProcedimento.UseVisualStyleBackColor = true;
            this.chkBuscarProcedimento.CheckedChanged += new System.EventHandler(this.chkBuscarProcedimento_CheckedChanged);
            // 
            // chkExcluirProcedimento
            // 
            this.chkExcluirProcedimento.AutoSize = true;
            this.chkExcluirProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcluirProcedimento.Location = new System.Drawing.Point(2, 79);
            this.chkExcluirProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.chkExcluirProcedimento.Name = "chkExcluirProcedimento";
            this.chkExcluirProcedimento.Size = new System.Drawing.Size(73, 24);
            this.chkExcluirProcedimento.TabIndex = 3;
            this.chkExcluirProcedimento.Text = "Excluir";
            this.chkExcluirProcedimento.UseVisualStyleBackColor = true;
            this.chkExcluirProcedimento.CheckedChanged += new System.EventHandler(this.chkExcluirProcedimento_CheckedChanged);
            // 
            // dgvProcedimento
            // 
            this.dgvProcedimento.AllowUserToAddRows = false;
            this.dgvProcedimento.AllowUserToDeleteRows = false;
            this.dgvProcedimento.AllowUserToOrderColumns = true;
            this.dgvProcedimento.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcedimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcedimento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcedimento.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcedimento.ColumnHeadersHeight = 50;
            this.dgvProcedimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir});
            this.dgvProcedimento.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcedimento.EnableHeadersVisualStyles = false;
            this.dgvProcedimento.GridColor = System.Drawing.Color.Black;
            this.dgvProcedimento.Location = new System.Drawing.Point(0, 107);
            this.dgvProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProcedimento.MultiSelect = false;
            this.dgvProcedimento.Name = "dgvProcedimento";
            this.dgvProcedimento.ReadOnly = true;
            this.dgvProcedimento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcedimento.RowHeadersVisible = false;
            this.dgvProcedimento.RowHeadersWidth = 51;
            this.dgvProcedimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedimento.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProcedimento.RowTemplate.Height = 24;
            this.dgvProcedimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedimento.Size = new System.Drawing.Size(1089, 541);
            this.dgvProcedimento.TabIndex = 5;
            this.dgvProcedimento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedimento_CellContentClick);
            this.dgvProcedimento.DoubleClick += new System.EventHandler(this.dgvProcedimento_DoubleClick);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.MinimumWidth = 6;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 67;
            // 
            // lblTotalProcedimento
            // 
            this.lblTotalProcedimento.AutoSize = true;
            this.lblTotalProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProcedimento.Location = new System.Drawing.Point(466, 72);
            this.lblTotalProcedimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalProcedimento.Name = "lblTotalProcedimento";
            this.lblTotalProcedimento.Size = new System.Drawing.Size(188, 20);
            this.lblTotalProcedimento.TabIndex = 5;
            this.lblTotalProcedimento.Text = "Total de Procedimentos: ";
            // 
            // btnBuscarProcedimento
            // 
            this.btnBuscarProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnBuscarProcedimento.FlatAppearance.BorderSize = 0;
            this.btnBuscarProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnBuscarProcedimento.Location = new System.Drawing.Point(549, 16);
            this.btnBuscarProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProcedimento.Name = "btnBuscarProcedimento";
            this.btnBuscarProcedimento.Size = new System.Drawing.Size(105, 31);
            this.btnBuscarProcedimento.TabIndex = 2;
            this.btnBuscarProcedimento.Text = "Buscar";
            this.btnBuscarProcedimento.UseVisualStyleBackColor = false;
            this.btnBuscarProcedimento.Click += new System.EventHandler(this.btnBuscarProcedimento_Click);
            // 
            // btnExcluirProcedimento
            // 
            this.btnExcluirProcedimento.BackColor = System.Drawing.Color.Wheat;
            this.btnExcluirProcedimento.FlatAppearance.BorderSize = 0;
            this.btnExcluirProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProcedimento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProcedimento.ForeColor = System.Drawing.Color.Sienna;
            this.btnExcluirProcedimento.Location = new System.Drawing.Point(88, 72);
            this.btnExcluirProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirProcedimento.Name = "btnExcluirProcedimento";
            this.btnExcluirProcedimento.Size = new System.Drawing.Size(105, 31);
            this.btnExcluirProcedimento.TabIndex = 4;
            this.btnExcluirProcedimento.Text = "Excluir";
            this.btnExcluirProcedimento.UseVisualStyleBackColor = false;
            this.btnExcluirProcedimento.Click += new System.EventHandler(this.btnExcluirProcedimento_Click);
            // 
            // tctrlProcedimento
            // 
            this.tctrlProcedimento.Controls.Add(this.tpgListarProcedimento);
            this.tctrlProcedimento.Controls.Add(this.tpgConfiguracoesProcedimento);
            this.tctrlProcedimento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlProcedimento.Location = new System.Drawing.Point(0, 3);
            this.tctrlProcedimento.Margin = new System.Windows.Forms.Padding(2);
            this.tctrlProcedimento.Name = "tctrlProcedimento";
            this.tctrlProcedimento.SelectedIndex = 0;
            this.tctrlProcedimento.Size = new System.Drawing.Size(1095, 683);
            this.tctrlProcedimento.TabIndex = 19;
            this.tctrlProcedimento.SelectedIndexChanged += new System.EventHandler(this.tctrlProcedimento_SelectedIndexChanged);
            // 
            // ExcluirFichaProcedimento
            // 
            this.ExcluirFichaProcedimento.HeaderText = "Excluir";
            this.ExcluirFichaProcedimento.MinimumWidth = 6;
            this.ExcluirFichaProcedimento.Name = "ExcluirFichaProcedimento";
            this.ExcluirFichaProcedimento.ReadOnly = true;
            this.ExcluirFichaProcedimento.Width = 67;
            // 
            // ViewProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.tctrlProcedimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProcedimento";
            this.Text = "Procedimentos";
            this.Load += new System.EventHandler(this.ViewProcedimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.tpgConfiguracoesProcedimento.ResumeLayout(false);
            this.gboxProcedimento.ResumeLayout(false);
            this.gboxProcedimento.PerformLayout();
            this.tpgListarProcedimento.ResumeLayout(false);
            this.tpgListarProcedimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedimento)).EndInit();
            this.tctrlProcedimento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttmesagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.TabControl tctrlProcedimento;
        private System.Windows.Forms.TabPage tpgListarProcedimento;
        private System.Windows.Forms.CheckBox chkExcluirProcedimento;
        private System.Windows.Forms.DataGridView dgvProcedimento;
        private System.Windows.Forms.TextBox txtBuscarProcedimento;
        private System.Windows.Forms.Label lblTotalProcedimento;
        private System.Windows.Forms.Button btnBuscarProcedimento;
        private System.Windows.Forms.Button btnExcluirProcedimento;
        private System.Windows.Forms.TabPage tpgConfiguracoesProcedimento;
        private System.Windows.Forms.GroupBox gboxProcedimento;
        private System.Windows.Forms.Button btnCancelarProcedimento;
        private System.Windows.Forms.Button btnNovoProcedimento;
        private System.Windows.Forms.Button btnEditarProcedimento;
        private System.Windows.Forms.Button btnSalvarProcedimento;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodigoProcedimento;
        private System.Windows.Forms.ComboBox cboxCategoriaProcedimento;
        private System.Windows.Forms.TextBox txtDescricaoProcedimento;
        private System.Windows.Forms.Label lblDescricaoProcedimento;
        private System.Windows.Forms.Label lblCategoriaProcedimento;
        private System.Windows.Forms.TextBox txtNomeProcedimento;
        private System.Windows.Forms.TextBox txtCodigoProcedimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExcluirFichaProcedimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.ComboBox cboxBuscarProcedimento;
        private System.Windows.Forms.CheckBox chkBuscarProcedimento;
    }
}