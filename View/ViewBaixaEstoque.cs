using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ViewBaixaEstoque : Form
    {
        ControlBaixaEstoque myBaixaEstoque = new ControlBaixaEstoque();
        ControlProduto myProduto = new ControlProduto();
        ControlLote myLote = new ControlLote();
        Validar myValidar = new Validar();

        private bool NovaBaixaEstoque = false;
        private bool EditarBaixaEstoque = false;

        public ViewBaixaEstoque()
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
            txtCodigoBaixaEstoque.Text = string.Empty;
            cboxProdutoBaixaEstoque.Text = null;
            cboxLoteProdutoBaixaEstoque.Text = null;
            txtQuantidadeLoteProduto.Text = string.Empty;
            txtQuantidadeProdutoBaixaEstoque.Text = string.Empty;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoBaixaEstoque.Enabled = false;
            cboxProdutoBaixaEstoque.Enabled = Valor;
            cboxLoteProdutoBaixaEstoque.Enabled = Valor;
            txtQuantidadeLoteProduto.Enabled = false;
            txtQuantidadeProdutoBaixaEstoque.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovaBaixaEstoque || EditarBaixaEstoque)
            {
                HabilitarTextBox(true);

                btnNovoBaixaEstoque.Enabled = false;
                btnNovoBaixaEstoque.BackColor = Color.Sienna;

                btnCancelarBaixaEstoque.Enabled = true;
                btnCancelarBaixaEstoque.BackColor = Color.Wheat;

                btnSalvarBaixaEstoque.Enabled = true;
                btnSalvarBaixaEstoque.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoBaixaEstoque.Enabled = true;
                btnNovoBaixaEstoque.BackColor = Color.Wheat;

                btnCancelarBaixaEstoque.Enabled = false;
                btnCancelarBaixaEstoque.BackColor = Color.Sienna;

                btnSalvarBaixaEstoque.Enabled = false;
                btnSalvarBaixaEstoque.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvBaixaEstoque.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvBaixaEstoque.Rows.Count == 0)
            {
                chkExcluirBaixaEstoque.Enabled = false;
                btnExcluirBaixaEstoque.Enabled = false;
                btnExcluirBaixaEstoque.BackColor = Color.Sienna;
                dgvBaixaEstoque.Enabled = false;
            }
            else
            {
                chkExcluirBaixaEstoque.Enabled = true;
                btnExcluirBaixaEstoque.Enabled = true;
                btnExcluirBaixaEstoque.BackColor = Color.Wheat;
                dgvBaixaEstoque.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvBaixaEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvBaixaEstoque.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirBaixaEstoque()
        {
            dgvBaixaEstoque.DataSource = myBaixaEstoque.ExibirBaixaEstoque();
            OcultarColunaExcluir();
            lblTotalBaixaEstoque.Text = "Total de Baixas: " + Convert.ToString(dgvBaixaEstoque.Rows.Count);

            dgvBaixaEstoque.Columns[1].HeaderText = "CÓDIGO";
            dgvBaixaEstoque.Columns[2].HeaderText = "DATA";
            dgvBaixaEstoque.Columns[3].Visible = false;
            dgvBaixaEstoque.Columns[4].HeaderText = "PRODUTO";
            dgvBaixaEstoque.Columns[5].HeaderText = "TIPO\nARMAZENAMENTO";
            dgvBaixaEstoque.Columns[6].HeaderText = "QUANTIDADE";
            dgvBaixaEstoque.Columns[7].HeaderText = "VALIDADE";

            dgvBaixaEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBaixaEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBaixaEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarBaixaEstoque()
        {
            dgvBaixaEstoque.DataSource = myBaixaEstoque.BuscarBaixaEstoque(dtInicioBuscar.Value, dtFinalBuscar.Value.AddDays(1), txtBuscarProdutoBaixaEstoque.Text);
            OcultarColunaExcluir();
            lblTotalBaixaEstoque.Text = "Total de Baixas: " + Convert.ToString(dgvBaixaEstoque.Rows.Count);

            HabilitarDataGridView();
        }

        private void BuscarDataBaixaEstoque()
        {
            dgvBaixaEstoque.DataSource = myBaixaEstoque.BuscarDataBaixaEstoque(dtInicioBuscar.Value, dtFinalBuscar.Value.AddDays(1));
            OcultarColunaExcluir();
            lblTotalBaixaEstoque.Text = "Total de Baixas: " + Convert.ToString(dgvBaixaEstoque.Rows.Count);

            HabilitarDataGridView();
        }

        private void BuscarProdutoBaixaEstoque()
        {
            dgvBaixaEstoque.DataSource = myBaixaEstoque.BuscarProdutoBaixaEstoque(txtBuscarProdutoBaixaEstoque.Text);
            OcultarColunaExcluir();
            lblTotalBaixaEstoque.Text = "Total de Baixas: " + Convert.ToString(dgvBaixaEstoque.Rows.Count);

            HabilitarDataGridView();
        }

        private void ExibirProduto()
        {
            cboxProdutoBaixaEstoque.DisplayMember = "NM_Produto";
            cboxProdutoBaixaEstoque.ValueMember = "ID_Produto";
            cboxProdutoBaixaEstoque.DataSource = myProduto.ExibirProduto();
        }

        private void ExibirLote()
        {
            if (cboxProdutoBaixaEstoque.SelectedValue != null)
            {
                cboxLoteProdutoBaixaEstoque.DisplayMember = "DT_Validade";
                cboxLoteProdutoBaixaEstoque.ValueMember = "DT_Validade";
                cboxLoteProdutoBaixaEstoque.DataSource = myLote.BuscarLote(
                    Convert.ToInt32(cboxProdutoBaixaEstoque.SelectedValue.ToString()));
            }
        }

        private void HabilitarBuscar(bool Valor)
        {
            dtInicioBuscar.Value = DateTime.Today;
            dtFinalBuscar.Value = DateTime.Today;

            dtInicioBuscar.Enabled = Valor;
            dtFinalBuscar.Enabled = Valor;
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

        private void ViewBaixaEstoque_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirBaixaEstoque();
            HabilitarBuscar(false);
            LimparTextBox();           
            HabilitarTextBox(false);          
            Botoes();
        }

        private void cboxBuscarBaixaEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarBaixaEstoque.Checked)
            {
                HabilitarBuscar(true);
            }
            else
            {
                HabilitarBuscar(false);

                if (txtBuscarProdutoBaixaEstoque.Text != string.Empty)
                {
                    BuscarProdutoBaixaEstoque();
                }
                else
                {
                    ExibirBaixaEstoque();
                }
            }
        }

        private void txtBuscarProdutoBaixaEstoque_TextChanged(object sender, EventArgs e)
        {
            if (chkBuscarBaixaEstoque.Checked)
            {
                BuscarBaixaEstoque();
            }
            else
            {
                BuscarProdutoBaixaEstoque();
            }
        }

        private void btnBuscarBaixaEstoque_Click(object sender, EventArgs e)
        {
            if (chkBuscarBaixaEstoque.Checked)
            {
                if (txtBuscarProdutoBaixaEstoque.Text != string.Empty)
                {
                    BuscarBaixaEstoque();
                }
                else
                {
                    BuscarDataBaixaEstoque();
                }
            }
            else
            {
                BuscarProdutoBaixaEstoque();
            }
        }

        private void chkExcluirBaixaEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirBaixaEstoque.Checked)
            {
                dgvBaixaEstoque.Columns[0].Visible = true;
            }
            else
            {
                dgvBaixaEstoque.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvBaixaEstoque.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirBaixaEstoque_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvBaixaEstoque.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há baixa(s) selecionada(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " baixa(s)?" +
                        "\n\nObs.: As quantidades não serão retornadas ao estoque.",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvBaixaEstoque.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myBaixaEstoque.ExcluirBaixaEstoque(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Baixa(s) excluída(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirBaixaEstoque();
                        chkExcluirBaixaEstoque.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvBaixaEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvBaixaEstoque.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvBaixaEstoque.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvBaixaEstoque_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoBaixaEstoque.Text = Convert.ToString(dgvBaixaEstoque.CurrentRow.Cells["ID_BaixaEstoque"].Value);
            cboxProdutoBaixaEstoque.Text = Convert.ToString(dgvBaixaEstoque.CurrentRow.Cells["NM_Produto"].Value);
            cboxLoteProdutoBaixaEstoque.Text = Convert.ToString(dgvBaixaEstoque.CurrentRow.Cells["DT_ValidadeBaixaEstoque"].Value);
            txtQuantidadeProdutoBaixaEstoque.Text = Convert.ToString(dgvBaixaEstoque.CurrentRow.Cells["QTDE_BaixaEstoque"].Value);

            tctrlBaixaEstoque.SelectedIndex = 1;
        }

        private void btnNovoBaixaEstoque_Click(object sender, EventArgs e)
        {
            NovaBaixaEstoque = true;
            EditarBaixaEstoque = false;
            Botoes();
            ExibirProduto();
            LimparTextBox();
            HabilitarTextBox(true);
            cboxProdutoBaixaEstoque.Focus();
        }

        private void btnCancelarBaixaEstoque_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovaBaixaEstoque = false;
            EditarBaixaEstoque = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void btnSalvarBaixaEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                bool ProdutoBaixaEstoqueOK = false;
                bool LoteBaixaEstoqueOK = false;
                bool QuantidadeBaixaEstoqueOK = false;

                string resp = "";

                if (cboxProdutoBaixaEstoque.Text != string.Empty)
                {
                    ProdutoBaixaEstoqueOK = true;
                }

                if (cboxLoteProdutoBaixaEstoque.Text != string.Empty)
                {
                    LoteBaixaEstoqueOK = true;
                }

                ValidarCampoNulo(txtQuantidadeProdutoBaixaEstoque);
                if (myValidar.CampoValido == true)
                {
                    ValidarValor(txtQuantidadeProdutoBaixaEstoque);
                    if (myValidar.ValorValido == true)
                    {
                        if (Convert.ToDouble(txtQuantidadeProdutoBaixaEstoque.Text) <= 0)
                        {
                            errorIcone.SetError(txtQuantidadeProdutoBaixaEstoque, "A quantidade não pode ser menor ou igual a 0 (zero)");
                        }
                        else
                        {
                            if (Convert.ToDouble(txtQuantidadeProdutoBaixaEstoque.Text) > Convert.ToDouble(txtQuantidadeLoteProduto.Text))
                            {
                                errorIcone.SetError(txtQuantidadeProdutoBaixaEstoque, "A quantidade não pode ser maior que a disponível no lote");
                            }
                            else
                            {
                                QuantidadeBaixaEstoqueOK = true;
                            }
                        }
                    }
                }

                if (ProdutoBaixaEstoqueOK == false ||
                    LoteBaixaEstoqueOK == false ||
                    QuantidadeBaixaEstoqueOK == false)
                {
                    MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();

                    if (NovaBaixaEstoque)
                    {
                        resp = myLote.BaixaLote(
                            Convert.ToInt32(cboxProdutoBaixaEstoque.SelectedValue),
                            Convert.ToDouble(txtQuantidadeProdutoBaixaEstoque.Text),
                            Convert.ToDateTime(cboxLoteProdutoBaixaEstoque.Text));

                        if (resp.Equals("OK"))
                        {
                            resp = myBaixaEstoque.BaixaEstoque(
                                Convert.ToInt32(cboxProdutoBaixaEstoque.SelectedValue),
                                Convert.ToDouble(txtQuantidadeProdutoBaixaEstoque.Text));
                        }
                    }

                    if (resp.Equals("OK"))
                    {
                        if (NovaBaixaEstoque)
                        {
                            MensagemOk("Registro salvo com sucesso");

                            resp = myBaixaEstoque.RegistrarBaixaEstoque(
                                Convert.ToInt32(cboxProdutoBaixaEstoque.SelectedValue),
                                Convert.ToDouble(txtQuantidadeProdutoBaixaEstoque.Text),
                                Convert.ToDateTime(cboxLoteProdutoBaixaEstoque.Text));
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

                    NovaBaixaEstoque = false;
                    EditarBaixaEstoque = false;
                    Botoes();
                    LimparTextBox();
                    ExibirBaixaEstoque();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cboxProdutoBaixaEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxLoteProdutoBaixaEstoque.DataSource = null;
            txtQuantidadeLoteProduto.Text = string.Empty;
        }

        private void cboxLoteProdutoBaixaEstoque_Click(object sender, EventArgs e)
        {
            ExibirLote();
        }

        private void cboxLoteProdutoBaixaEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLoteProdutoBaixaEstoque.SelectedValue != null)
            {
                txtQuantidadeLoteProduto.Text = myLote.ObterQuantidadeDoLote(
                                        Convert.ToInt32(cboxProdutoBaixaEstoque.SelectedValue.ToString()),
                                        Convert.ToDateTime(cboxLoteProdutoBaixaEstoque.SelectedValue.ToString()));
            }
        }

        private void tctrlBaixaEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlBaixaEstoque.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovaBaixaEstoque = false;
                EditarBaixaEstoque = false;
                Botoes();
            }
        }
    }
}
