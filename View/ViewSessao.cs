using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewSessao : Form
    {
        ControlSessao mySessao = new ControlSessao();
        Validar myValidar = new Validar();

        private bool NovaSessao = false;
        private bool EditarSessao = false;

        public ViewSessao()
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
            txtCodigoVendaSessao.Text = string.Empty;
            txtCodigoProcedimentoSessao.Text = string.Empty;
            txtProcedimentoSessao.Text = string.Empty;
            dtUltimaSessao.Value = DateTime.Today.AddDays(1);
            txtSessaoAtual.Text = string.Empty;
            txtQuantidadeSessao.Text = string.Empty;
            txtClienteSessao.Text = string.Empty;
            txtObservacaoSessao.Text = string.Empty;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoVendaSessao.Enabled = false;
            txtCodigoProcedimentoSessao.Enabled = false;
            txtProcedimentoSessao.Enabled = false;
            dtUltimaSessao.Enabled = false;
            txtSessaoAtual.Enabled = Valor;
            txtQuantidadeSessao.Enabled = false;
            txtClienteSessao.Enabled = false;
            txtObservacaoSessao.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovaSessao || EditarSessao)
            {
                HabilitarTextBox(true);

                btnEditarSessao.Enabled = false;
                btnEditarSessao.BackColor = Color.Sienna;

                btnCancelarSessao.Enabled = true;
                btnCancelarSessao.BackColor = Color.Wheat;

                btnSalvarSessao.Enabled = true;
                btnSalvarSessao.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnEditarSessao.Enabled = false;
                btnEditarSessao.BackColor = Color.Sienna;

                btnCancelarSessao.Enabled = false;
                btnCancelarSessao.BackColor = Color.Sienna;

                btnSalvarSessao.Enabled = false;
                btnSalvarSessao.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvSessao.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvSessao.Rows.Count == 0)
            {
                chkExcluirSessao.Enabled = false;
                btnExcluirSessao.Enabled = false;
                btnExcluirSessao.BackColor = Color.Sienna;
                cboxBuscarSessao.Enabled = false;
                txtBuscarSessao.Enabled = false;
                btnBuscarSessao.Enabled = false;
                btnBuscarSessao.BackColor = Color.Sienna;
                dgvSessao.Enabled = false;
            }
            else
            {
                chkExcluirSessao.Enabled = true;
                btnExcluirSessao.Enabled = true;
                btnExcluirSessao.BackColor = Color.Wheat;
                cboxBuscarSessao.Enabled = true;
                txtBuscarSessao.Enabled = true;
                btnBuscarSessao.Enabled = true;
                btnBuscarSessao.BackColor = Color.Wheat;
                dgvSessao.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvSessao.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvSessao.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirSessao()
        {
            dgvSessao.DataSource = mySessao.ExibirSessao();
            OcultarColunaExcluir();
            lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);

            dgvSessao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSessao.Columns[1].HeaderText = "VENDA";
            dgvSessao.Columns[2].Visible = false;
            dgvSessao.Columns[3].HeaderText = "CLIENTE";
            dgvSessao.Columns[4].HeaderText = "PROCEDIMENTO";
            dgvSessao.Columns[5].HeaderText = "SESSÃO\nATUAL";
            dgvSessao.Columns[6].HeaderText = "TOTAL\nSESSÕES";
            dgvSessao.Columns[7].Visible = false;
            dgvSessao.Columns[8].HeaderText = "DATA ULT.\nSESSÃO";

            dgvSessao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSessao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void ExibirSessaoDisponivel()
        {
            dgvSessao.DataSource = mySessao.ExibirSessaoDisponivel();
            OcultarColunaExcluir();
            lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);

            dgvSessao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSessao.Columns[1].HeaderText = "VENDA";
            dgvSessao.Columns[2].Visible = false;
            dgvSessao.Columns[3].HeaderText = "CLIENTE";
            dgvSessao.Columns[4].HeaderText = "PROCEDIMENTO";
            dgvSessao.Columns[5].HeaderText = "SESSÃO\nATUAL";
            dgvSessao.Columns[6].HeaderText = "TOTAL\nSESSÕES";
            dgvSessao.Columns[7].Visible = false;
            dgvSessao.Columns[8].HeaderText = "DATA ULT.\nSESSÃO";

            dgvSessao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSessao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarSessao()
        {
            if (cboxBuscarSessao.Text.Equals("Cliente"))
            {
                ValidarTamanhoCampo(txtBuscarSessao, 50);
                if (myValidar.TamanhoValido == true)
                {
                    if (chkExibirTodasSessoes.Checked)
                    {
                        dgvSessao.DataSource = mySessao.BuscarClienteSessao(txtBuscarSessao.Text);
                        OcultarColunaExcluir();
                        lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);
                    }
                    else
                    {
                        dgvSessao.DataSource = mySessao.BuscarClienteSessaoDisponivel(txtBuscarSessao.Text);
                        OcultarColunaExcluir();
                        lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);
                    }

                }
            }
            else if (cboxBuscarSessao.Text.Equals("Procedimento"))
            {
                ValidarTamanhoCampo(txtBuscarSessao, 50);
                if (myValidar.TamanhoValido == true)
                {
                    if (chkExibirTodasSessoes.Checked)
                    {
                        dgvSessao.DataSource = mySessao.BuscarProcedimentoSessao(txtBuscarSessao.Text);
                        OcultarColunaExcluir();
                        lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);
                    }
                    else
                    {
                        dgvSessao.DataSource = mySessao.BuscarProcedimentoSessaoDisponivel(txtBuscarSessao.Text);
                        OcultarColunaExcluir();
                        lblTotalSessao.Text = "Total de Sessões: " + Convert.ToString(dgvSessao.Rows.Count);
                    }
                }
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

        private void ViewSessao_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirSessaoDisponivel();
            HabilitarTextBox(false);
            Botoes();

            dtUltimaSessao.MaxDate = DateTime.Today.AddDays(1);
        }

        private void cboxBuscarSessao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarSessao.Text = string.Empty;
            errorIcone.SetError(txtBuscarSessao, string.Empty);
        }

        private void txtBuscarSessao_TextChanged(object sender, EventArgs e)
        {
            BuscarSessao();
        }

        private void btnBuscarSessao_Click(object sender, EventArgs e)
        {
            BuscarSessao();
        }

        private void chkExcluirSessao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirSessao.Checked)
            {
                dgvSessao.Columns[0].Visible = true;
            }
            else
            {
                dgvSessao.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvSessao.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirSessao_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvSessao.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há sessões selecionadas para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " sessões?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Venda;
                        int Procedimento;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvSessao.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Venda = Convert.ToInt32(row.Cells[1].Value);
                                Procedimento = Convert.ToInt32(row.Cells[2].Value);
                                resp = mySessao.ExcluirSessao(Venda, Procedimento);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Sessões excluídas com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        if (chkExibirTodasSessoes.Checked)
                        {
                            ExibirSessao();
                        }
                        else
                        {
                            ExibirSessaoDisponivel();
                        }

                        chkExcluirSessao.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvSessao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSessao.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dgvSessao.Rows[e.RowIndex].Cells["Excluir"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dgvSessao_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoVendaSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["ID_Venda"].Value);
            txtCodigoProcedimentoSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["ID_Procedimento"].Value);
            txtProcedimentoSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["NM_Procedimento"].Value);
            dtUltimaSessao.Value = Convert.ToDateTime(dgvSessao.CurrentRow.Cells["DT_UltimaSessao"].Value);
            txtSessaoAtual.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["NR_SessaoAtual"].Value);
            txtQuantidadeSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["QTDE_Sessao"].Value);
            txtClienteSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["NM_Cliente"].Value);
            txtObservacaoSessao.Text = Convert.ToString(dgvSessao.CurrentRow.Cells["OBS_Sessao"].Value);

            btnEditarSessao.Enabled = true;
            btnEditarSessao.BackColor = Color.Wheat;
            tctrlSessao.SelectedIndex = 1;
        }

        private void btnEditarSessao_Click(object sender, EventArgs e)
        {
            if (txtProcedimentoSessao.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                EditarSessao = true;
                NovaSessao = false;
                Botoes();
                HabilitarTextBox(true);
            }
        }

        private void btnCancelarSessao_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovaSessao = false;
            EditarSessao = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void btnSalvarSessao_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                bool SessaoAtualOK = false;
                bool ObservacaoSessaoOK = false;

                ValidarCampoNulo(txtSessaoAtual);
                if (myValidar.CampoValido == true)
                {
                    ValidarNumero(txtSessaoAtual);
                    if (myValidar.NumeroValido == true)
                    {
                        if (Convert.ToInt32(txtSessaoAtual.Text) > Convert.ToInt32(txtQuantidadeSessao.Text))
                        {
                            errorIcone.SetError(txtSessaoAtual, "O nº da sessão atual não pode ser superior a " +
                                                                "\nnº de quantidade total de sessões vendida");
                        }
                        else
                        {
                            errorIcone.SetError(txtSessaoAtual, string.Empty);
                            SessaoAtualOK = true;
                        }
                    }
                }

                if (txtObservacaoSessao.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtObservacaoSessao, 3000);
                    if (myValidar.TamanhoValido == true)
                    {
                        ObservacaoSessaoOK = true;
                    }
                }
                else
                {
                    errorIcone.SetError(txtObservacaoSessao, string.Empty);
                    ObservacaoSessaoOK = true;
                }

                if (SessaoAtualOK == false ||
                    ObservacaoSessaoOK == false)
                {
                    MensagemErro("Preencha corretamente todos os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    resp = mySessao.EditarSessao(
                        Convert.ToInt32(txtCodigoVendaSessao.Text),
                        Convert.ToInt32(txtCodigoProcedimentoSessao.Text),
                        Convert.ToInt32(txtSessaoAtual.Text),
                        Convert.ToInt32(txtQuantidadeSessao.Text),
                        txtObservacaoSessao.Text);

                    if (resp.Equals("OK"))
                    {
                        MensagemOk("Registro editado com sucesso");

                        NovaSessao = false;
                        EditarSessao = false;
                        Botoes();
                        LimparTextBox();

                        if (chkExibirTodasSessoes.Checked)
                        {
                            ExibirSessao();
                        }
                        else
                        {
                            ExibirSessaoDisponivel();
                        }
                    }
                    else
                    {
                        MensagemErro(resp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void tctrlSessao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlSessao.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovaSessao = false;
                EditarSessao = false;
                Botoes();
            }
        }

        private void chkExibirTodasSessoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExibirTodasSessoes.Checked)
            {
                if (cboxBuscarSessao.Text != null && txtBuscarSessao.Text != string.Empty)
                {
                    BuscarSessao();
                }
                else
                {
                    ExibirSessao();
                }
            }
            else
            {
                if (cboxBuscarSessao.Text != null && txtBuscarSessao.Text != string.Empty)
                {
                    BuscarSessao();
                }
                else
                {
                    ExibirSessaoDisponivel();
                }
            }
        }
    }
}
