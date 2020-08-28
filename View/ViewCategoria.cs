using Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewCategoria : Form
    {
        ControlCategoria myCategoria = new ControlCategoria();
        Validar myValidar = new Validar();

        private bool NovaCategoria = false;
        private bool EditarCategoria = false;

        public ViewCategoria()
        {
            InitializeComponent();
        }

        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "PIZZA VINTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparTextBox()
        {
            txtCodigoCategoria.Text = string.Empty;
            txtNomeCategoria.Text = string.Empty;
            txtDescricaoCategoria.Text = string.Empty;
        }

        private void HabilitarTextBox(bool Valor)
        {
            txtCodigoCategoria.Enabled = false;
            txtNomeCategoria.Enabled = Valor;
            txtDescricaoCategoria.Enabled = Valor;
        }

        private void Botoes()
        {
            if (NovaCategoria || EditarCategoria)
            {
                HabilitarTextBox(true);

                btnNovoCategoria.Enabled = false;
                btnNovoCategoria.BackColor = Color.Sienna;

                btnEditarCategoria.Enabled = false;
                btnEditarCategoria.BackColor = Color.Sienna;

                btnCancelarCategoria.Enabled = true;
                btnCancelarCategoria.BackColor = Color.Wheat;

                btnSalvarCategoria.Enabled = true;
                btnSalvarCategoria.BackColor = Color.Wheat;
            }
            else
            {
                HabilitarTextBox(false);

                btnNovoCategoria.Enabled = true;
                btnNovoCategoria.BackColor = Color.Wheat;

                btnEditarCategoria.Enabled = false;
                btnEditarCategoria.BackColor = Color.Sienna;

                btnCancelarCategoria.Enabled = false;
                btnCancelarCategoria.BackColor = Color.Sienna;

                btnSalvarCategoria.Enabled = false;
                btnSalvarCategoria.BackColor = Color.Sienna;
            }
        }

        private void OcultarColunaExcluir()
        {
            dgvCategoria.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvCategoria.Rows.Count == 0)
            {
                chkExcluirCategoria.Enabled = false;
                btnExcluirCategoria.Enabled = false;
                btnExcluirCategoria.BackColor = Color.Sienna;
                txtBuscarCategoria.Enabled = false;
                btnBuscarCategoria.Enabled = false;
                btnBuscarCategoria.BackColor = Color.Sienna;
                dgvCategoria.Enabled = false;
            }
            else
            {
                chkExcluirCategoria.Enabled = true;
                btnExcluirCategoria.Enabled = true;
                btnExcluirCategoria.BackColor = Color.Wheat;
                txtBuscarCategoria.Enabled = true;
                btnBuscarCategoria.Enabled = true;
                btnBuscarCategoria.BackColor = Color.Wheat;
                dgvCategoria.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvCategoria.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvCategoria.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirCategoria()
        {
            dgvCategoria.DataSource = myCategoria.ExibirCategoria();
            OcultarColunaExcluir();
            lblTotalCategoria.Text = "Total de Categorias: " + Convert.ToString(dgvCategoria.Rows.Count);

            dgvCategoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvCategoria.Columns[1].HeaderText = "CÓDIGO";
            dgvCategoria.Columns[2].HeaderText = "NOME";
            dgvCategoria.Columns[3].Visible = false;

            dgvCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void BuscarNomeCategoria()
        {
            ValidarTamanhoCampo(txtBuscarCategoria, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvCategoria.DataSource = myCategoria.BuscarNomeCategoria(txtBuscarCategoria.Text);
                lblTotalCategoria.Text = "Total de Categorias: " + Convert.ToString(dgvCategoria.Rows.Count);
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

        private void ViewCategoria_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            ExibirCategoria();
            HabilitarTextBox(false);
            Botoes();
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            BuscarNomeCategoria();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            BuscarNomeCategoria();
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvCategoria.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))//Pega os valores com checkbox clicados (TRUE)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há categorias selecionados para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " categoria(s)?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string Nome;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvCategoria.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                Nome = Convert.ToString(row.Cells[2].Value);
                                resp = myCategoria.ExcluirCategoria(Convert.ToInt32(Codigo), Nome);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Categoria(s) excluída(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirCategoria();
                        chkExcluirCategoria.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkExcluirCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirCategoria.Checked)
            {
                dgvCategoria.Columns[0].Visible = true;

            }
            else
            {
                dgvCategoria.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvCategoria.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCategoria.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoCategoria.Text = Convert.ToString(dgvCategoria.CurrentRow.Cells["ID_Categoria"].Value);
            txtNomeCategoria.Text = Convert.ToString(dgvCategoria.CurrentRow.Cells["NM_Categoria"].Value);
            txtDescricaoCategoria.Text = Convert.ToString(dgvCategoria.CurrentRow.Cells["DS_Categoria"].Value);

            btnEditarCategoria.Enabled = true;
            btnEditarCategoria.BackColor = Color.Wheat;
            tctrlCategoria.SelectedIndex = 1;
        }

        private void btnNovoCategoria_Click(object sender, EventArgs e)
        {
            NovaCategoria = true;
            EditarCategoria = false;
            Botoes();
            LimparTextBox();
            HabilitarTextBox(true);
            txtNomeCategoria.Focus();
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                bool NomeCategoriaOK = false;
                bool DescricaoCategoriaOK = false;

                string resp = "";

                ValidarCampoNulo(txtNomeCategoria);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtNomeCategoria, 50);
                    if (myValidar.TamanhoValido == true)
                    {
                        NomeCategoriaOK = true;
                    }
                }

                ValidarCampoNulo(txtDescricaoCategoria);
                if (myValidar.CampoValido == true)
                {
                    ValidarTamanhoCampo(txtDescricaoCategoria, 1500);
                    if (myValidar.TamanhoValido == true)
                    {
                        DescricaoCategoriaOK = true;
                    }
                }


                bool CATcadastrada = false;

                foreach (DataGridViewRow row in dgvCategoria.Rows)
                {
                    if (txtCodigoCategoria.Text != Convert.ToString(row.Cells["ID_Categoria"].Value))
                    {
                        if (txtNomeCategoria.Text == Convert.ToString(row.Cells["NM_Categoria"].Value))
                        {
                            CATcadastrada = true;
                        }
                    }
                }

                if (CATcadastrada == true)
                {
                    MensagemErro("Categoria já cadastrada na base de dados");
                }
                else
                {
                    if (NomeCategoriaOK == false ||
                        DescricaoCategoriaOK == false)
                    {
                        MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                    }
                    else
                    {
                        errorIcone.Clear();

                        if (NovaCategoria)
                        {

                            resp = myCategoria.InserirCategoria(
                            txtNomeCategoria.Text.Trim(),
                            txtDescricaoCategoria.Text.Trim()
                            );

                        }
                        else
                        {
                            resp = myCategoria.EditarCategoria(
                                Convert.ToInt32(txtCodigoCategoria.Text),
                                txtNomeCategoria.Text.Trim(),
                                txtDescricaoCategoria.Text.Trim()
                                );
                        }

                        if (resp.Equals("OK"))
                        {
                            if (NovaCategoria)
                            {
                                MensagemOk("Registro salvo com sucesso");
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

                        NovaCategoria = false;
                        EditarCategoria = false;
                        Botoes();
                        LimparTextBox();
                        ExibirCategoria();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoria.Text.Equals(""))
            {
                MensagemErro("Selecione um registro para editar");
            }
            else
            {
                txtCodigoCategoria.Enabled = false;
                txtNomeCategoria.Focus();
                EditarCategoria = true;
                NovaCategoria = false;
                Botoes();
                HabilitarTextBox(true);
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            errorIcone.Clear();

            NovaCategoria = false;
            EditarCategoria = false;
            Botoes();
            HabilitarTextBox(false);
            LimparTextBox();
        }

        private void tctrlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorIcone.Clear();

            if (tctrlCategoria.SelectedIndex == 0)
            {
                HabilitarTextBox(false);
                LimparTextBox();
                NovaCategoria = false;
                EditarCategoria = false;
                Botoes();
            }
        }
    }
}
