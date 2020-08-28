namespace View
{
    partial class ViewRealizarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRealizarLogin));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.dgvLogin = new System.Windows.Forms.DataGridView();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnVisualizarSenha = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.ttmesagem = new System.Windows.Forms.ToolTip(this.components);
            this.btnSenha = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Wheat;
            this.pnlLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLateral.BackgroundImage")));
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(196, 455);
            this.pnlLateral.TabIndex = 34;
            this.pnlLateral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLateral_MouseDown);
            // 
            // dgvLogin
            // 
            this.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogin.Location = new System.Drawing.Point(31, 28);
            this.dgvLogin.Name = "dgvLogin";
            this.dgvLogin.Size = new System.Drawing.Size(10, 10);
            this.dgvLogin.TabIndex = 35;
            this.dgvLogin.Visible = false;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 2;
            this.iconButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(359, 273);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(274, 2);
            this.iconButton2.TabIndex = 48;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 2;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(360, 171);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(273, 2);
            this.iconButton1.TabIndex = 47;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.White;
            this.lblTituloLogin.Location = new System.Drawing.Point(370, 12);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(226, 50);
            this.lblTituloLogin.TabIndex = 46;
            this.lblTituloLogin.Text = "LOGIN";
            this.lblTituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnFechar.IconColor = System.Drawing.Color.White;
            this.btnFechar.IconSize = 45;
            this.btnFechar.Location = new System.Drawing.Point(751, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Rotation = 0D;
            this.btnFechar.Size = new System.Drawing.Size(27, 33);
            this.btnFechar.TabIndex = 44;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconSize = 45;
            this.btnMinimizar.Location = new System.Drawing.Point(704, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(32, 23);
            this.btnMinimizar.TabIndex = 43;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnVisualizarSenha
            // 
            this.btnVisualizarSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVisualizarSenha.FlatAppearance.BorderSize = 0;
            this.btnVisualizarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnVisualizarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnVisualizarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarSenha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVisualizarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarSenha.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVisualizarSenha.IconColor = System.Drawing.Color.White;
            this.btnVisualizarSenha.IconSize = 45;
            this.btnVisualizarSenha.Location = new System.Drawing.Point(661, 241);
            this.btnVisualizarSenha.Name = "btnVisualizarSenha";
            this.btnVisualizarSenha.Rotation = 0D;
            this.btnVisualizarSenha.Size = new System.Drawing.Size(41, 36);
            this.btnVisualizarSenha.TabIndex = 42;
            this.btnVisualizarSenha.UseVisualStyleBackColor = true;
            this.btnVisualizarSenha.Click += new System.EventHandler(this.btnVisualizarSenha_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 6;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconSize = 50;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(348, 356);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Rotation = 0D;
            this.btnLogin.Size = new System.Drawing.Size(272, 58);
            this.btnLogin.TabIndex = 39;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(362, 246);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(274, 24);
            this.txtSenha.TabIndex = 38;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(362, 148);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(263, 24);
            this.txtUsuario.TabIndex = 37;
            this.txtUsuario.Text = "USUÁRIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuario.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuario.IconSize = 40;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(304, 130);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Rotation = 0D;
            this.btnUsuario.Size = new System.Drawing.Size(350, 64);
            this.btnUsuario.TabIndex = 40;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // ttmesagem
            // 
            this.ttmesagem.IsBalloon = true;
            // 
            // btnSenha
            // 
            this.btnSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.btnSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSenha.FlatAppearance.BorderSize = 0;
            this.btnSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSenha.ForeColor = System.Drawing.Color.White;
            this.btnSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnSenha.IconColor = System.Drawing.Color.White;
            this.btnSenha.IconSize = 40;
            this.btnSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenha.Location = new System.Drawing.Point(304, 229);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Rotation = 0D;
            this.btnSenha.Size = new System.Drawing.Size(351, 64);
            this.btnSenha.TabIndex = 41;
            this.btnSenha.UseVisualStyleBackColor = false;
            // 
            // ViewRealizarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.dgvLogin);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnVisualizarSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRealizarLogin";
            this.Opacity = 0.9D;
            this.Text = "Realizar Login";
            this.Load += new System.EventHandler(this.ViewRealizarLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewRealizarLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.DataGridView dgvLogin;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblTituloLogin;
        private FontAwesome.Sharp.IconButton btnFechar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnVisualizarSenha;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnSenha;
        private System.Windows.Forms.ToolTip ttmesagem;
    }
}