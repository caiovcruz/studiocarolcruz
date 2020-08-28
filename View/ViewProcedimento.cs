using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewProcedimento : Form
    {
        ControlProcedimento myProcedimento = new ControlProcedimento();
        ControlCategoria myCategoria = new ControlCategoria();
        ControlProduto myProduto = new ControlProduto();

        Validar myValidar = new Validar();

        private bool NovoProcedimento = false;
        private bool EditarProcedimento = false;

        public ViewProcedimento()
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
            txtCodigoProcedimento.Text = string.Empty;
            txtNomeProcedimento.Text = string.Empty;
            txtDescricaoProcedimento.Text = string.Empty;
            cboxCategoriaProcedimento.Text = null;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoProcedimento.Enabled = false;
            txtNomeProcedimento.Enabled = Valor;
            txtDescricaoProcedimento.Enabled = Valor;
            cboxCategoriaProcedimento.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovoProcedimento || EditarProcedimento)
            {
                HabilitarTextBox(true);

                btnNovoProcedimento.Enabled = false;
                btnNovoProcedimento.BackColor = Color.Sienna;

                btnEditarProcedimento.Enabled = false;
                btnEditarProcedimento.BackColor = Color.Sienna;

                btnCancelarProcedimento.Enabled = true;
                btnCancelarProcedimento.BackColor = Color.Wheat;

                btnSalvarProcedimento.Enabled = true;
                btnSalvarProcedimento.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoProcedimento.Enabled = true;
                btnNovoProcedimento.BackColor = Color.Wheat;

                btnEditarProcedimento.Enabled = false;
                btnEditarProcedimento.BackColor = Color.Sienna;

                btnCancelarProcedimento.Enabled = false;
                btnCancelarProcedimento.BackColor = Color.Sienna;

                btnSalvarProcedimento.Enabled = false;
                btnSalvarProcedimento.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluirProcedimento()
        {
            dgvProcedimento.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvProcedimento.Rows.Count == 0)
            {
                chkExcluirProcedimento.Enabled = false;
                btnExcluirProcedimento.Enabled = false;
                btnExcluirProcedimento.BackColor = Color.Sienna;
                txtBuscarProcedimento.Enabled = false;
                btnBuscarProcedimento.Enabled = false;
                btnBuscarProcedimento.BackColor = Color.Sienna;
                dgvProcedimento.Enabled = false;
            }
            else
            {
                chkExcluirProcedimento.Enabled = true;
                btnExcluirProcedimento.Enabled = true;
                btnExcluirProcedimento.BackColor = Color.Wheat;
                txtBuscarProcedimento.Enabled = true;
                btnBuscarProcedimento.Enabled = true;
                btnBuscarProcedimento.BackColor = Color.Wheat;
                dgvProcedimento.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvProcedimento.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvProcedimento.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirProcedimento()
        {
            dgvProcedimento.DataSource = myProcedimento.ExibirProcedimento();
            OcultarColunaExcluirProcedimento();
            lblTotalProcedimento.Text = "Total de Procedimentos: " + Convert.ToString(dgvProcedimento.Rows.Count);

            dgvProcedimento.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvProcedimento.Columns[1].HeaderText = "CÓDIGO";
            dgvProcedimento.Columns[2].HeaderText = "CATEGORIA";
            dgvProcedimento.Columns[3].HeaderText = "NOME";
            dgvProcedimento.Columns[4].Visible = false;

            dgvProcedimento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProcedimento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void ExibirCategoria()
        {
            cboxCategoriaProcedimento.DataSource = myCategoria.ExibirCategoria();
            cboxCategoriaProcedimento.DisplayMember = "NM_Categoria";
            cboxCategoriaProcedimento.ValueMember = "ID_Categoria";
        }

        private void ExibirCategoriaBuscar()
        {
            cboxBuscarProcedimento.DataSource = myCategoria.ExibirCategoria();
            cboxBuscarProcedimento.DisplayMember = "NM_Categoria";
            cboxBuscarProcedimento.ValueMember = "ID_Categoria";
        }

        private void BuscarProcedimento()
        {
            ValidarTamanhoCampo(txtBuscarProcedimento, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvProcedimento.DataSource = myProcedimento.BuscarProcedimento(Convert.ToInt32(cboxBuscarProcedimento.SelectedValue.ToString()),
                                                                                                    txtBuscarProcedimento.Text);
                lblTotalProcedimento.Text = "Total de Procedimentos: " + Convert.ToString(dgvProcedimento.Rows.Count);
            }
        }

        private void BuscarNomeProcedimento()
        {
            ValidarTamanhoCampo(txtBuscarProcedimento, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvProcedimento.DataSource = myProcedimento.BuscarNomeProcedimento(txtBuscarProcedimento.Text);
                lblTotalProcedimento.Text = "Total de Procedimentos: " + Convert.ToString(dgvProcedimento.Rows.Count);
            }
        }

        private void BuscarCategoriaProcedimento()
        {
            dgvProcedimento.DataSource = myProcedimento.BuscarCategoriaProcedimento(Convert.ToInt32(cboxBuscarProcedimento.SelectedValue.ToString()));
            lblTotalProcedimento.Text = "Total de Procedimentos: " + Convert.ToString(dgvProcedimento.Rows.Count);
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

        private void ViewProcedimento_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            HabilitarTextBox(false);
            Botoes();
            ExibirProcedimento();
            ExibirCategoria();
            cboxCategoriaProcedimento.Text = null;
            cboxBuscarProcedimento.Enabled = false;
        }

        private void chkBuscarProcedimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarProcedimento.Checked)
            {
                cboxBuscarProcedimento.Enabled = true;
                ExibirCategoriaBuscar();
                cboxBuscarProcedimento.Text = null;
            }
            else
            {
                cboxBuscarProcedimento.DataSource = null;
                cboxBuscarProcedimento.Enabled = false;

                if (txtBuscarProcedimento.Text != string.Empty)
                {
                    BuscarNomeProcedimento();
                }
                else
                {
                    ExibirProcedimento();
                }
            }
        }

        private void txtBuscarProcedimento_TextChanged(object sender, EventArgs e)
        {
            if (chkBuscarProcedimento.Checked && cboxBuscarProcedimento.Text != string.Empty)
            {
                BuscarProcedimento();
            }
            else if (txtBuscarProcedimento.Text != string.Empty)
            {
                BuscarNomeProcedimento();
            }
            else
            {
                ExibirProcedimento();
            }
        }

        private void btnBuscarProcedimento_Click(object sender, EventArgs e)
        {
            if (chkBuscarProcedimento.Checked && cboxBuscarProcedimento.Text != string.Empty && txtBuscarProcedimento.Text != string.Empty)
            {
                BuscarProcedimento();
            }
            else if (chkBuscarProcedimento.Checked && cboxBuscarProcedimento.Text != string.Empty)
            {
                BuscarCategoriaProcedimento();
            }
            else if (txtBuscarProcedimento.Text != string.Empty)
            {
                BuscarNomeProcedimento();
            }
            else
            {
                ExibirProcedimento();
            }
        }

        private void btnExcluirProcedimento_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvProcedimento.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há procedimento(s) selecionado(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " procedimento(s)?",
                        "PIZZA VINTAGE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvProcedimento.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myProcedimento.ExcluirProcedimento(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Procedimento(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirProcedimento();
                        chkExcluirProcedimento.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkExcluirProcedimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirProcedimento.Checked)
            {
                dgvProcedimento.Columns[0].Visible = true;
            }
            else
            {
                dgvProcedimento.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvProcedimento.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void dgvProcedimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProcedimento.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvProcedimento.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvProcedimento_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoProcedimento.Text = Convert.ToString(dgvProcedimento.CurrentRow.Cells["ID_Procedimento"].Value);
            cboxCategoriaProcedimento.Text = Convert.ToString(dgvProcedimento.CurrentRow.Cells["NM_Categoria"].Value);
            txtNomeProcedimento.Text = Convert.ToString(dgvProcedimento.CurrentRow.Cells["NM_Procedimento"].Value);
            txtDescricaoProcedimento.Text = Convert.ToString(dgvProcedimento.CurrentRow.Cells["DS_Procedimento"].Value);

            btnEditarProcedimento.Enabled = true;
            btnEditarProcedimento.BackColor = Color.Wheat;
            tctrlProcedimento.SelectedIndex = 1;
        }

        private void btnNovoProcedimento_Click(object sender, EventArgs e)
        {
            NovoProcedimento = true;
            EditarProcedimento = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtNomeProcedimento.Focus();
        }

        private void btnSalvarProcedimento_Click(object sender, EventArgs e)
        {
            try
            {
                bool CategoriaProcedimentoOK = false;
                bool NomeProcedimentoOK = false;
                bool DescricaoProcedimentoOK = false;

                string resp = "";

                if (cboxCategoriaProcedimento.Text == string.Empty)
                {
                    errorIcone.SetError(cboxCategoriaProcedimento, "Selecione a categoria do procedimento");
                }
                else
                {
                    errorIcone.SetError(cboxCategoriaProcedimento, string.Empty);
                    CategoriaProcedimentoOK = true;
                }

                ValidarCampoNulo(txtNomeProcedimento);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeProcedimento, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeProcedimentoOK = true;
                    }
                }

                ValidarCampoNulo(txtDescricaoProcedimento);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtDescricaoProcedimento, 3000);
                    if (myValidar.TamanhoValido == true)
                    {
                        DescricaoProcedimentoOK = true;
                    }
                }

                bool PROCcadastrado = false;

                foreach (DataGridViewRow row in dgvProcedimento.Rows)
                {
                    if (txtCodigoProcedimento.Text != Convert.ToString(row.Cells["ID_Procedimento"].Value))
                    {
                        if (txtNomeProcedimento.Text == Convert.ToString(row.Cells["NM_Procedimento"].Value))
                        {
                            PROCcadastrado = true;
                        }
                    }
                }

                if (PROCcadastrado == true)
                {
                    MensagemErro("Procedimento já cadastrado na base de dados");
                }
                else
                {
                    if (NomeProcedimentoOK == false ||
                        CategoriaProcedimentoOK == false ||
                        DescricaoProcedimentoOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (NovoProcedimento)
                        {
                            resp = myProcedimento.InserirProcedimento(
                                Convert.ToInt32(cboxCategoriaProcedimento.SelectedValue.ToString()),
                                txtNomeProcedimento.Text.Trim(),
                                txtDescricaoProcedimento.Text.Trim());
                        }
                        else
                        {
                            resp = myProcedimento.EditarProcedimento(
                                Convert.ToInt32(txtCodigoProcedimento.Text),
                                Convert.ToInt32(cboxCategoriaProcedimento.SelectedValue.ToString()),
                                txtNomeProcedimento.Text.Trim(),
                                txtDescricaoProcedimento.Text.Trim());
                        }

                        if (resp.Equals("OK"))
                        {
                            if (NovoProcedimento)
                            {
                                MensagemOk("Registro salvo com sucesso");
                            }
                            else
                            {
                                MensagemOk("Registro editado com sucesso");
                            }

                            NovoProcedimento = false;
                            EditarProcedimento = false;
                            Botoes();
                            HabilitarTextBox(false);
                            LimparTextBox();
                            ExibirProcedimento();
                            ExibirCategoria();

                            foreach (DataGridViewRow row in dgvProcedimento.Rows)
                            {
                                if (txtNomeProcedimento.Text == Convert.ToString(row.Cells["NM_Procedimento"].Value))
                                {
                                    txtCodigoProcedimento.Text = Convert.ToString(row.Cells["ID_Procedimento"].Value);
                                }
                            }
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

        private void btnEditarProcedimento_Click(object sender, EventArgs e)
        {
            if (txtNomeProcedimento.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                NovoProcedimento = false;
                EditarProcedimento = true;
                Botoes();
                HabilitarTextBox(true);
            }
        }

        private void btnCancelarProcedimento_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovoProcedimento = false;
            EditarProcedimento = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlProcedimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlProcedimento.SelectedIndex == 0)
            {
                NovoProcedimento = false;
                EditarProcedimento = false;
                Botoes();
                HabilitarTextBox(false);
                LimparTextBox();
            }
        }
    }
}
