using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewFuncionario : Form
    {
        ControlFuncionario myFuncionario = new ControlFuncionario();
        Validar myValidar = new Validar();

        private bool NovoFuncionario = false;
        private bool EditarFuncionario = false;

        public ViewFuncionario()
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
            txtCodigoFuncionario.Text = string.Empty;
            txtNomeFuncionario.Text = string.Empty;
            cboxSexoFuncionario.Text = null;
            txtCPFFuncionario.Text = string.Empty;
            dtpNascimentoFuncionario.Value = dtpNascimentoFuncionario.MaxDate;
            txtTelefoneFuncionario.Text = string.Empty;
            txtEmailFuncionario.Text = string.Empty;

            txtCargoFuncionario.Text = string.Empty;
            txtSalarioFuncionario.Text = string.Empty;
            dtpAdmissaoFuncionario.Value = dtpAdmissaoFuncionario.MaxDate;

            txtCEPFuncionario.Text = string.Empty;
            txtRuaFuncionario.Text = string.Empty;
            txtNumCasaFuncionario.Text = string.Empty;
            txtBairroFuncionario.Text = string.Empty;
            txtComplementoFuncionario.Text = string.Empty;
            txtCidadeFuncionario.Text = string.Empty;
            cboxUFFuncionario.Text = null;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoFuncionario.Enabled = false;
            txtNomeFuncionario.Enabled = Valor;
            cboxSexoFuncionario.Enabled = Valor;
            txtCPFFuncionario.Enabled = Valor;
            dtpNascimentoFuncionario.Enabled = Valor;
            txtTelefoneFuncionario.Enabled = Valor;
            txtEmailFuncionario.Enabled = Valor;

            txtCargoFuncionario.Enabled = Valor;
            txtSalarioFuncionario.Enabled = Valor;
            dtpAdmissaoFuncionario.Enabled = Valor;

            txtCEPFuncionario.Enabled = Valor;
            txtRuaFuncionario.Enabled = Valor;
            txtNumCasaFuncionario.Enabled = Valor;
            txtBairroFuncionario.Enabled = Valor;
            txtComplementoFuncionario.Enabled = Valor;
            txtCidadeFuncionario.Enabled = Valor;
            cboxUFFuncionario.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovoFuncionario || EditarFuncionario)
            {
                HabilitarTextBox(true);

                btnNovoFuncionario.Enabled = false;
                btnNovoFuncionario.BackColor = Color.Sienna;

                btnEditarFuncionario.Enabled = false;
                btnEditarFuncionario.BackColor = Color.Sienna;

                btnCancelarFuncionario.Enabled = true;
                btnCancelarFuncionario.BackColor = Color.Wheat;

                btnSalvarFuncionario.Enabled = true;
                btnSalvarFuncionario.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoFuncionario.Enabled = true;
                btnNovoFuncionario.BackColor = Color.Wheat;

                btnEditarFuncionario.Enabled = false;
                btnEditarFuncionario.BackColor = Color.Sienna;

                btnCancelarFuncionario.Enabled = false;
                btnCancelarFuncionario.BackColor = Color.Sienna;

                btnSalvarFuncionario.Enabled = false;
                btnSalvarFuncionario.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvFuncionario.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvFuncionario.Rows.Count == 0)
            {
                chkExcluirFuncionario.Enabled = false;
                btnExcluirFuncionario.Enabled = false;
                btnExcluirFuncionario.BackColor = Color.Sienna;
                cboxBuscarFuncionario.Enabled = false;
                txtBuscarNomeFuncionario.Enabled = false;
                txtBuscarCPFFuncionario.Enabled = false;
                btnBuscarFuncionario.Enabled = false;
                btnBuscarFuncionario.BackColor = Color.Sienna;
                dgvFuncionario.Enabled = false;
            }
            else
            {
                chkExcluirFuncionario.Enabled = true;
                btnExcluirFuncionario.Enabled = true;
                btnExcluirFuncionario.BackColor = Color.Wheat;
                cboxBuscarFuncionario.Enabled = true;
                txtBuscarNomeFuncionario.Enabled = true;
                txtBuscarCPFFuncionario.Enabled = true;
                btnBuscarFuncionario.Enabled = true;
                btnExcluirFuncionario.BackColor = Color.Wheat;
                dgvFuncionario.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvFuncionario.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirFuncionario()
        {
            dgvFuncionario.DataSource = myFuncionario.ExibirFuncionario();
            OcultarColunaExcluir();
            lblTotalFuncionario.Text = "Total de Funcionários: " + Convert.ToString(dgvFuncionario.Rows.Count);

            dgvFuncionario.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvFuncionario.Columns[1].HeaderText = "CÓDIGO";
            dgvFuncionario.Columns[2].HeaderText = "NOME";
            dgvFuncionario.Columns[3].HeaderText = "SEXO";
            dgvFuncionario.Columns[4].HeaderText = "CPF";
            dgvFuncionario.Columns[5].HeaderText = "DATA\nNASCIMENTO";
            dgvFuncionario.Columns[6].HeaderText = "TELEFONE";
            dgvFuncionario.Columns[7].HeaderText = "E-MAIL";
            dgvFuncionario.Columns[8].HeaderText = "CARGO";
            dgvFuncionario.Columns[9].HeaderText = "SALÁRIO";
            dgvFuncionario.Columns[10].HeaderText = "DATA\nADMISSÃO";
            dgvFuncionario.Columns[11].HeaderText = "RUA";
            dgvFuncionario.Columns[12].HeaderText = "Nº";
            dgvFuncionario.Columns[13].HeaderText = "COMPLEMENTO";
            dgvFuncionario.Columns[14].HeaderText = "BAIRRO";
            dgvFuncionario.Columns[15].HeaderText = "CEP";
            dgvFuncionario.Columns[16].HeaderText = "CIDADE";
            dgvFuncionario.Columns[17].HeaderText = "UF";

            dgvFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarFuncionario()
        {
            if (cboxBuscarFuncionario.Text.Equals("Nome"))
            {
                ValidarTamanhoCampo(txtBuscarNomeFuncionario, 50);
                if (myValidar.TamanhoValido == true)
                {
                    dgvFuncionario.DataSource = myFuncionario.BuscarNomeFuncionario(txtBuscarNomeFuncionario.Text);
                    OcultarColunaExcluir();
                    lblTotalFuncionario.Text = "Total de Funcionários: " + Convert.ToString(dgvFuncionario.Rows.Count);
                }
            }
            else if (cboxBuscarFuncionario.Text.Equals("CPF"))
            {
                if (txtBuscarCPFFuncionario.MaskCompleted)
                {
                    if (myValidar.ValidaCPF(txtBuscarCPFFuncionario.Text) == false)
                    {
                        errorIcone.SetError(txtBuscarCPFFuncionario, "Número de CPF inválido");
                    }
                    else
                    {
                        errorIcone.SetError(txtBuscarCPFFuncionario, string.Empty);
                    }
                }

                dgvFuncionario.DataSource = myFuncionario.BuscarCPFFuncionario(txtBuscarCPFFuncionario.Text);
                OcultarColunaExcluir();
                lblTotalFuncionario.Text = "Total de Funcionários: " + Convert.ToString(dgvFuncionario.Rows.Count);
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

        private void ValidarCampoNuloMasked(MaskedTextBox campo)
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

        private void ValidarNome(TextBox campo)
        {
            string nomevalido = Convert.ToString(campo.Text);
            myValidar.Nome(nomevalido);

            if (myValidar.NomeValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com letras." +
                                            "\nÉ necessário o nome e ao menos um sobrenome.");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarLetra(TextBox campo)
        {
            string letravalida = Convert.ToString(campo.Text);
            myValidar.Letra(letravalida);

            if (myValidar.LetraValida == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com letras");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarNumero(TextBox campo)
        {
            string numerovalido = Convert.ToString(campo.Text);
            myValidar.Numero(numerovalido);

            if (myValidar.NumeroValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarNascimento(DateTimePicker campo)
        {
            myValidar.DataNascimentoObrigatorio(campo);

            if (myValidar.DtNascimentoValido == false)
            {
                errorIcone.SetError(campo, "O funcionário deve ter mais de 18 anos para ser cadastrado");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ValidarValor(TextBox campo)
        {
            string valorvalido = Convert.ToString(campo.Text);
            myValidar.Valor(valorvalido);

            if (myValidar.ValorValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números, vírgulas e pontos." +
                                            "\nVerifique também a disposição dos números conforme Ex: 999.999,00");
            }
            else
            {
                errorIcone.SetError(campo, string.Empty);
            }
        }

        private void ViewFuncionario_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirFuncionario();
            HabilitarTextBox(false);
            Botoes();
            txtCodigoFuncionario.Enabled = false;

            dtpAdmissaoFuncionario.MaxDate = DateTime.Today;
            dtpAdmissaoFuncionario.Value = dtpAdmissaoFuncionario.MaxDate;

            dtpNascimentoFuncionario.MinDate = DateTime.Today.AddYears(-130);
            dtpNascimentoFuncionario.MaxDate = DateTime.Today;
        }

        private void cboBuscarFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBuscarFuncionario.Text.Equals("Nome"))
            {
                txtBuscarCPFFuncionario.Text = string.Empty;
                txtBuscarCPFFuncionario.Visible = false;
                txtBuscarNomeFuncionario.Visible = true;
                txtBuscarNomeFuncionario.Text = string.Empty;
                errorIcone.SetError(txtBuscarNomeFuncionario, string.Empty);

            }
            else if (cboxBuscarFuncionario.Text.Equals("CPF"))
            {
                txtBuscarNomeFuncionario.Visible = false;
                txtBuscarNomeFuncionario.Text = string.Empty;
                txtBuscarCPFFuncionario.Visible = true;
                txtBuscarCPFFuncionario.Text = string.Empty;
                errorIcone.SetError(txtBuscarCPFFuncionario, string.Empty);

            }
        }

        private void txtBuscarNomeFuncionario_TextChanged(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void txtBuscarCPFFuncionario_TextChanged(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void chkExcluirFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirFuncionario.Checked)
            {
                dgvFuncionario.Columns[0].Visible = true;
            }
            else
            {
                dgvFuncionario.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvFuncionario.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvFuncionario.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há funcionário(s) selecionado(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " funcionário(s)?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvFuncionario.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myFuncionario.ExcluirFuncionario(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Funcionário(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirFuncionario();
                        chkExcluirFuncionario.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFuncionario.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dgvFuncionario.Rows[e.RowIndex].Cells["Excluir"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFuncionario.Rows.Count == 0)
            {
                MensagemErro("Não há funcionários cadastrados");
            }
            else
            {
                txtCodigoFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["ID_Funcionario"].Value);
                txtNomeFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NM_Funcionario"].Value);
                cboxSexoFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["DS_Sexo"].Value);
                txtCPFFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NR_CPF"].Value);
                dtpNascimentoFuncionario.Value = Convert.ToDateTime(dgvFuncionario.CurrentRow.Cells["DT_Nascimento"].Value);
                txtTelefoneFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NR_Telefone"].Value);
                txtEmailFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["DS_Email"].Value);
                txtCEPFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NR_CEP"].Value);
                txtRuaFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NM_Rua"].Value);
                txtNumCasaFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NR_Casa"].Value);
                txtBairroFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NM_Bairro"].Value);
                txtComplementoFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["DS_Complemento"].Value);
                txtCidadeFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["NM_Cidade"].Value);
                cboxUFFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["DS_UF"].Value);
                txtCargoFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["DS_Cargo"].Value);
                txtSalarioFuncionario.Text = Convert.ToString(dgvFuncionario.CurrentRow.Cells["VL_Salario"].Value);
                dtpAdmissaoFuncionario.Value = Convert.ToDateTime(dgvFuncionario.CurrentRow.Cells["DT_Admissao"].Value);

                btnEditarFuncionario.Enabled = true;
                btnEditarFuncionario.BackColor = Color.Wheat;
                tctrlFuncionario.SelectedIndex = 1;
            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            NovoFuncionario = true;
            EditarFuncionario = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtNomeFuncionario.Focus();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeFuncionarioOK = false;
                bool CPFFuncionarioOK = false;
                bool NascimentoFuncionarioOK = false;
                bool TelefoneFuncionarioOK = false;
                bool EmailFuncionarioOK = false;
                bool CargoFuncionarioOK = false;
                bool SalarioFuncionarioOK = false;
                bool CEPFuncionarioOK = false;
                bool RuaFuncionarioOK = false;
                bool NumCasaFuncionarioOK = false;
                bool BairroFuncionarioOK = false;
                bool ComplementoFuncionarioOK = false;
                bool CidadeFuncionarioOK = false;

                bool CPFcadastrado = false;

                string resp = "";

                ValidarCampoNulo(txtNomeFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNome(txtNomeFuncionario);
                        if (myValidar.NomeValido == true)
                        {
                            NomeFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNuloMasked(txtCPFFuncionario);
                if (myValidar.CampoValido == true)
                {
                    if (!txtCPFFuncionario.MaskCompleted)
                    {
                        errorIcone.SetError(txtCPFFuncionario, "O CPF está incompleto");
                    }
                    else
                    {
                        if (myValidar.ValidaCPF(txtCPFFuncionario.Text) == false)
                        {
                            errorIcone.SetError(txtCPFFuncionario, "Número de CPF inválido");
                        }
                        else
                        {
                            errorIcone.SetError(txtCPFFuncionario, string.Empty);
                            CPFFuncionarioOK = true;
                        }
                    }
                }

                ValidarNascimento(dtpNascimentoFuncionario);
                if (myValidar.DtNascimentoValido == true)
                {
                    NascimentoFuncionarioOK = true;
                }

                if (cboxSexoFuncionario.Text == null)
                {
                    cboxSexoFuncionario.Text = null;
                }

                ValidarCampoNuloMasked(txtTelefoneFuncionario);
                if (myValidar.CampoValido == true)
                {
                    if (!txtTelefoneFuncionario.MaskCompleted)
                    {
                        errorIcone.SetError(txtTelefoneFuncionario, "O telefone está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtTelefoneFuncionario, string.Empty);
                        TelefoneFuncionarioOK = true;
                    }
                }

                if (txtEmailFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtEmailFuncionario, 80);
                    if (myValidar.TamanhoValido == true)
                    {
                        EmailFuncionarioOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtEmailFuncionario, string.Empty);
                    EmailFuncionarioOK = true;
                }

                if (txtCEPFuncionario.Text != string.Empty)
                {
                    if (!txtCEPFuncionario.MaskCompleted)
                    {
                        errorIcone.SetError(txtCEPFuncionario, "O CEP está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtCEPFuncionario, string.Empty);
                        CEPFuncionarioOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtCEPFuncionario, string.Empty);
                    CEPFuncionarioOK = true;
                }

                ValidarCampoNulo(txtRuaFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtRuaFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        RuaFuncionarioOK = true;
                    }
                }

                ValidarCampoNulo(txtNumCasaFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNumCasaFuncionario, 5);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNumero(txtNumCasaFuncionario);
                        if (myValidar.NumeroValido == true)
                        {
                            NumCasaFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtBairroFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtBairroFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        BairroFuncionarioOK = true;
                    }
                }

                if (txtComplementoFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtComplementoFuncionario, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ComplementoFuncionarioOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtComplementoFuncionario, string.Empty);
                    ComplementoFuncionarioOK = true;
                }

                if (txtCidadeFuncionario.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtCidadeFuncionario, 30);
                    if (myValidar.TamanhoValido == true)
                    {
                        CidadeFuncionarioOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtCidadeFuncionario, string.Empty);
                    CidadeFuncionarioOK = true;
                }

                ValidarCampoNulo(txtCargoFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtCargoFuncionario, 30);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarLetra(txtCargoFuncionario);
                        if (myValidar.LetraValida == true)
                        {
                            CargoFuncionarioOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtSalarioFuncionario);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtSalarioFuncionario);
                    if (myValidar.ValorValido == true)
                    {
                        SalarioFuncionarioOK = true;
                    }
                }

                if (NomeFuncionarioOK == false ||
                    CPFFuncionarioOK == false ||
                    NascimentoFuncionarioOK == false ||
                    TelefoneFuncionarioOK == false ||
                    EmailFuncionarioOK == false ||
                    CargoFuncionarioOK == false ||
                    SalarioFuncionarioOK == false ||
                    CEPFuncionarioOK == false ||
                    RuaFuncionarioOK == false ||
                    NumCasaFuncionarioOK == false ||
                    BairroFuncionarioOK == false ||
                    ComplementoFuncionarioOK == false ||
                    CidadeFuncionarioOK == false)
                {
                    MensagemErro("Preencha corretamente todos os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (NovoFuncionario)
                    {
                        foreach (DataGridViewRow row in dgvFuncionario.Rows)
                        {
                            if (txtCPFFuncionario.Text == Convert.ToString(row.Cells["NR_CPF"].Value))
                            {
                                CPFcadastrado = true;
                            }
                        }

                        if (CPFcadastrado == true)
                        {
                            MensagemErro("CPF já cadastrado na base de dados");
                        }
                        else
                        {
                            resp = myFuncionario.InserirFuncionario(
                            txtNomeFuncionario.Text.Trim(),
                            cboxSexoFuncionario.Text,
                            txtCPFFuncionario.Text,
                            dtpNascimentoFuncionario.Value,
                            txtTelefoneFuncionario.Text,
                            txtEmailFuncionario.Text.Trim(),
                            txtCEPFuncionario.Text,
                            txtRuaFuncionario.Text.Trim(),
                            txtNumCasaFuncionario.Text,
                            txtBairroFuncionario.Text.Trim(),
                            txtComplementoFuncionario.Text.Trim(),
                            txtCidadeFuncionario.Text.Trim(),
                            cboxUFFuncionario.Text,
                            txtCargoFuncionario.Text.Trim(),
                            Convert.ToDouble(txtSalarioFuncionario.Text),
                            dtpAdmissaoFuncionario.Value);
                        }
                    }
                    else
                    {
                        resp = myFuncionario.EditarFuncionario(
                            Convert.ToInt32(txtCodigoFuncionario.Text),
                            txtNomeFuncionario.Text.Trim(),
                            cboxSexoFuncionario.Text,
                            txtCPFFuncionario.Text,
                            dtpNascimentoFuncionario.Value,
                            txtTelefoneFuncionario.Text,
                            txtEmailFuncionario.Text.Trim(),
                            txtCEPFuncionario.Text,
                            txtRuaFuncionario.Text.Trim(),
                            txtNumCasaFuncionario.Text,
                            txtBairroFuncionario.Text.Trim(),
                            txtComplementoFuncionario.Text.Trim(),
                            txtCidadeFuncionario.Text.Trim(),
                            cboxUFFuncionario.Text,
                            txtCargoFuncionario.Text.Trim(),
                            Convert.ToDouble(txtSalarioFuncionario.Text),
                            dtpAdmissaoFuncionario.Value);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (NovoFuncionario)
                        {
                            MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            MensagemOk("Registro editado com sucesso");
                        }

                        NovoFuncionario = false;
                        EditarFuncionario = false;
                        Botoes();
                        LimparTextBox();
                        ExibirFuncionario();
                    }
                    else
                    {
                        if (CPFcadastrado == false)
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

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtNomeFuncionario.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                txtCodigoFuncionario.Enabled = false;
                EditarFuncionario = true;
                NovoFuncionario = false;
                Botoes();
                HabilitarTextBox(true);

                txtCodigoFuncionario.Enabled = false;
                txtCPFFuncionario.Enabled = false;
                txtNomeFuncionario.Enabled = false;
                dtpNascimentoFuncionario.Enabled = false;
                dtpAdmissaoFuncionario.Enabled = false;
            }
        }

        private void btnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovoFuncionario = false;
            EditarFuncionario = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlFuncionario.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovoFuncionario = false;
                EditarFuncionario = false;
                Botoes();
            }
        }
    }
}
