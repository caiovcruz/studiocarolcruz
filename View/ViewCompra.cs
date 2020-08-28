using Control;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCompra : Form
    {
        ControlCompra myCompra = new ControlCompra();
        ControlItemCompra myItemCompra = new ControlItemCompra();
        ControlLote myLote = new ControlLote();
        ControlEstoque myEstoque = new ControlEstoque();
        ControlBaixaEstoque myBaixaEstoque = new ControlBaixaEstoque();
        ControlProduto myProduto = new ControlProduto();
        Validar myValidar = new Validar();

        private bool NovaCompra = false;
        private bool EditarCompra = false;

        private int _IDCompra;
        private DateTime _DataValidade;
        private double _ValorTotal;

        public int IDCompra { get => _IDCompra; set => _IDCompra = value; }
        public DateTime DataValidade { get => _DataValidade; set => _DataValidade = value; }
        public double ValorTotal { get => _ValorTotal; set => _ValorTotal = value; }

        public ViewCompra()
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

        private void LimparCamposProdutoCompra()
        {
            txtCodigoProdutoCompra.Text = string.Empty;
            txtProdutoCompra.Text = string.Empty;
            dtValidadeProdutoCompra.Value = DateTime.Today;
            txtQuantidadeProdutoCompra.Text = string.Empty;
            txtValorProdutoCompra.Text = string.Empty;
        }

        private void LimparCamposItemCompra()
        {
            txtCodigoItemCompra.Text = string.Empty;
            txtItemCompra.Text = string.Empty;
            dtValidadeItemCompra.Value = DateTime.Today;
            txtQuantidadeItemCompra.Text = string.Empty;
            txtValorItemCompra.Text = string.Empty;
            chkExcluirItemCompra.Checked = false;
            lblValorTotalCompra.Text = "Total: R$0,00";
        }

        private void HabilitarTextBoxProdutoCompra(bool Valor)
        {
            txtCodigoProdutoCompra.Enabled = false;
            txtProdutoCompra.Enabled = false;
            dtValidadeProdutoCompra.Enabled = Valor;
            txtQuantidadeProdutoCompra.Enabled = Valor;
            txtValorProdutoCompra.Enabled = Valor;
        }

        private void HabilitarTextBoxItemCompra(bool Valor)
        {
            txtCodigoItemCompra.Enabled = false;
            txtItemCompra.Enabled = false;
            dtValidadeItemCompra.Enabled = Valor;
            txtQuantidadeItemCompra.Enabled = Valor;
            txtValorItemCompra.Enabled = Valor;
        }

        private void HabilitarCamposAdicionarProdutoCompra(bool Valor)
        {
            txtBuscarProdutoCompra.Enabled = Valor;
            btnBuscarProdutoCompra.Enabled = Valor;

            if (btnBuscarProdutoCompra.Enabled == true)
            {
                btnBuscarProdutoCompra.BackColor = Color.Wheat;
            }
            else
            {
                btnBuscarProdutoCompra.BackColor = Color.Sienna;
            }

            dgvProdutoCompra.Enabled = Valor;

            txtCodigoProdutoCompra.Enabled = false;
            txtProdutoCompra.Enabled = false;
            dtValidadeProdutoCompra.Enabled = false;
            txtQuantidadeProdutoCompra.Enabled = false;
            txtValorProdutoCompra.Enabled = false;

            btnConfirmarProdutoCompra.Enabled = false;
            btnConfirmarProdutoCompra.BackColor = Color.Sienna;
            btnCancelarProdutoCompra.Enabled = false;
            btnCancelarProdutoCompra.BackColor = Color.Sienna;

            chkExcluirItemCompra.Enabled = false;
            btnExcluirItemCompra.Enabled = false;
            btnExcluirItemCompra.BackColor = Color.Sienna;
            dgvItemCompra.Enabled = Valor;

            txtCodigoItemCompra.Enabled = false;
            txtItemCompra.Enabled = false;
            dtValidadeItemCompra.Enabled = false;
            txtQuantidadeItemCompra.Enabled = false;
            txtValorItemCompra.Enabled = false;

            btnEditarItemCompra.Enabled = false;
            btnEditarItemCompra.BackColor = Color.Sienna;
            btnCancelarItemCompra.Enabled = false;
            btnCancelarItemCompra.BackColor = Color.Sienna;

            dgvItemCompra.Columns[0].Visible = false;
        }

        private void Botoes()
        {
            if (NovaCompra || EditarCompra)
            {
                btnNovoCompra.Enabled = false;
                btnNovoCompra.BackColor = Color.Sienna;

                btnSalvarCompra.Enabled = true;
                btnSalvarCompra.BackColor = Color.Wheat;

                btnCancelarCompra.Enabled = true;
                btnCancelarCompra.BackColor = Color.Wheat;
            }
            else
            {
                btnNovoCompra.Enabled = true;
                btnNovoCompra.BackColor = Color.Wheat;

                btnSalvarCompra.Enabled = false;
                btnSalvarCompra.BackColor = Color.Sienna;

                btnCancelarCompra.Enabled = false;
                btnCancelarCompra.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvCompra.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvCompra.Rows.Count == 0)
            {
                chkExcluirCompra.Enabled = false;
                btnExcluirCompra.Enabled = false;
                btnExcluirCompra.BackColor = Color.Sienna;
                dgvCompra.Enabled = false;
            }
            else
            {
                chkExcluirCompra.Enabled = true;
                btnExcluirCompra.Enabled = true;
                btnExcluirCompra.BackColor = Color.Wheat;
                dgvCompra.Enabled = true;
            }
        }

        private void HabilitarDataGridViewProdutoCompra()
        {
            if (dgvProdutoCompra.Rows.Count == 0)
            {
                txtBuscarProdutoCompra.Enabled = false;
                btnBuscarProdutoCompra.Enabled = false;
                btnBuscarProdutoCompra.BackColor = Color.Sienna;
                dgvProdutoCompra.Enabled = false;
            }
            else
            {
                txtBuscarProdutoCompra.Enabled = true;
                btnBuscarProdutoCompra.Enabled = true;
                btnBuscarProdutoCompra.BackColor = Color.Wheat;
                dgvProdutoCompra.Enabled = true;
            }
        }

        private void HabilitarDataGridViewItemCompra()
        {
            if (dgvItemCompra.Rows.Count == 0)
            {
                chkExcluirItemCompra.Enabled = false;
                btnExcluirItemCompra.Enabled = false;
                btnExcluirItemCompra.BackColor = Color.Sienna;
                dgvItemCompra.Enabled = false;
            }
            else
            {
                chkExcluirItemCompra.Enabled = true;
                btnExcluirItemCompra.Enabled = true;
                btnExcluirItemCompra.BackColor = Color.Wheat;
                dgvItemCompra.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvCompra.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvCompra.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvListaItemCompra.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvListaItemCompra.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvProdutoCompra.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvProdutoCompra.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvItemCompra.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvItemCompra.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirCompra()
        {
            dgvCompra.DataSource = myCompra.ExibirCompra();
            OcultarColunaExcluir();
            lblTotalCompra.Text = "Total de Compras: " + Convert.ToString(dgvCompra.Rows.Count);

            double valorGasto = 0;
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                valorGasto += Convert.ToDouble(row.Cells[3].Value);
            }

            lblValorGastoCompra.Text = "Valor Gasto: R$" + valorGasto.ToString("N2");

            dgvCompra.Columns[1].HeaderText = "CÓDIGO";
            dgvCompra.Columns[2].HeaderText = "DATA";
            dgvCompra.Columns[3].HeaderText = "VALOR";

            dgvCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarCompra()
        {
            dgvCompra.DataSource = myCompra.BuscarCompra(dtInicioBuscar.Value, dtFinalBuscar.Value.AddDays(1), txtBuscarProdutoCompraListar.Text);
            OcultarColunaExcluir();
            lblTotalCompra.Text = "Total de Compras: " + Convert.ToString(dgvCompra.Rows.Count);

            double valorGasto = 0;
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                valorGasto += Convert.ToDouble(row.Cells[3].Value);
            }

            lblValorGastoCompra.Text = "Valor Gasto: R$" + valorGasto.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarDataCompra()
        {
            dgvCompra.DataSource = myCompra.BuscarDataCompra(dtInicioBuscar.Value, dtFinalBuscar.Value.AddDays(1));
            OcultarColunaExcluir();
            lblTotalCompra.Text = "Total de Compras: " + Convert.ToString(dgvCompra.Rows.Count);

            double valorGasto = 0;
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                valorGasto += Convert.ToDouble(row.Cells[3].Value);
            }

            lblValorGastoCompra.Text = "Valor Gasto: R$" + valorGasto.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarProdutoCompra()
        {
            dgvCompra.DataSource = myCompra.BuscarProdutoCompra(txtBuscarProdutoCompraListar.Text);
            OcultarColunaExcluir();
            lblTotalCompra.Text = "Total de Compras: " + Convert.ToString(dgvCompra.Rows.Count);

            double valorGasto = 0;
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                valorGasto += Convert.ToDouble(row.Cells[3].Value);
            }

            lblValorGastoCompra.Text = "Valor Gasto: R$" + valorGasto.ToString("N2");

            HabilitarDataGridView();
        }

        private void ExibirProdutoEstoque()
        {
            dgvProdutoCompra.DataSource = myProduto.ExibirProdutoEstoque();

            dgvProdutoCompra.Columns[0].HeaderText = "CÓDIGO";
            dgvProdutoCompra.Columns[1].HeaderText = "PRODUTO";
            dgvProdutoCompra.Columns[2].HeaderText = "TIPO\nARMAZENAMENTO";
            dgvProdutoCompra.Columns[3].HeaderText = "TOTAL\nESTOQUE";

            dgvProdutoCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProdutoCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProdutoCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewProdutoCompra();
        }

        private void ExibirItemCompra()
        {
            dgvItemCompra.DataSource = myItemCompra.ExibirItemCompra(IDCompra);

            dgvItemCompra.Columns[1].Visible = false;
            dgvItemCompra.Columns[2].Visible = false;
            dgvItemCompra.Columns[3].HeaderText = "PRODUTO";
            dgvItemCompra.Columns[4].HeaderText = "VALIDADE";
            dgvItemCompra.Columns[5].HeaderText = "TIPO\nARMAZENAMENTO";
            dgvItemCompra.Columns[6].HeaderText = "QUANTIDADE";
            dgvItemCompra.Columns[7].HeaderText = "VALOR";

            dgvItemCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvItemCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItemCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewItemCompra();
        }

        private void BuscarNomeProduto()
        {
            dgvProdutoCompra.DataSource = myProduto.BuscarNomeProduto(txtBuscarProdutoCompra.Text);
        }

        private void BuscarLoteData(int id_produto, DateTime dt_validade)
        {
            dgvValida.DataSource = myLote.BuscarLoteData(id_produto, dt_validade);
        }

        private void HabilitarBuscar(bool Valor)
        {
            dtInicioBuscar.Value = DateTime.Today;
            dtFinalBuscar.Value = DateTime.Today;

            dtInicioBuscar.Enabled = Valor;
            dtFinalBuscar.Enabled = Valor;
        }

        private void ValidarCompra()
        {
            myCompra.ValidarCompra();
        }

        private void InserirCompra()
        {
            try
            {
                string resp = "";

                if (NovaCompra)
                {
                    resp = myCompra.InserirCompra();

                    dgvValida.DataSource = myCompra.ExibirCompra();

                    foreach (DataGridViewRow row in dgvValida.Rows)
                    {
                        if (Convert.ToString(row.Cells["VL_Compra"].Value) == string.Empty)
                        {
                            IDCompra = Convert.ToInt32(row.Cells["ID_Compra"].Value);
                        }
                    }
                }

                if (resp.Equals("OK"))
                {
                    MensagemOk("Nova compra iniciada Nº" + IDCompra);
                }
                else
                {
                    MensagemErro(resp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void InserirItemCompra()
        {
            try
            {
                string resp = "";

                if (NovaCompra)
                {
                    resp = myItemCompra.InserirItemCompra(IDCompra,
                            Convert.ToInt32(txtCodigoProdutoCompra.Text),
                            dtValidadeProdutoCompra.Value,
                            Convert.ToDouble(txtQuantidadeProdutoCompra.Text),
                            Convert.ToDouble(txtValorProdutoCompra.Text));
                }
                else
                {
                    resp = myItemCompra.EditarItemCompra(IDCompra,
                            Convert.ToInt32(txtCodigoItemCompra.Text),
                            DataValidade,
                            dtValidadeItemCompra.Value,
                            Convert.ToDouble(txtQuantidadeItemCompra.Text),
                            Convert.ToDouble(txtValorItemCompra.Text));
                }

                if (resp.Equals("OK"))
                {
                    ExibirItemCompra();
                }
                else
                {
                    MensagemErro(resp);
                }

                NovaCompra = false;
                EditarCompra = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CalcularCompra()
        {
            double totalVenda = 0;

            foreach (DataGridViewRow row in dgvItemCompra.Rows)
            {
                totalVenda += Convert.ToDouble(row.Cells["VL_ItemCompra"].Value);
                lblValorTotalCompra.Text = "Total: R$" + totalVenda.ToString("N2");
                ValorTotal = totalVenda;
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

        private void ViewCompra_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ValidarCompra();
            ConfiguracoesDgv();
            ExibirCompra();
            LimparCamposProdutoCompra();
            LimparCamposItemCompra();
            HabilitarBuscar(false);
            HabilitarCamposAdicionarProdutoCompra(false);
            Botoes();

            dtValidadeProdutoCompra.MinDate = DateTime.Today;
            dtValidadeItemCompra.MinDate = DateTime.Today;
        }

        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCompra.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvCompra.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }

            dgvListaItemCompra.DataSource = myItemCompra.ExibirItemCompra(
                Convert.ToInt32(dgvCompra.CurrentRow.Cells["ID_Compra"].Value));
            lblTotalItemCompra.Text = "Total de Itens: " + Convert.ToString(dgvListaItemCompra.Rows.Count);

            double valorGasto = 0;
            foreach (DataGridViewRow row in dgvListaItemCompra.Rows)
            {
                valorGasto += Convert.ToDouble(row.Cells[6].Value);
            }

            lblValorGastoItemCompra.Text = "Valor Gasto: R$" + valorGasto.ToString("N2");

            dgvListaItemCompra.Columns[0].Visible = false;
            dgvListaItemCompra.Columns[1].Visible = false;
            dgvListaItemCompra.Columns[2].HeaderText = "PRODUTO";
            dgvListaItemCompra.Columns[3].HeaderText = "VALIDADE";
            dgvListaItemCompra.Columns[4].HeaderText = "TIPO\nARMAZENAMENTO";
            dgvListaItemCompra.Columns[5].HeaderText = "QUANTIDADE";
            dgvListaItemCompra.Columns[6].HeaderText = "VALOR";

            dgvListaItemCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvListaItemCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaItemCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void tctrlCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCompra.SelectedIndex == 0)
            {
                ValidarCompra();
                ExibirCompra();

                dgvProdutoCompra.DataSource = "";
                dgvItemCompra.DataSource = "";

                LimparCamposProdutoCompra();
                LimparCamposItemCompra();
                HabilitarCamposAdicionarProdutoCompra(false);

                btnNovoCompra.Enabled = true;
                btnNovoCompra.BackColor = Color.Wheat;
                btnSalvarCompra.Enabled = false;
                btnSalvarCompra.BackColor = Color.Sienna;
                btnCancelarCompra.Enabled = false;
                btnCancelarCompra.BackColor = Color.Sienna;
            }
        }

        private void txtBuscarProdutoCompra_TextChanged(object sender, EventArgs e)
        {
            BuscarNomeProduto();
        }

        private void btnBuscarProdutoCompra_Click(object sender, EventArgs e)
        {
            BuscarNomeProduto();
        }

        private void dgvProdutoCompra_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoProdutoCompra.Text = Convert.ToString(dgvProdutoCompra.CurrentRow.Cells["ID_Produto"].Value);
            txtProdutoCompra.Text = Convert.ToString(dgvProdutoCompra.CurrentRow.Cells["NM_Produto"].Value);

            dtValidadeProdutoCompra.Enabled = true;
            txtQuantidadeProdutoCompra.Enabled = true;
            txtValorProdutoCompra.Enabled = true;
            btnCancelarProdutoCompra.Enabled = true;
            btnCancelarProdutoCompra.BackColor = Color.Wheat;
            btnConfirmarProdutoCompra.Enabled = true;
            btnConfirmarProdutoCompra.BackColor = Color.Wheat;
        }

        private void btnCancelarProdutoCompra_Click(object sender, EventArgs e)
        {
            errorIcone.SetError(dtValidadeProdutoCompra, string.Empty);
            errorIcone.SetError(txtQuantidadeProdutoCompra, string.Empty);
            errorIcone.SetError(txtValorProdutoCompra, string.Empty);

            LimparCamposProdutoCompra();
            HabilitarTextBoxProdutoCompra(false);

            btnCancelarProdutoCompra.Enabled = false;
            btnCancelarProdutoCompra.BackColor = Color.Sienna;
            btnConfirmarProdutoCompra.Enabled = false;
            btnConfirmarProdutoCompra.BackColor = Color.Sienna;
        }

        private void btnConfirmarProdutoCompra_Click(object sender, EventArgs e)
        {
            bool QuantidadeProdutoCompraOK = false;
            bool ValorProdutoCompraOK = false;

            ValidarCampoNulo(txtQuantidadeProdutoCompra);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtQuantidadeProdutoCompra);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtQuantidadeProdutoCompra.Text) <= 0)
                    {
                        errorIcone.SetError(txtQuantidadeProdutoCompra, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        errorIcone.SetError(txtQuantidadeProdutoCompra, string.Empty);
                        QuantidadeProdutoCompraOK = true;
                    }
                }
            }

            ValidarCampoNulo(txtValorProdutoCompra);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtValorProdutoCompra);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtValorProdutoCompra.Text) <= 0)
                    {
                        errorIcone.SetError(txtValorProdutoCompra, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        errorIcone.SetError(txtValorProdutoCompra, string.Empty);
                        ValorProdutoCompraOK = true;
                    }
                }
            }

            if (QuantidadeProdutoCompraOK == false ||
                ValorProdutoCompraOK == false)
            {
                MensagemErro("Por favor, preencha corretamente os campos sinalizados");
            }
            else
            {
                bool produtoInvalido = false;

                foreach (DataGridViewRow row in dgvItemCompra.Rows)
                {
                    if (dgvProdutoCompra.CurrentRow.Cells["NM_Produto"].Value.Equals(row.Cells["NM_Produto"].Value))
                    {
                        if (row.Cells["DT_Validade"].Value.Equals(dtValidadeProdutoCompra.Value))
                        {
                            MensagemErro("Este produto com esta data de" +
                                            "\nvalidade já foi inserido na compra." +
                                            "\n\nPara alterar sua quantidade e/ou valor," +
                                            "\npor favor selecione e edite-o no ''Itens na compra''");
                            produtoInvalido = true;
                        }
                    }
                }

                if (produtoInvalido == false)
                {

                    errorIcone.Clear();
                    NovaCompra = true;
                    EditarCompra = false;

                    try
                    {
                        DialogResult Opcao;
                        Opcao = MessageBox.Show("Deseja adicionar este produto na compra?",
                            "Studio Carol Cruz",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (Opcao == DialogResult.Yes)
                        {
                            InserirItemCompra();

                            LimparCamposProdutoCompra();
                            btnConfirmarProdutoCompra.Enabled = false;
                            btnConfirmarProdutoCompra.BackColor = Color.Sienna;
                            btnCancelarProdutoCompra.Enabled = false;
                            btnCancelarProdutoCompra.BackColor = Color.Sienna;
                            HabilitarTextBoxProdutoCompra(false);

                            CalcularCompra();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
        }

        private void chkExcluirItemCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirItemCompra.Checked)
            {
                dgvItemCompra.Columns[0].Visible = true;
                btnExcluirItemCompra.Enabled = true;
                btnExcluirItemCompra.BackColor = Color.Wheat;
            }
            else
            {
                dgvItemCompra.Columns[0].Visible = false;
                btnExcluirItemCompra.Enabled = false;
                btnExcluirItemCompra.BackColor = Color.Sienna;

                foreach (DataGridViewRow row in dgvItemCompra.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirItemCompra_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvItemCompra.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há item(s) selecionado(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja excluir " + quantidadeCheckada + " item(s) da compra?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Compra;
                        int Produto;
                        DateTime Validade;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvItemCompra.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Compra = Convert.ToInt32(row.Cells[1].Value);
                                Produto = Convert.ToInt32(row.Cells[2].Value);
                                Validade = Convert.ToDateTime(row.Cells[4].Value);
                                resp = myItemCompra.ExcluirItemCompra(Compra, Produto, Validade);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Item(s) excluído(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        chkExcluirItemCompra.Checked = false;
                        ExibirItemCompra();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvItemCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItemCompra.Columns["ExcluirItemCompra"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dgvItemCompra.Rows[e.RowIndex].Cells["ExcluirItemCompra"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dgvItemCompra_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoItemCompra.Text = Convert.ToString(dgvItemCompra.CurrentRow.Cells["ID_Produto"].Value);
            txtItemCompra.Text = Convert.ToString(dgvItemCompra.CurrentRow.Cells["NM_Produto"].Value);
            dtValidadeItemCompra.Value = Convert.ToDateTime(dgvItemCompra.CurrentRow.Cells["DT_Validade"].Value);
            txtQuantidadeItemCompra.Text = Convert.ToString(dgvItemCompra.CurrentRow.Cells["QTDE_ItemCompra"].Value);
            txtValorItemCompra.Text = Convert.ToString(dgvItemCompra.CurrentRow.Cells["VL_ItemCompra"].Value);

            DataValidade = Convert.ToDateTime(dgvItemCompra.CurrentRow.Cells["DT_Validade"].Value);

            dtValidadeItemCompra.Enabled = true;
            txtQuantidadeItemCompra.Enabled = true;
            txtValorItemCompra.Enabled = true;
            btnCancelarItemCompra.Enabled = true;
            btnCancelarItemCompra.BackColor = Color.Wheat;
            btnEditarItemCompra.Enabled = true;
            btnEditarItemCompra.BackColor = Color.Wheat;
        }

        private void btnEditarItemCompra_Click(object sender, EventArgs e)
        {
            bool QuantidadeItemCompraOK = false;
            bool ValorItemCompraOK = false;

            ValidarCampoNulo(txtQuantidadeItemCompra);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtQuantidadeItemCompra);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtQuantidadeItemCompra.Text) <= 0)
                    {
                        errorIcone.SetError(txtQuantidadeItemCompra, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        errorIcone.SetError(txtQuantidadeItemCompra, string.Empty);
                        QuantidadeItemCompraOK = true;
                    }
                }
            }

            ValidarCampoNulo(txtValorItemCompra);
            if (myValidar.CampoValido == true)
            {
                ValidarValor(txtValorItemCompra);
                if (myValidar.ValorValido == true)
                {
                    if (Convert.ToDouble(txtValorItemCompra.Text) <= 0)
                    {
                        errorIcone.SetError(txtValorItemCompra, "A quantidade não pode ser menor ou igual a 0 (zero)");
                    }
                    else
                    {
                        errorIcone.SetError(txtValorItemCompra, string.Empty);
                        ValorItemCompraOK = true;
                    }
                }
            }

            if (QuantidadeItemCompraOK == false ||
                ValorItemCompraOK == false)
            {
                MensagemErro("Por favor, preencha corretamente os campos sinalizados");
            }
            else
            {
                errorIcone.Clear();
                NovaCompra = false;
                EditarCompra = true;

                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja editar este produto na compra?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        InserirItemCompra();

                        LimparCamposItemCompra();
                        btnEditarItemCompra.Enabled = false;
                        btnEditarItemCompra.BackColor = Color.Sienna;
                        btnCancelarItemCompra.Enabled = false;
                        btnCancelarItemCompra.BackColor = Color.Sienna;

                        HabilitarTextBoxItemCompra(false);

                        CalcularCompra();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnCancelarItemCompra_Click(object sender, EventArgs e)
        {
            LimparCamposItemCompra();
            HabilitarTextBoxItemCompra(false);
            btnEditarItemCompra.Enabled = false;
            btnEditarItemCompra.BackColor = Color.Sienna;
            btnCancelarItemCompra.Enabled = false;
            btnCancelarItemCompra.BackColor = Color.Sienna;
        }

        private void btnSalvarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                errorIcone.Clear();
                string resp = "";

                resp = myCompra.FinalizarCompra(IDCompra, ValorTotal);


                MensagemOk("Registro salvo com sucesso");

                foreach (DataGridViewRow row in dgvItemCompra.Rows)
                {
                    BuscarLoteData(Convert.ToInt32(row.Cells["ID_Produto"].Value), Convert.ToDateTime(row.Cells["DT_Validade"].Value));

                    if (dgvValida.Rows.Count == 0)
                    {
                        resp = myLote.InserirLote(
                            Convert.ToInt32(row.Cells["ID_Produto"].Value),
                            Convert.ToDouble(row.Cells["QTDE_ItemCompra"].Value),
                            Convert.ToDateTime(row.Cells["DT_Validade"].Value));

                        resp = myEstoque.EditarEstoque(
                            Convert.ToInt32(row.Cells["ID_Produto"].Value),
                            Convert.ToDouble(row.Cells["QTDE_ItemCompra"].Value));
                    }
                    else
                    {
                        resp = myLote.EditarLote(
                            Convert.ToInt32(row.Cells["ID_Produto"].Value),
                            Convert.ToDouble(row.Cells["QTDE_ItemCompra"].Value),
                            Convert.ToDateTime(row.Cells["DT_Validade"].Value));

                        resp = myEstoque.EditarEstoque(
                            Convert.ToInt32(row.Cells["ID_Produto"].Value),
                            Convert.ToDouble(row.Cells["QTDE_ItemCompra"].Value));
                    }
                }

                NovaCompra = false;
                EditarCompra = false;
                Botoes();
                ExibirCompra();
                dgvProdutoCompra.DataSource = "";
                dgvItemCompra.DataSource = "";
                LimparCamposProdutoCompra();
                LimparCamposItemCompra();
                HabilitarCamposAdicionarProdutoCompra(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelarCompra_Click_1(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja cancelar esta compra? \nTodos os dados serão excluídos.",
                "Studio Carol Cruz",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                errorIcone.Clear();

                NovaCompra = false;
                EditarCompra = false;
                Botoes();
                ValidarCompra();
                ExibirCompra();
                dgvProdutoCompra.DataSource = "";
                dgvItemCompra.DataSource = "";
                LimparCamposProdutoCompra();
                LimparCamposItemCompra();
                HabilitarCamposAdicionarProdutoCompra(false);
            }
        }

        private void btnNovoCompra_Click(object sender, EventArgs e)
        {
            NovaCompra = true;
            EditarCompra = false;

            ValidarCompra();
            InserirCompra();
            btnNovoCompra.Enabled = false;
            btnNovoCompra.BackColor = Color.Sienna;

            Botoes();
            LimparCamposProdutoCompra();
            LimparCamposItemCompra();
            ExibirProdutoEstoque();
        }

        private void chkBuscarCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarCompra.Checked)
            {
                HabilitarBuscar(true);
            }
            else
            {
                HabilitarBuscar(false);

                if (txtBuscarProdutoCompraListar.Text != string.Empty)
                {
                    BuscarProdutoCompra();
                }
                else
                {
                    ExibirCompra();
                }
            }
        }

        private void btnBuscarCompra_Click_1(object sender, EventArgs e)
        {
            if (chkBuscarCompra.Checked)
            {
                if (txtBuscarProdutoCompraListar.Text != string.Empty)
                {
                    BuscarCompra();
                }
                else
                {
                    BuscarDataCompra();
                }
            }
            else
            {
                BuscarProdutoCompra();
            }
        }

        private void txtBuscarProdutoCompraListar_TextChanged_1(object sender, EventArgs e)
        {
            if (chkBuscarCompra.Checked)
            {
                BuscarCompra();
            }
            else
            {
                BuscarProdutoCompra();
            }
        }

        private void btnExcluirCompra_Click_1(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há compras selecionadas para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " compra(s)?" +
                        "\n\nObs.: compra(s) com data atual será realizada baixa" +
                        "\nno estoque com base na quantia que havia sido inserida.",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int compra;
                        int produto;
                        double quantidade;
                        DateTime validade;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvCompra.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                dgvListaItemCompra.DataSource = myItemCompra.ExibirItemCompra(Convert.ToInt32(row.Cells[1].Value));

                                dgvListaItemCompra.Columns[0].Visible = false;
                                dgvListaItemCompra.Columns[1].Visible = false;
                                dgvListaItemCompra.Columns[2].HeaderText = "PRODUTO";
                                dgvListaItemCompra.Columns[3].HeaderText = "VALIDADE";
                                dgvListaItemCompra.Columns[4].HeaderText = "TIPO\nARMAZENAMENTO";
                                dgvListaItemCompra.Columns[5].HeaderText = "QUANTIDADE";
                                dgvListaItemCompra.Columns[6].HeaderText = "VALOR";

                                dgvListaItemCompra.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                                dgvListaItemCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                                dgvListaItemCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                                foreach (DataGridViewRow itemRow in dgvListaItemCompra.Rows)
                                {
                                    if (Convert.ToDateTime(itemRow.Cells[3].Value) == DateTime.Today)
                                    {
                                        produto = Convert.ToInt32(itemRow.Cells[1].Value);
                                        quantidade = Convert.ToDouble(itemRow.Cells[5].Value);
                                        validade = Convert.ToDateTime(itemRow.Cells[3].Value);

                                        myBaixaEstoque.BaixaEstoque(produto, quantidade);
                                        myLote.BaixaLote(produto, quantidade, validade);
                                    }
                                }
                                compra = Convert.ToInt32(row.Cells[1].Value);
                                resp = myCompra.ExcluirCompra(compra);

                                dgvListaItemCompra.DataSource = "";
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Compra(s) excluída(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirCompra();
                        chkExcluirCompra.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkExcluirCompra_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkExcluirCompra.Checked)
            {
                dgvCompra.Columns[0].Visible = true;
            }
            else
            {
                dgvCompra.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvCompra.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }
    }
}
