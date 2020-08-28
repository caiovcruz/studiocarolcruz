using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCliente : Form
    {
        ControlCliente myCliente = new ControlCliente();
        Validar myValidar = new Validar();

        private bool NovoCliente = false;
        private bool EditarCliente = false;

        public ViewCliente()
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
            txtCodigoCliente.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            cboxSexoCliente.Text = null;
            txtCPFCliente.Text = string.Empty;
            dtpNascimentoCliente.Value = dtpNascimentoCliente.MaxDate;
            txtTelefoneCliente.Text = string.Empty;
            txtEmailCliente.Text = string.Empty;

            txtCEPCliente.Text = string.Empty;
            txtRuaCliente.Text = string.Empty;
            txtNumCasaCliente.Text = string.Empty;
            txtBairroCliente.Text = string.Empty;
            txtComplementoCliente.Text = string.Empty;
            txtCidadeCliente.Text = string.Empty;
            cboxUFCliente.Text = null;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoCliente.Enabled = false;
            txtNomeCliente.Enabled = Valor;
            cboxSexoCliente.Enabled = Valor;
            txtCPFCliente.Enabled = Valor;
            dtpNascimentoCliente.Enabled = Valor;
            txtTelefoneCliente.Enabled = Valor;
            txtEmailCliente.Enabled = Valor;

            txtCEPCliente.Enabled = Valor;
            txtRuaCliente.Enabled = Valor;
            txtNumCasaCliente.Enabled = Valor;
            txtBairroCliente.Enabled = Valor;
            txtComplementoCliente.Enabled = Valor;
            txtCidadeCliente.Enabled = Valor;
            cboxUFCliente.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovoCliente || EditarCliente)
            {
                HabilitarTextBox(true);

                btnNovoCliente.Enabled = false;
                btnNovoCliente.BackColor = Color.Sienna;

                btnEditarCliente.Enabled = false;
                btnEditarCliente.BackColor = Color.Sienna;

                btnCancelarCliente.Enabled = true;
                btnCancelarCliente.BackColor = Color.Wheat;

                btnSalvarCliente.Enabled = true;
                btnSalvarCliente.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoCliente.Enabled = true;
                btnNovoCliente.BackColor = Color.Wheat;

                btnEditarCliente.Enabled = false;
                btnEditarCliente.BackColor = Color.Sienna;

                btnCancelarCliente.Enabled = false;
                btnCancelarCliente.BackColor = Color.Sienna;

                btnSalvarCliente.Enabled = false;
                btnSalvarCliente.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvCliente.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvCliente.Rows.Count == 0)
            {
                chkExcluirCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;
                btnExcluirCliente.BackColor = Color.Sienna;
                cboxBuscarCliente.Enabled = false;
                txtBuscarNomeCliente.Enabled = false;
                txtBuscarCPFCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnBuscarCliente.BackColor = Color.Sienna;
                dgvCliente.Enabled = false;
            }
            else
            {
                chkExcluirCliente.Enabled = true;
                btnExcluirCliente.Enabled = true;
                btnExcluirCliente.BackColor = Color.Wheat;
                cboxBuscarCliente.Enabled = true;
                txtBuscarNomeCliente.Enabled = true;
                txtBuscarCPFCliente.Enabled = true;
                btnBuscarCliente.Enabled = true;
                btnBuscarCliente.BackColor = Color.Wheat;
                dgvCliente.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvCliente.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirClientes()
        {
            dgvCliente.DataSource = myCliente.ExibirClientes();
            OcultarColunaExcluir();
            lblTotalCliente.Text = "Total de Clientes: " + Convert.ToString(dgvCliente.Rows.Count);

            dgvCliente.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvCliente.Columns[1].HeaderText = "CÓDIGO";
            dgvCliente.Columns[2].HeaderText = "NOME";
            dgvCliente.Columns[3].HeaderText = "SEXO";
            dgvCliente.Columns[4].HeaderText = "CPF";
            dgvCliente.Columns[5].HeaderText = "DATA\nNASCIMENTO";
            dgvCliente.Columns[6].HeaderText = "TELEFONE";
            dgvCliente.Columns[7].HeaderText = "E-MAIL";
            dgvCliente.Columns[8].HeaderText = "RUA";
            dgvCliente.Columns[9].HeaderText = "Nº";
            dgvCliente.Columns[10].HeaderText = "COMPLEMENTO";
            dgvCliente.Columns[11].HeaderText = "BAIRRO";
            dgvCliente.Columns[12].HeaderText = "CEP";
            dgvCliente.Columns[13].HeaderText = "CIDADE";
            dgvCliente.Columns[14].HeaderText = "UF";

            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarCliente()
        {
            if (cboxBuscarCliente.Text.Equals("Nome"))
            {
                ValidarTamanhoCampo(txtBuscarNomeCliente, 50);
                if (myValidar.TamanhoValido == true)
                {
                    dgvCliente.DataSource = myCliente.BuscarNomeCliente(txtBuscarNomeCliente.Text);
                    OcultarColunaExcluir();
                    lblTotalCliente.Text = "Total de Clientes: " + Convert.ToString(dgvCliente.Rows.Count);
                }
            }
            else if (cboxBuscarCliente.Text.Equals("CPF"))
            {
                if (txtBuscarCPFCliente.MaskCompleted)
                {
                    if (myValidar.ValidaCPF(txtBuscarCPFCliente.Text) == false)
                    {
                        errorIcone.SetError(txtBuscarCPFCliente, "Número de CPF inválido");
                    }
                    else
                    {
                        errorIcone.SetError(txtBuscarCPFCliente, string.Empty);
                    }
                }

                errorIcone.SetError(txtCPFCliente, string.Empty);
                dgvCliente.DataSource = myCliente.BuscarCPFCliente(txtBuscarCPFCliente.Text);
                OcultarColunaExcluir();
                lblTotalCliente.Text = "Total de Clientes: " + Convert.ToString(dgvCliente.Rows.Count);
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

        private void ViewCliente_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirClientes();
            HabilitarTextBox(false);
            Botoes();

            dtpNascimentoCliente.MinDate = DateTime.Today.AddYears(-130);
            dtpNascimentoCliente.MaxDate = DateTime.Today;
        }

        private void cboBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBuscarCliente.Text.Equals("Nome"))
            {
                txtBuscarCPFCliente.Text = string.Empty;
                txtBuscarCPFCliente.Visible = false;
                txtBuscarNomeCliente.Visible = true;
                txtBuscarNomeCliente.Text = string.Empty;
                errorIcone.SetError(txtBuscarNomeCliente, string.Empty);
            }
            else if (cboxBuscarCliente.Text.Equals("CPF"))
            {
                txtBuscarNomeCliente.Visible = false;
                txtBuscarNomeCliente.Text = string.Empty;
                txtBuscarCPFCliente.Visible = true;
                txtBuscarCPFCliente.Text = string.Empty;
                errorIcone.SetError(txtBuscarCPFCliente, string.Empty);
            }
        }

        private void txtBuscarNomeCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void txtBuscarCPFCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void chkExcluirCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirCliente.Checked)
            {
                dgvCliente.Columns[0].Visible = true;
            }
            else
            {
                dgvCliente.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há cliente(s) selecionado(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " cliente(s)?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvCliente.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myCliente.ExcluirCliente(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Cliente(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirClientes();
                        chkExcluirCliente.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCliente.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dgvCliente.Rows[e.RowIndex].Cells["Excluir"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["ID_Cliente"].Value);
            txtNomeCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NM_Cliente"].Value);
            cboxSexoCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["DS_Sexo"].Value);
            txtCPFCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NR_CPF"].Value);

            try
            {
                dtpNascimentoCliente.Value = Convert.ToDateTime(dgvCliente.CurrentRow.Cells["DT_Nascimento"].Value);
            }
            catch (Exception)
            {
                dtpNascimentoCliente.Value = dtpNascimentoCliente.MaxDate;
            }

            txtTelefoneCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NR_Telefone"].Value);
            txtEmailCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["DS_Email"].Value);
            txtCEPCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NR_CEP"].Value);
            txtRuaCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NM_Rua"].Value);
            txtNumCasaCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NR_Casa"].Value);
            txtBairroCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NM_Bairro"].Value);
            txtComplementoCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["DS_Complemento"].Value);
            txtCidadeCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["NM_Cidade"].Value);
            cboxUFCliente.Text = Convert.ToString(dgvCliente.CurrentRow.Cells["DS_UF"].Value);

            btnEditarCliente.Enabled = true;
            btnEditarCliente.BackColor = Color.Wheat;
            tctrlCliente.SelectedIndex = 1;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            NovoCliente = true;
            EditarCliente = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtNomeCliente.Focus();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                bool NomeClienteOK = false;
                bool CPFClienteOK = false;
                bool TelefoneClienteOK = false;
                bool EmailClienteOK = false;
                bool CEPClienteOK = false;
                bool RuaClienteOK = false;
                bool NumCasaClienteOK = false;
                bool BairroClienteOK = false;
                bool ComplementoClienteOK = false;
                bool CidadeClienteOK = false;

                bool CPFcadastrado = false;

                ValidarCampoNulo(txtNomeCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNome(txtNomeCliente);
                        if (myValidar.NomeValido == true)
                        {
                            NomeClienteOK = true;
                        }
                    }
                }


                if (txtCPFCliente.Text != string.Empty)
                {
                    if (!txtCPFCliente.MaskCompleted)
                    {
                        errorIcone.SetError(txtCPFCliente, "O CPF está incompleto");
                    }
                    else
                    {
                        if (myValidar.ValidaCPF(txtCPFCliente.Text) == false)
                        {
                            errorIcone.SetError(txtCPFCliente, "Número de CPF inválido");
                        }
                        else
                        {
                            errorIcone.SetError(txtCPFCliente, string.Empty);
                            CPFClienteOK = true;
                        }
                    }
                }
                else
                {
                    errorIcone.SetError(txtCPFCliente, string.Empty);
                    CPFClienteOK = true;
                }

                myValidar.DataNascimento(dtpNascimentoCliente);

                if (cboxSexoCliente.Text == string.Empty)
                {
                    cboxSexoCliente.Text = null;
                }

                ValidarCampoNuloMasked(txtTelefoneCliente);
                if (myValidar.CampoValido == true)
                {
                    if (!txtTelefoneCliente.MaskCompleted)
                    {
                        errorIcone.SetError(txtTelefoneCliente, "O telefone está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtTelefoneCliente, string.Empty);
                        TelefoneClienteOK = true;
                    }
                }

                if (txtEmailCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtEmailCliente, 80);
                    if (myValidar.TamanhoValido == true)
                    {
                        EmailClienteOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtEmailCliente, string.Empty);
                    EmailClienteOK = true;
                }

                if (txtCEPCliente.Text != string.Empty)
                {
                    if (!txtCEPCliente.MaskCompleted)
                    {
                        errorIcone.SetError(txtCEPCliente, "O CEP está incompleto");
                    }
                    else
                    {
                        errorIcone.SetError(txtCEPCliente, string.Empty);
                        CEPClienteOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtCEPCliente, string.Empty);
                    CEPClienteOK = true;
                }

                ValidarCampoNulo(txtRuaCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtRuaCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        RuaClienteOK = true;
                    }
                }

                ValidarCampoNulo(txtNumCasaCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNumCasaCliente, 5);
                    if (myValidar.TamanhoValido == true)
                    {
                        ValidarNumero(txtNumCasaCliente);
                        if (myValidar.NumeroValido == true)
                        {
                            NumCasaClienteOK = true;
                        }
                    }
                }

                ValidarCampoNulo(txtBairroCliente);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtBairroCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        BairroClienteOK = true;
                    }
                }

                if (txtComplementoCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtComplementoCliente, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ComplementoClienteOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtComplementoCliente, string.Empty);
                    ComplementoClienteOK = true;
                }

                if (txtCidadeCliente.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtCidadeCliente, 30);
                    if (myValidar.TamanhoValido == true)
                    {
                        CidadeClienteOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtCidadeCliente, string.Empty);
                    CidadeClienteOK = true;
                }

                if (NomeClienteOK == false ||
                    CPFClienteOK == false ||
                    TelefoneClienteOK == false ||
                    EmailClienteOK == false ||
                    CEPClienteOK == false ||
                    RuaClienteOK == false ||
                    NumCasaClienteOK == false ||
                    BairroClienteOK == false ||
                    ComplementoClienteOK == false ||
                    CidadeClienteOK == false)
                {
                    MensagemErro("Preencha corretamente todos os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (NovoCliente)
                    {
                        foreach (DataGridViewRow row in dgvCliente.Rows)
                        {
                            if (txtCPFCliente.Text == Convert.ToString(row.Cells["NR_CPF"].Value))
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
                            resp = myCliente.InserirCliente(
                            txtNomeCliente.Text.Trim(),
                            cboxSexoCliente.Text,
                            txtCPFCliente.Text,
                            myValidar.DtNascimento,
                            txtTelefoneCliente.Text,
                            txtEmailCliente.Text.Trim(),
                            txtCEPCliente.Text,
                            txtRuaCliente.Text.Trim(),
                            txtNumCasaCliente.Text,
                            txtBairroCliente.Text.Trim(),
                            txtComplementoCliente.Text.Trim(),
                            txtCidadeCliente.Text.Trim(),
                            cboxUFCliente.Text);
                        }
                    }
                    else
                    {
                        resp = myCliente.EditarCliente(
                            Convert.ToInt32(txtCodigoCliente.Text),
                            txtNomeCliente.Text.Trim(),
                            cboxSexoCliente.Text,
                            txtCPFCliente.Text,
                            myValidar.DtNascimento,
                            txtTelefoneCliente.Text,
                            txtEmailCliente.Text.Trim(),
                            txtCEPCliente.Text,
                            txtRuaCliente.Text.Trim(),
                            txtNumCasaCliente.Text,
                            txtBairroCliente.Text.Trim(),
                            txtComplementoCliente.Text.Trim(),
                            txtCidadeCliente.Text.Trim(),
                            cboxUFCliente.Text);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (NovoCliente)
                        {
                            MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            MensagemOk("Registro editado com sucesso");
                        }

                        NovoCliente = false;
                        EditarCliente = false;
                        Botoes();
                        LimparTextBox();
                        ExibirClientes();
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

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                EditarCliente = true;
                NovoCliente = false;
                Botoes();
                HabilitarTextBox(true);

                txtNomeCliente.Enabled = false;

                if (txtCPFCliente.Text != string.Empty)
                {
                    txtCPFCliente.Enabled = false;
                }

                if (dtpNascimentoCliente.Value != DateTime.Today)
                {
                    dtpNascimentoCliente.Enabled = false;
                }
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovoCliente = false;
            EditarCliente = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCliente.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovoCliente = false;
                EditarCliente = false;
                Botoes();
            }
        }
    }
}
