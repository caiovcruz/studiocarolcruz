using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewLogin : Form
    {
        ControlLogin myLogin = new ControlLogin();

        Validar myValidar = new Validar();

        private bool NovoLogin = false;
        private bool EditarLogin = false;

        public ViewLogin()
        {
            InitializeComponent();
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Studio Carol Cruz", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Studio Carol Cruz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparTextBox()
        {
            txtCodigoLogin.Text = string.Empty;
            txtUsuarioLogin.Text = string.Empty;
            txtSenhaLogin.Text = string.Empty;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoLogin.Enabled = false;
            txtUsuarioLogin.Enabled = Valor;
            txtSenhaLogin.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovoLogin || EditarLogin)
            {
                HabilitarTextBox(true);

                btnNovoLogin.Enabled = false;
                btnNovoLogin.BackColor = Color.Sienna;

                btnEditarLogin.Enabled = false;
                btnEditarLogin.BackColor = Color.Sienna;

                btnCancelarLogin.Enabled = true;
                btnCancelarLogin.BackColor = Color.Wheat;

                btnSalvarLogin.Enabled = true;
                btnSalvarLogin.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoLogin.Enabled = true;
                btnNovoLogin.BackColor = Color.Wheat;

                btnEditarLogin.Enabled = false;
                btnEditarLogin.BackColor = Color.Sienna;

                btnCancelarLogin.Enabled = false;
                btnCancelarLogin.BackColor = Color.Sienna;

                btnSalvarLogin.Enabled = false;
                btnSalvarLogin.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvLogin.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvLogin.Rows.Count == 0)
            {
                chkExcluirLogin.Enabled = false;
                btnExcluirLogin.Enabled = false;
                btnExcluirLogin.BackColor = Color.Sienna;
                txtBuscarLogin.Enabled = false;
                btnBuscarLogin.Enabled = false;
                btnBuscarLogin.BackColor = Color.Sienna;
                dgvLogin.Enabled = false;
            }
            else
            {
                chkExcluirLogin.Enabled = true;
                btnExcluirLogin.Enabled = true;
                btnExcluirLogin.BackColor = Color.Wheat;
                txtBuscarLogin.Enabled = true;
                btnBuscarLogin.Enabled = true;
                btnBuscarLogin.BackColor = Color.Wheat;
                dgvLogin.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvLogin.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvLogin.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirLogin()
        {
            dgvLogin.DataSource = myLogin.ExibirLogin();
            OcultarColunaExcluir();
            lblTotalLogin.Text = "Total de Logins: " + Convert.ToString(dgvLogin.Rows.Count);

            dgvLogin.Columns[1].HeaderText = "CÓDIGO";
            dgvLogin.Columns[2].HeaderText = "USUÁRIO";
            dgvLogin.Columns[3].HeaderText = "SENHA";

            dgvLogin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvLogin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarUsuarioLogin()
        {
            ValidarTamanhoCampo(txtBuscarLogin, 20);
            if (myValidar.TamanhoValido == true)
            {
                dgvLogin.DataSource = myLogin.BuscarUsuarioLogin(txtBuscarLogin.Text);
                OcultarColunaExcluir();
                lblTotalLogin.Text = "Total de Logins: " + Convert.ToString(dgvLogin.Rows.Count);
            }
        }

        private void ValidarCampoNulo(TextBox campo)
        {
            string campovalido = Convert.ToString(campo.Text);
            myValidar.CampoNulo(campovalido);

            if (myValidar.CampoValido == false)
            {
                errorIcone.SetError(campo, "Este campo é obrigatório");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarTamanhoCampo(TextBox campo, int tamanho)
        {
            string tamanhovalido = Convert.ToString(campo.Text);
            myValidar.TamanhoCampo(tamanhovalido, tamanho);

            if (myValidar.TamanhoValido == false)
            {
                errorIcone.SetError(campo, "Limite de caracteres excedido" +
                                            "\nO limite para este campo é: " + tamanho + " caracteres" +
                                            "\nQuantidade utilizada: " + campo.TextLength);
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirLogin();
            HabilitarTextBox(false);
            Botoes();
        }

        private void txtBuscarLogin_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarioLogin();
        }

        private void btnBuscarLogin_Click(object sender, EventArgs e)
        {
            BuscarUsuarioLogin();
        }

        private void btnExcluirLogin_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvLogin.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há logins selecionados para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " login(s)?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvLogin.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myLogin.ExcluirLogin(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Login(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirLogin();
                        chkExcluirLogin.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkExcluirLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirLogin.Checked)
            {
                dgvLogin.Columns[0].Visible = true;
            }
            else
            {
                dgvLogin.Columns[0].Visible = false;
            }
        }

        private void dgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLogin.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvLogin.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvLogin_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoLogin.Text = Convert.ToString(dgvLogin.CurrentRow.Cells["ID_Login"].Value);
            txtUsuarioLogin.Text = Convert.ToString(dgvLogin.CurrentRow.Cells["DS_Usuario"].Value);
            txtSenhaLogin.Text = Convert.ToString(dgvLogin.CurrentRow.Cells["DS_Senha"].Value);

            btnEditarLogin.Enabled = true;
            btnEditarLogin.BackColor = Color.Wheat;
            tctrlLogin.SelectedIndex = 1;
        }

        private void btnNovoLogin_Click(object sender, EventArgs e)
        {
            NovoLogin = true;
            EditarLogin = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtUsuarioLogin.Focus();
        }

        private void btnSalvarLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool UsuarioLoginOK = false;
                bool SenhaLoginOK = false;

                string resp = "";

                ValidarCampoNulo(txtUsuarioLogin);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtUsuarioLogin, 20);
                    if (myValidar.TamanhoValido == true)
                    {
                        UsuarioLoginOK = true;
                    }
                }

                ValidarCampoNulo(txtSenhaLogin);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtSenhaLogin, 20);
                    if (myValidar.TamanhoValido == true)
                    {
                        SenhaLoginOK = true;
                    }
                }

                bool LoginCadastrado = false;

                foreach (DataGridViewRow row in dgvLogin.Rows)
                {
                    if (txtCodigoLogin.Text != Convert.ToString(row.Cells["ID_Login"].Value))
                    {
                        if (txtUsuarioLogin.Text == Convert.ToString(row.Cells["DS_Usuario"].Value))
                        {
                            LoginCadastrado = true;
                        }
                    }
                }

                if (LoginCadastrado == true)
                {
                    MensagemErro("Este nome de usuário já pertence a um login cadastrado na base de dados");
                }
                else
                {
                    if (UsuarioLoginOK == false ||
                        SenhaLoginOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (NovoLogin)
                        {
                            resp = myLogin.InserirLogin(
                                txtUsuarioLogin.Text,
                                txtSenhaLogin.Text);
                        }
                        else
                        {
                            resp = myLogin.EditarLogin(
                                Convert.ToInt32(txtCodigoLogin.Text),
                                txtUsuarioLogin.Text,
                                txtSenhaLogin.Text);
                        }

                        if (resp.Equals("OK"))
                        {
                            if (NovoLogin)
                            {
                                MensagemOk("Registro salvo com sucesso");
                            }
                            else
                            {
                                MensagemOk("Registro editado com sucesso");
                            }

                            NovoLogin = false;
                            EditarLogin = false;
                            Botoes();
                            HabilitarTextBox(false);
                            LimparTextBox();
                            ExibirLogin();
                        }
                        else
                        {
                            MensagemErro(resp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarLogin_Click(object sender, EventArgs e)
        {
            if (txtCodigoLogin.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                txtUsuarioLogin.Focus();
                EditarLogin = true;
                NovoLogin = false;
                Botoes();
                HabilitarTextBox(true);
            }
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovoLogin = false;
            EditarLogin = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlLogin.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovoLogin = false;
                EditarLogin = false;
                Botoes();
            }
        }
    }
}
