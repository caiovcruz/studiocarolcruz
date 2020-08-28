using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewProduto : Form
    {
        ControlProduto myProduto = new ControlProduto();
        ControlEstoque myEstoque = new ControlEstoque();
        ControlLote myLote = new ControlLote();
        Validar myValidar = new Validar();

        private bool NovoProduto = false;
        private bool EditarProduto = false;

        public ViewProduto()
        {
            InitializeComponent();
        }

        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Studio Carol Cruz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Studio Carol Cruz", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparTextBox()
        {
            txtCodigoProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtArmazenamentoProduto.Text = string.Empty;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoProduto.Enabled = false;
            txtNomeProduto.Enabled = Valor;
            txtArmazenamentoProduto.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovoProduto || EditarProduto)
            {
                HabilitarTextBox(true);

                btnNovoProduto.Enabled = false;
                btnNovoProduto.BackColor = Color.Sienna;

                btnEditarProduto.Enabled = false;
                btnEditarProduto.BackColor = Color.Sienna;

                btnCancelarProduto.Enabled = true;
                btnCancelarProduto.BackColor = Color.Wheat;

                btnSalvarProduto.Enabled = true;
                btnSalvarProduto.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoProduto.Enabled = true;
                btnNovoProduto.BackColor = Color.Wheat;

                btnEditarProduto.Enabled = false;
                btnEditarProduto.BackColor = Color.Sienna;

                btnCancelarProduto.Enabled = false;
                btnCancelarProduto.BackColor = Color.Sienna;

                btnSalvarProduto.Enabled = false;
                btnSalvarProduto.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluirProduto()
        {
            dgvProduto.Columns[0].Visible = false;
        }

        private void HabilitarDataGridViewProduto()
        {
            if (dgvProduto.Rows.Count == 0)
            {
                chkExcluirProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
                btnExcluirProduto.BackColor = Color.Sienna;
                txtBuscarProduto.Enabled = false;
                btnBuscarProduto.Enabled = false;
                btnBuscarProduto.BackColor = Color.Sienna;
                dgvProduto.Enabled = false;
            }
            else
            {
                chkExcluirProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;
                btnExcluirProduto.BackColor = Color.Wheat;
                txtBuscarProduto.Enabled = true;
                btnBuscarProduto.Enabled = true;
                btnBuscarProduto.BackColor = Color.Wheat;
                dgvProduto.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvProduto.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvProduto.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvLote.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvLote.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirProduto()
        {
            dgvProduto.DataSource = myProduto.ExibirProduto();
            OcultarColunaExcluirProduto();
        }

        private void ExibirProdutoEstoque()
        {
            dgvProduto.DataSource = myProduto.ExibirProdutoEstoque();
            OcultarColunaExcluirProduto();
            lblTotalProduto.Text = "Total de Produtos: " + Convert.ToString(dgvProduto.Rows.Count);

            dgvProduto.Columns[1].HeaderText = "CÓDIGO";
            dgvProduto.Columns[2].HeaderText = "NOME";
            dgvProduto.Columns[3].HeaderText = "TIPO\nARMAZENAMENTO";
            dgvProduto.Columns[4].HeaderText = "TOTAL\nESTOQUE";

            dgvProduto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewProduto();
        }

        private void BuscarNomeProduto()
        {
            ValidarTamanhoCampo(txtBuscarProduto, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvProduto.DataSource = myProduto.BuscarNomeProduto(txtBuscarProduto.Text);
                lblTotalProduto.Text = "Total de Produtos: " + Convert.ToString(dgvProduto.Rows.Count);
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

        private void ViewProduto_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            myLote.ValidarLote();
            ConfiguracoesDgv();
            ExibirProdutoEstoque();
            HabilitarTextBox(false);
            Botoes();
        }

        private void txtBuscarProduto_TextChanged(object sender, EventArgs e)
        {
            BuscarNomeProduto();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            BuscarNomeProduto();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvProduto.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há produto(s) selecionado(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " produto(s)?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvProduto.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myProduto.ExcluirProduto(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Produto(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirProdutoEstoque();
                        chkExcluirProduto.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkExcluirProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirProduto.Checked)
            {
                dgvProduto.Columns[0].Visible = true;
            }
            else
            {
                dgvProduto.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvProduto.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProduto.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvProduto.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }

            dgvLote.DataSource = myLote.BuscarLote(Convert.ToInt32(dgvProduto.CurrentRow.Cells["ID_Produto"].Value));
            lblTotalLote.Text = "Total de Lotes: " + Convert.ToString(dgvLote.Rows.Count);

            dgvLote.Columns[0].Visible = false;
            dgvLote.Columns[1].Visible = false;
            dgvLote.Columns[2].HeaderText = "PRODUTO";
            dgvLote.Columns[3].HeaderText = "QUANTIDADE\nLOTE";
            dgvLote.Columns[4].HeaderText = "DATA\nVALIDADE";

            dgvLote.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoProduto.Text = Convert.ToString(dgvProduto.CurrentRow.Cells["ID_Produto"].Value);
            txtNomeProduto.Text = Convert.ToString(dgvProduto.CurrentRow.Cells["NM_Produto"].Value);
            txtArmazenamentoProduto.Text = Convert.ToString(dgvProduto.CurrentRow.Cells["DS_TipoArmazenamento"].Value);

            btnEditarProduto.Enabled = true;
            btnEditarProduto.BackColor = Color.Wheat;
            tctrlProduto.SelectedIndex = 1;
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            NovoProduto = true;
            EditarProduto = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtNomeProduto.Focus();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeProdutoOK = false;
                bool ArmazenamentoProdutoOK = false;

                string resp = "";

                ValidarCampoNulo(txtNomeProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeProduto, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeProdutoOK = true;
                    }
                }

                ValidarCampoNulo(txtArmazenamentoProduto);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtArmazenamentoProduto, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        ArmazenamentoProdutoOK = true;
                    }
                }

                bool PRODcadastrado = false;

                foreach (DataGridViewRow row in dgvProduto.Rows)
                {
                    if (txtCodigoProduto.Text != Convert.ToString(row.Cells["ID_Produto"].Value))
                    {
                        if (txtNomeProduto.Text == Convert.ToString(row.Cells["NM_Produto"].Value))
                        {
                            PRODcadastrado = true;
                        }
                    }
                }

                if (PRODcadastrado == true)
                {
                    MensagemErro("Produto já cadastrado na base de dados");
                }
                else
                {
                    if (NomeProdutoOK == false ||
                        ArmazenamentoProdutoOK == false)
                    {
                        MensagemErro("Por favor, preencha todos os campos corretamente");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (NovoProduto)
                        {
                            resp = myProduto.InserirProduto(
                                txtNomeProduto.Text,
                                txtArmazenamentoProduto.Text);
                        }
                        else
                        {
                            resp = myProduto.EditarProduto(
                                Convert.ToInt32(txtCodigoProduto.Text),
                                txtNomeProduto.Text,
                                txtArmazenamentoProduto.Text);
                        }

                        if (resp.Equals("OK"))
                        {
                            if (NovoProduto)
                            {
                                MensagemOk("Registro salvo com sucesso");

                                ExibirProduto();
                                foreach (DataGridViewRow row in dgvProduto.Rows)
                                {
                                    if (txtNomeProduto.Text == Convert.ToString(row.Cells["NM_Produto"].Value))
                                    {
                                        txtCodigoProduto.Text = Convert.ToString(row.Cells["ID_Produto"].Value);
                                        resp = myEstoque.InserirEstoque(Convert.ToInt32(txtCodigoProduto.Text), 0);
                                    }
                                }
                            }
                            else
                            {
                                MensagemOk("Registro editado com sucesso");
                            }
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        NovoProduto = false;
                        EditarProduto = false;
                        Botoes();
                        LimparTextBox();
                        ExibirProdutoEstoque();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                txtNomeProduto.Focus();
                EditarProduto = true;
                NovoProduto = false;
                Botoes();
                HabilitarTextBox(true);
            }
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovoProduto = false;
            EditarProduto = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlProduto.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovoProduto = false;
                EditarProduto = false;
                Botoes();
            }
        }
    }
}
