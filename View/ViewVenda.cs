using Control;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace View
{
    public partial class ViewVenda : Form
    {
        ControlVenda myVenda = new ControlVenda();
        ControlProcedimento myProcedimento = new ControlProcedimento();
        ControlCategoria myCategoria = new ControlCategoria();
        ControlItemVenda myItemVenda = new ControlItemVenda();
        ControlSessao mySessao = new ControlSessao();
        ControlFuncionario myFuncionario = new ControlFuncionario();
        ControlCliente myCliente = new ControlCliente();
        ControlEstoque myEstoque = new ControlEstoque();
        Validar myValidar = new Validar();

        TabPage[] TabRemove = new TabPage[3];
        private bool NovaVenda = false;
        private bool EditarVenda = false;

        private int _IDVenda;
        private double _ValorSubtotal;
        private double _ValorLucro;
        private double _ValorTotal;

        public int IDVenda { get => _IDVenda; set => _IDVenda = value; }
        public double ValorSubtotal { get => _ValorSubtotal; set => _ValorSubtotal = value; }
        public double ValorLucro { get => _ValorLucro; set => _ValorLucro = value; }
        public double ValorTotal { get => _ValorTotal; set => _ValorTotal = value; }

        public ViewVenda()
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

        private void OcultarTabProcedimentos()
        {
            TabRemove[0] = tpgSelecionarProcedimentos;
            tctrlVenda.TabPages.Remove(tpgSelecionarProcedimentos);
        }

        private void OcultarTabVenda()
        {
            TabRemove[1] = tpgFinalizarVenda;
            tctrlVenda.TabPages.Remove(tpgFinalizarVenda);
        }

        private void MostrarTabProcedimentos()
        {
            tctrlVenda.TabPages.Add(TabRemove[0]);
        }

        private void MostrarTabVenda()
        {
            tctrlVenda.TabPages.Add(TabRemove[1]);
        }

        private void HabilitarDataGridViewCliente()
        {
            if (dgvClienteVenda.Rows.Count == 0)
            {
                cboxBuscarClienteVenda.Enabled = false;
                txtBuscarNomeClienteVenda.Enabled = false;
                txtBuscarCPFClienteVenda.Enabled = false;
                btnBuscarClienteVenda.Enabled = false;
                btnBuscarClienteVenda.BackColor = Color.Sienna;
                dgvClienteVenda.Enabled = false;
            }
            else
            {
                cboxBuscarClienteVenda.Enabled = true;
                txtBuscarNomeClienteVenda.Enabled = true;
                txtBuscarCPFClienteVenda.Enabled = true;
                btnBuscarClienteVenda.Enabled = true;
                btnBuscarClienteVenda.BackColor = Color.Wheat;
                dgvClienteVenda.Enabled = true;
            }
        }

        private void HabilitarDataGridViewProcedimento()
        {
            if (dgvProcedimentoVenda.Rows.Count == 0)
            {
                txtBuscarProcedimentoVenda.Enabled = false;
                btnBuscarProcedimentoVenda.Enabled = false;
                btnBuscarProcedimentoVenda.BackColor = Color.Sienna;
                dgvProcedimentoVenda.Enabled = false;
            }
            else
            {
                txtBuscarProcedimentoVenda.Enabled = true;
                btnBuscarProcedimentoVenda.Enabled = true;
                btnBuscarProcedimentoVenda.BackColor = Color.Wheat;
                dgvProcedimentoVenda.Enabled = true;
            }
        }

        private void HabilitarDataGridViewItemVenda()
        {
            if (dgvItemVenda.Rows.Count == 0)
            {
                chkExcluirItemVenda.Enabled = false;
                dgvItemVenda.Enabled = false;
            }
            else
            {
                chkExcluirItemVenda.Enabled = true;
                dgvItemVenda.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvClienteVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvClienteVenda.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvProcedimentoVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvProcedimentoVenda.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvItemVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvItemVenda.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvItemVendaFinalizar.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvItemVendaFinalizar.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void BuscarClienteVenda()
        {
            if (cboxBuscarClienteVenda.Text.Equals("Nome"))
            {
                ValidarTamanhoCampo(txtBuscarNomeClienteVenda, 50);
                if (myValidar.TamanhoValido == true)
                {
                    dgvClienteVenda.DataSource = myCliente.BuscarNomeCliente(txtBuscarNomeClienteVenda.Text);
                }
            }
            else if (cboxBuscarClienteVenda.Text.Equals("CPF"))
            {
                if (txtBuscarCPFClienteVenda.MaskCompleted)
                {
                    if (myValidar.ValidaCPF(txtBuscarCPFClienteVenda.Text) == false)
                    {
                        errorIcone.SetError(txtBuscarCPFClienteVenda, "Número de CPF inválido");
                    }
                    else
                    {
                        errorIcone.SetError(txtBuscarCPFClienteVenda, string.Empty);
                    }
                }

                errorIcone.SetError(txtCPFClienteVenda, string.Empty);
                dgvClienteVenda.DataSource = myCliente.BuscarCPFCliente(txtBuscarCPFClienteVenda.Text);
            }
        }

        private void BuscarProcedimento()
        {
            ValidarTamanhoCampo(txtBuscarProcedimentoVenda, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvProcedimentoVenda.DataSource = myProcedimento.BuscarProcedimento(Convert.ToInt32(cboxBuscarProcedimentoVenda.SelectedValue.ToString()),
                                                                                                    txtBuscarProcedimentoVenda.Text);
            }
        }

        private void BuscarNomeProcedimento()
        {
            ValidarTamanhoCampo(txtBuscarProcedimentoVenda, 50);
            if (myValidar.TamanhoValido == true)
            {
                dgvProcedimentoVenda.DataSource = myProcedimento.BuscarNomeProcedimento(txtBuscarProcedimentoVenda.Text);
            }
        }

        private void BuscarCategoriaProcedimento()
        {
            dgvProcedimentoVenda.DataSource = myProcedimento.BuscarCategoriaProcedimento(Convert.ToInt32(cboxBuscarProcedimentoVenda.SelectedValue.ToString()));
        }

        private void LimparDadosCliente()
        {
            txtCodigoClienteVenda.Text = string.Empty;
            txtNomeClienteVenda.Text = string.Empty;
            txtSexoClienteVenda.Text = string.Empty;
            txtCPFClienteVenda.Text = string.Empty;
            txtNascimentoClienteVenda.Text = string.Empty;
            txtTelefoneClienteVenda.Text = string.Empty;
            txtEmailClienteVenda.Text = string.Empty;

            txtCEPClienteVenda.Text = string.Empty;
            txtRuaClienteVenda.Text = string.Empty;
            txtNumCasaClienteVenda.Text = string.Empty;
            txtBairroClienteVenda.Text = string.Empty;
            txtComplementoClienteVenda.Text = string.Empty;
            txtCidadeClienteVenda.Text = string.Empty;
            txtUFClienteVenda.Text = string.Empty;
        }

        private void LimparDadosProcedimentos()
        {
            txtCodigoProcedimentoVenda.Text = string.Empty;
            txtCategoriaProcedimentoVenda.Text = string.Empty;
            txtProcedimentoVenda.Text = string.Empty;
            txtDescricaoProcedimentoVenda.Text = string.Empty;
            txtPrecoVendaProcedimentoVenda.Text = string.Empty;
            txtValorLucroProcedimentoVenda.Text = string.Empty;
            txtQuantidadeSessoesProcedimentoVenda.Text = string.Empty;
            txtSubtotalProcedimentoVenda.Text = string.Empty;
        }

        private void LimparDadosItemVenda()
        {
            txtCodigoItemVenda.Text = string.Empty;
            txtCategoriaItemVenda.Text = string.Empty;
            txtItemVenda.Text = string.Empty;
            txtDescricaoItemVenda.Text = string.Empty;
            txtPrecoVendaItemVenda.Text = string.Empty;
            txtValorLucroItemVenda.Text = string.Empty;
            txtSubtotalItemVenda.Text = string.Empty;
            txtQuantidadeSessoesItemVenda.Text = string.Empty;
        }

        private void LimparDadosVenda()
        {
            txtFuncionarioVendaFinalizar.Text = string.Empty;

            txtCodigoClienteVendaFinalizar.Text = string.Empty;
            txtNomeClienteVendaFinalizar.Text = string.Empty;
            txtSexoClienteVendaFinalizar.Text = string.Empty;
            txtCPFClienteVendaFinalizar.Text = string.Empty;
            txtNascimentoClienteVendaFinalizar.Text = string.Empty;
            txtTelefoneClienteVendaFinalizar.Text = string.Empty;
            txtEmailClienteVendaFinalizar.Text = string.Empty;

            txtCEPClienteVendaFinalizar.Text = string.Empty;
            txtRuaClienteVendaFinalizar.Text = string.Empty;
            txtNumCasaClienteVendaFinalizar.Text = string.Empty;
            txtBairroClienteVendaFinalizar.Text = string.Empty;
            txtComplementoClienteVendaFinalizar.Text = string.Empty;
            txtCidadeClienteVendaFinalizar.Text = string.Empty;
            txtUFClienteVendaFinalizar.Text = string.Empty;

            dgvItemVendaFinalizar.DataSource = "";
            txtObservacoesVendaFinalizar.Text = string.Empty;
            cboxTipoPagamentoVendaFinalizar.Text = null;
            lblSubtotalVendaFinalizar.Text = "Subtotal: R$0,00";
            lblLucroVendaFinalizar.Text = "Lucro: R$0,00";
            lblTotalVendaFinalizar.Text = "Total: R$0,00";
        }

        private void TranferirDadosCliente()
        {
            txtCodigoClienteVendaFinalizar.Text = txtCodigoClienteVenda.Text;
            txtNomeClienteVendaFinalizar.Text = txtNomeClienteVenda.Text;
            txtSexoClienteVendaFinalizar.Text = txtSexoClienteVenda.Text;
            txtCPFClienteVendaFinalizar.Text = txtCPFClienteVenda.Text;
            txtNascimentoClienteVendaFinalizar.Text = txtNascimentoClienteVenda.Text;
            txtTelefoneClienteVendaFinalizar.Text = txtTelefoneClienteVenda.Text;
            txtEmailClienteVendaFinalizar.Text = txtEmailClienteVenda.Text;

            txtCEPClienteVendaFinalizar.Text = txtCEPClienteVenda.Text;
            txtRuaClienteVendaFinalizar.Text = txtRuaClienteVenda.Text;
            txtNumCasaClienteVendaFinalizar.Text = txtNumCasaClienteVenda.Text;
            txtBairroClienteVendaFinalizar.Text = txtBairroClienteVenda.Text;
            txtComplementoClienteVendaFinalizar.Text = txtComplementoClienteVenda.Text;
            txtCidadeClienteVendaFinalizar.Text = txtCidadeClienteVenda.Text;
            txtUFClienteVendaFinalizar.Text = txtUFClienteVenda.Text;
        }

        private void HabilitarCamposSelecionarCliente(bool Valor)
        {
            cboxFuncionarioVenda.Enabled = Valor;

            txtCodigoClienteVenda.Enabled = false;
            txtNomeClienteVenda.Enabled = false;
            txtSexoClienteVenda.Enabled = false;
            txtCPFClienteVenda.Enabled = false;
            txtNascimentoClienteVenda.Enabled = false;
            txtTelefoneClienteVenda.Enabled = false;
            txtEmailClienteVenda.Enabled = false;

            txtCEPClienteVenda.Enabled = false;
            txtRuaClienteVenda.Enabled = false;
            txtNumCasaClienteVenda.Enabled = false;
            txtBairroClienteVenda.Enabled = false;
            txtComplementoClienteVenda.Enabled = false;
            txtCidadeClienteVenda.Enabled = false;
            txtUFClienteVenda.Enabled = false;

            cboxBuscarClienteVenda.Enabled = Valor;
            txtBuscarNomeClienteVenda.Enabled = Valor;
            txtBuscarCPFClienteVenda.Enabled = Valor;
            btnBuscarClienteVenda.Enabled = Valor;

            if (btnBuscarClienteVenda.Enabled == true)
            {
                btnBuscarClienteVenda.BackColor = Color.Wheat;
            }
            else
            {
                btnBuscarClienteVenda.BackColor = Color.Sienna;
            }

            dgvClienteVenda.Enabled = Valor;
        }

        private void HabilitarCamposSelecionarProcedimentos(bool Valor)
        {
            txtBuscarProcedimentoVenda.Enabled = Valor;
            btnBuscarProcedimentoVenda.Enabled = Valor;

            if (btnBuscarProcedimentoVenda.Enabled == true)
            {
                btnBuscarProcedimentoVenda.BackColor = Color.Wheat;
            }
            else
            {
                btnBuscarProcedimentoVenda.BackColor = Color.Sienna;
            }

            dgvProcedimentoVenda.Enabled = Valor;

            txtCodigoProcedimentoVenda.Enabled = false;
            txtCategoriaProcedimentoVenda.Enabled = false;
            txtProcedimentoVenda.Enabled = false;
            txtDescricaoProcedimentoVenda.Enabled = false;
            txtPrecoVendaProcedimentoVenda.Enabled = false;
            txtValorLucroProcedimentoVenda.Enabled = false;
            txtQuantidadeSessoesProcedimentoVenda.Enabled = false;
            txtSubtotalProcedimentoVenda.Enabled = false;

            btnConfirmarProcedimentoVenda.Enabled = false;
            btnConfirmarProcedimentoVenda.BackColor = Color.Sienna;
            btnCancelarProcedimentoVenda.Enabled = false;
            btnCancelarProcedimentoVenda.BackColor = Color.Sienna;

            chkExcluirItemVenda.Enabled = false;
            dgvItemVenda.Enabled = Valor;
            btnExcluirItemVenda.Enabled = false;
            btnExcluirItemVenda.BackColor = Color.Sienna;

            txtCodigoItemVenda.Enabled = false;
            txtCategoriaItemVenda.Enabled = false;
            txtItemVenda.Enabled = false;
            txtDescricaoItemVenda.Enabled = false;
            txtPrecoVendaItemVenda.Enabled = false;
            txtValorLucroItemVenda.Enabled = false;
            txtQuantidadeSessoesItemVenda.Enabled = false;
            txtSubtotalItemVenda.Enabled = false;

            btnEditarItemVenda.Enabled = false;
            btnEditarItemVenda.BackColor = Color.Sienna;
            btnCancelarItemVenda.Enabled = false;
            btnCancelarItemVenda.BackColor = Color.Sienna;

            btnRealizarPagamentoVenda.Enabled = Valor;

            if (btnRealizarPagamentoVenda.Enabled == true)
            {
                btnRealizarPagamentoVenda.BackColor = Color.Wheat;
            }
            else
            {
                btnRealizarPagamentoVenda.BackColor = Color.Sienna;
            }

            dgvItemVenda.Columns[0].Visible = false;
        }

        private void HabilitarCamposFinalizarVenda(bool Valor)
        {
            txtFuncionarioVendaFinalizar.Text = cboxFuncionarioVenda.Text;
            txtFuncionarioVendaFinalizar.Enabled = false;

            txtCodigoClienteVendaFinalizar.Enabled = false;
            txtNomeClienteVendaFinalizar.Enabled = false;
            txtSexoClienteVendaFinalizar.Enabled = false;
            txtCPFClienteVendaFinalizar.Enabled = false;
            txtNascimentoClienteVendaFinalizar.Enabled = false;
            txtTelefoneClienteVendaFinalizar.Enabled = false;
            txtEmailClienteVendaFinalizar.Enabled = false;

            txtCEPClienteVendaFinalizar.Enabled = false;
            txtRuaClienteVendaFinalizar.Enabled = false;
            txtNumCasaClienteVendaFinalizar.Enabled = false;
            txtBairroClienteVendaFinalizar.Enabled = false;
            txtComplementoClienteVendaFinalizar.Enabled = false;
            txtCidadeClienteVendaFinalizar.Enabled = false;
            txtUFClienteVendaFinalizar.Enabled = false;

            dgvItemVendaFinalizar.Enabled = Valor;
            txtObservacoesVendaFinalizar.Enabled = Valor;
            cboxTipoPagamentoVendaFinalizar.Enabled = Valor;

            btnCancelarVenda.Enabled = Valor;

            if (btnCancelarVenda.Enabled == true)
            {
                btnCancelarVenda.BackColor = Color.Wheat;
            }
            else
            {
                btnCancelarVenda.BackColor = Color.Sienna;
            }

            btnSalvarVenda.Enabled = Valor;

            if (btnSalvarVenda.Enabled == true)
            {
                btnSalvarVenda.BackColor = Color.Wheat;
            }
            else
            {
                btnSalvarVenda.BackColor = Color.Sienna;
            }
        }

        private void BotoesCliente()
        {
            if (NovaVenda || EditarVenda)
            {
                btnConfirmarClienteVenda.Enabled = false;
                btnConfirmarClienteVenda.BackColor = Color.Sienna;

                btnAlterarClienteVenda.Enabled = false;
                btnAlterarClienteVenda.BackColor = Color.Sienna;

                btnNovoVenda.Enabled = false;
                btnNovoVenda.BackColor = Color.Sienna;
            }
            else
            {
                btnConfirmarClienteVenda.Enabled = false;
                btnConfirmarClienteVenda.BackColor = Color.Sienna;

                btnAlterarClienteVenda.Enabled = false;
                btnAlterarClienteVenda.BackColor = Color.Sienna;

                btnNovoVenda.Enabled = true;
                btnNovoVenda.BackColor = Color.Wheat;
            }
        }

        private bool InserirVenda()
        {
            bool vendaInserida = false;

            try
            {
                string resp = "";

                if (txtNomeClienteVenda.Text == string.Empty)
                {
                    MensagemErro("Selecione um cliente");
                }
                else
                {
                    if (txtObservacoesVendaFinalizar.Text == string.Empty)
                    {
                        txtObservacoesVendaFinalizar.Text = "Sem Observações";
                    }

                    if (NovaVenda)
                    {
                        resp = myVenda.InserirVenda(
                            Convert.ToInt32(cboxFuncionarioVenda.SelectedValue),
                            Convert.ToInt32(txtCodigoClienteVenda.Text));

                        dgvVendaValida.DataSource = myVenda.ExibirVendaAno();

                        foreach (DataGridViewRow row in dgvVendaValida.Rows)
                        {
                            if (Convert.ToString(row.Cells["VL_Total"].Value) == string.Empty)
                            {
                                IDVenda = Convert.ToInt32(row.Cells["ID_Venda"].Value);
                            }
                        }
                    }
                    else
                    {
                        resp = myVenda.EditarVenda(IDVenda,
                            Convert.ToInt32(cboxFuncionarioVenda.SelectedValue),
                            Convert.ToInt32(txtCodigoClienteVenda.Text),
                            txtObservacoesVendaFinalizar.Text,
                            cboxTipoPagamentoVendaFinalizar.Text,
                            ValorSubtotal,
                            ValorLucro,
                            ValorTotal);
                    }

                    if (resp.Equals("OK"))
                    {
                        if (NovaVenda)
                        {
                            MensagemOk("Nova venda iniciada Nº" + IDVenda);
                        }
                        else
                        {
                            MensagemOk("Venda concluída! Retornando a tela inicial...");
                        }

                        vendaInserida = true;
                    }
                    else
                    {
                        MensagemErro(resp);

                        vendaInserida = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            return vendaInserida;
        }

        private void InserirItemVenda()
        {
            try
            {
                string resp = "";

                if (NovaVenda)
                {
                    errorIcone.Clear();

                    resp = myItemVenda.InserirItemVenda(IDVenda,
                            Convert.ToInt32(txtCodigoProcedimentoVenda.Text),
                            Convert.ToDouble(txtPrecoVendaProcedimentoVenda.Text),
                            Convert.ToDouble(txtValorLucroProcedimentoVenda.Text),
                            Convert.ToInt32(txtQuantidadeSessoesProcedimentoVenda.Text),
                            Convert.ToDouble(txtSubtotalProcedimentoVenda.Text));
                }
                else
                {
                    errorIcone.Clear();

                    resp = myItemVenda.EditarItemVenda(IDVenda,
                            Convert.ToInt32(txtCodigoItemVenda.Text),
                            Convert.ToDouble(txtPrecoVendaItemVenda.Text),
                            Convert.ToDouble(txtValorLucroItemVenda.Text),
                            Convert.ToInt32(txtQuantidadeSessoesItemVenda.Text),
                            Convert.ToDouble(txtSubtotalItemVenda.Text));
                }

                if (resp.Equals("OK"))
                {
                    ExibirItemVenda();
                }
                else
                {
                    MensagemErro(resp);
                }

                NovaVenda = false;
                EditarVenda = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private bool InserirSessao()
        {
            bool sessaoInserida = false;

            try
            {
                string resp = "";

                foreach (DataGridViewRow row in dgvItemVendaFinalizar.Rows)
                {
                    resp = mySessao.InserirSessao(
                        Convert.ToInt32(row.Cells["ID_Venda"].Value),
                        Convert.ToInt32(row.Cells["ID_Procedimento"].Value),
                        Convert.ToInt32(row.Cells["QTDE_Sessao"].Value));
                }

                if (resp.Equals("OK"))
                {
                    sessaoInserida = true;
                }
                else
                {
                    MensagemErro(resp);

                    sessaoInserida = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            return sessaoInserida;
        }

        private void ExibirClientes()
        {
            dgvClienteVenda.DataSource = myCliente.ExibirClientes();

            dgvClienteVenda.Columns[0].HeaderText = "CÓDIGO";
            dgvClienteVenda.Columns[1].HeaderText = "NOME";
            dgvClienteVenda.Columns[2].HeaderText = "SEXO";
            dgvClienteVenda.Columns[3].HeaderText = "CPF";
            dgvClienteVenda.Columns[4].HeaderText = "DATA\nNASCIMENTO";
            dgvClienteVenda.Columns[5].HeaderText = "TELEFONE";
            dgvClienteVenda.Columns[6].HeaderText = "E-MAIL";
            dgvClienteVenda.Columns[7].HeaderText = "RUA";
            dgvClienteVenda.Columns[8].HeaderText = "Nº";
            dgvClienteVenda.Columns[9].HeaderText = "COMPLEMENTO";
            dgvClienteVenda.Columns[10].HeaderText = "BAIRRO";
            dgvClienteVenda.Columns[11].HeaderText = "CEP";
            dgvClienteVenda.Columns[12].HeaderText = "CIDADE";
            dgvClienteVenda.Columns[13].HeaderText = "UF";

            dgvClienteVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClienteVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewCliente();
        }

        private void ExibirFuncionarios()
        {
            cboxFuncionarioVenda.DataSource = myFuncionario.ExibirFuncionario();

            cboxFuncionarioVenda.DisplayMember = "NM_Funcionario";
            cboxFuncionarioVenda.ValueMember = "ID_Funcionario";
        }

        private void ExibirProcedimento()
        {
            dgvProcedimentoVenda.DataSource = myProcedimento.ExibirProcedimento();

            dgvProcedimentoVenda.Columns[0].HeaderText = "CÓDIGO";
            dgvProcedimentoVenda.Columns[1].HeaderText = "CATEGORIA";
            dgvProcedimentoVenda.Columns[2].HeaderText = "PROCEDIMENTO";
            dgvProcedimentoVenda.Columns[3].Visible = false;

            dgvProcedimentoVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProcedimentoVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewProcedimento();
        }

        private void ExibirCategoriaBuscar()
        {
            cboxBuscarProcedimentoVenda.DataSource = myCategoria.ExibirCategoria();
            cboxBuscarProcedimentoVenda.DisplayMember = "NM_Categoria";
            cboxBuscarProcedimentoVenda.ValueMember = "ID_Categoria";
        }

        private void ExibirItemVenda()
        {
            dgvItemVenda.DataSource = myItemVenda.ExibirItemVenda(IDVenda);

            dgvItemVenda.Columns[1].Visible = false;
            dgvItemVenda.Columns[2].HeaderText = "CÓDIGO";
            dgvItemVenda.Columns[3].HeaderText = "CATEGORIA";
            dgvItemVenda.Columns[4].HeaderText = "PROCEDIMENTO";
            dgvItemVenda.Columns[5].Visible = false;
            dgvItemVenda.Columns[6].HeaderText = "SESSÕES";
            dgvItemVenda.Columns[7].HeaderText = "PREÇO VENDA";
            dgvItemVenda.Columns[8].HeaderText = "VALOR LUCRO";
            dgvItemVenda.Columns[9].HeaderText = "SUBTOTAL";

            dgvItemVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItemVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridViewItemVenda();
        }

        private void ExibirItemVendaFinalizar()
        {
            dgvItemVendaFinalizar.DataSource = myItemVenda.ExibirItemVenda(IDVenda);

            dgvItemVendaFinalizar.Columns[0].Visible = false;
            dgvItemVendaFinalizar.Columns[1].HeaderText = "CÓDIGO";
            dgvItemVendaFinalizar.Columns[2].HeaderText = "CATEGORIA";
            dgvItemVendaFinalizar.Columns[3].HeaderText = "PROCEDIMENTO";
            dgvItemVendaFinalizar.Columns[4].Visible = false;
            dgvItemVendaFinalizar.Columns[5].HeaderText = "SESSÕES";
            dgvItemVendaFinalizar.Columns[6].HeaderText = "PREÇO VENDA";
            dgvItemVendaFinalizar.Columns[7].HeaderText = "VALOR LUCRO";
            dgvItemVendaFinalizar.Columns[8].HeaderText = "SUBTOTAL";

            CalcularVenda();

            dgvItemVendaFinalizar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItemVendaFinalizar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void ValidarValorComZero(TextBox campo)
        {
            string valorcomzerovalido = Convert.ToString(campo.Text);
            myValidar.ValorComZero(valorcomzerovalido);

            if (myValidar.ValorValido == false)
            {
                errorIcone.SetError(campo, "Este campo deve ser preenchido somente com números, vírgulas e pontos." +
                                            "\nVerifique também a disposição dos números conforme Ex: 000.000,00");
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

        private void CalcularVenda()
        {
            double subtotalVenda = 0;
            double lucroVenda = 0;
            double totalVenda = 0;

            if (dgvItemVendaFinalizar.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvItemVendaFinalizar.Rows)
                {
                    subtotalVenda += Convert.ToDouble(row.Cells["PR_ItemVenda"].Value) * Convert.ToDouble(row.Cells["QTDE_Sessao"].Value);
                    lblSubtotalVendaFinalizar.Text = "Subtotal: R$" + subtotalVenda.ToString("N2");
                    ValorSubtotal = subtotalVenda;

                    lucroVenda += Convert.ToDouble(row.Cells["VL_Lucro"].Value) * Convert.ToDouble(row.Cells["QTDE_Sessao"].Value);
                    lblLucroVendaFinalizar.Text = "Lucro: R$" + lucroVenda.ToString("N2");
                    ValorLucro = lucroVenda;

                    totalVenda += Convert.ToDouble(row.Cells["VL_Subtotal"].Value);
                    lblTotalVendaFinalizar.Text = "Total: R$" + totalVenda.ToString("N2");
                    ValorTotal = totalVenda;
                }
            }
            else
            {
                lblSubtotalVendaFinalizar.Text = "Subtotal: R$0,00";
                lblLucroVendaFinalizar.Text = "Lucro: R$0,00";
                lblTotalVendaFinalizar.Text = "Total: R$0,00";
            }
        }

        private void CalcularSubtotalProcedimentoVenda()
        {
            if (txtPrecoVendaProcedimentoVenda.Text != string.Empty)
            {
                ValidarValorComZero(txtPrecoVendaProcedimentoVenda);
                if (myValidar.ValorValido == true)
                {
                    if (txtQuantidadeSessoesProcedimentoVenda.Text != string.Empty)
                    {
                        ValidarNumero(txtQuantidadeSessoesProcedimentoVenda);
                        if (myValidar.NumeroValido == true)
                        {
                            if (Convert.ToInt32(txtQuantidadeSessoesProcedimentoVenda.Text) >= 1)
                            {
                                txtSubtotalProcedimentoVenda.Text =
                                    (Convert.ToDouble(txtPrecoVendaProcedimentoVenda.Text) *
                                    Convert.ToInt32(txtQuantidadeSessoesProcedimentoVenda.Text)).ToString("N2");
                            }
                        }
                    }
                }
            }
        }

        private void CalcularSubtotalItemVenda()
        {
            if (txtPrecoVendaItemVenda.Text != string.Empty)
            {
                ValidarValorComZero(txtPrecoVendaItemVenda);
                if (myValidar.ValorValido == true)
                {
                    if (txtQuantidadeSessoesItemVenda.Text != string.Empty)
                    {
                        ValidarNumero(txtQuantidadeSessoesItemVenda);
                        if (myValidar.NumeroValido == true)
                        {
                            if (Convert.ToInt32(txtQuantidadeSessoesItemVenda.Text) >= 1)
                            {
                                txtSubtotalItemVenda.Text =
                                    (Convert.ToDouble(txtPrecoVendaItemVenda.Text) *
                                    Convert.ToInt32(txtQuantidadeSessoesItemVenda.Text)).ToString("N2");
                            }
                        }
                    }
                }
            }
        }

        public void ValidarVenda()
        {
            myVenda.ValidarVenda();
        }

        private void ViewVenda_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            ConfiguracoesDgv();
            HabilitarCamposFinalizarVenda(false);
            HabilitarCamposSelecionarProcedimentos(false);
            HabilitarCamposSelecionarCliente(false);
            LimparDadosVenda();
            LimparDadosProcedimentos();
            LimparDadosCliente();
            OcultarTabVenda();
            OcultarTabProcedimentos();
            dgvItemVendaFinalizar.DataSource = "";
            dgvItemVenda.DataSource = "";
            dgvProcedimentoVenda.DataSource = "";
            dgvClienteVenda.DataSource = "";
            cboxFuncionarioVenda.DataSource = null;
            BotoesCliente();
        }

        private void btnNovoVenda_Click(object sender, EventArgs e)
        {
            NovaVenda = true;
            EditarVenda = false;

            ValidarVenda();

            btnNovoVenda.Enabled = false;
            btnNovoVenda.BackColor = Color.Sienna;
            ExibirClientes();
            ExibirFuncionarios();
            HabilitarCamposSelecionarCliente(true);
            BotoesCliente();

            cboxFuncionarioVenda.Text = null;
        }

        private void cboxBuscarClienteVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBuscarClienteVenda.Text.Equals("Nome"))
            {
                txtBuscarCPFClienteVenda.Text = string.Empty;
                txtBuscarCPFClienteVenda.Visible = false;
                txtBuscarNomeClienteVenda.Visible = true;
                txtBuscarNomeClienteVenda.Text = string.Empty;
                errorIcone.SetError(txtBuscarNomeClienteVenda, string.Empty);
            }
            else if (cboxBuscarClienteVenda.Text.Equals("CPF"))
            {
                txtBuscarNomeClienteVenda.Visible = false;
                txtBuscarNomeClienteVenda.Text = string.Empty;
                txtBuscarCPFClienteVenda.Visible = true;
                txtBuscarCPFClienteVenda.Text = string.Empty;
                errorIcone.SetError(txtBuscarCPFClienteVenda, string.Empty);
            }
        }

        private void txtBuscarCPFClienteVenda_TextChanged(object sender, EventArgs e)
        {
            BuscarClienteVenda();
        }

        private void txtBuscarNomeClienteVenda_TextChanged(object sender, EventArgs e)
        {
            BuscarClienteVenda();
        }

        private void btnBuscarClienteVenda_Click(object sender, EventArgs e)
        {
            BuscarClienteVenda();
        }

        private void dgvClienteVenda_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["ID_Cliente"].Value);
            txtNomeClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NM_Cliente"].Value);
            txtNascimentoClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["DT_Nascimento"].Value);
            txtSexoClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["DS_Sexo"].Value);
            txtCPFClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NR_CPF"].Value);
            txtCEPClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NR_CEP"].Value);
            txtRuaClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NM_Rua"].Value);
            txtNumCasaClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NR_Casa"].Value);
            txtBairroClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NM_Bairro"].Value);
            txtComplementoClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["DS_Complemento"].Value);
            txtCidadeClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NM_Cidade"].Value);
            txtUFClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["DS_UF"].Value);
            txtTelefoneClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["NR_Telefone"].Value);
            txtEmailClienteVenda.Text = Convert.ToString(dgvClienteVenda.CurrentRow.Cells["DS_Email"].Value);

            btnConfirmarClienteVenda.Enabled = true;
            btnConfirmarClienteVenda.BackColor = Color.Wheat;
            btnAlterarClienteVenda.Enabled = true;
            btnAlterarClienteVenda.BackColor = Color.Wheat;
        }

        private void btnConfirmarClienteVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxFuncionarioVenda.Text == string.Empty)
                {
                    MensagemErro("Por favor, selecione o funcionário " +
                                 "\nresponsável por registrar a venda");

                    errorIcone.SetError(cboxFuncionarioVenda, "Por favor, selecione o funcionário " +
                                                            "\nresponsável por registrar a venda");
                }
                else
                {
                    errorIcone.SetError(cboxFuncionarioVenda, string.Empty);

                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Deseja selecionar o cliente:\n" + txtNomeClienteVenda.Text.ToUpper() + "\npara realizar a venda?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        TranferirDadosCliente();

                        btnAlterarClienteVenda.Enabled = false;
                        btnAlterarClienteVenda.BackColor = Color.Sienna;
                        btnConfirmarClienteVenda.Enabled = false;
                        btnConfirmarClienteVenda.BackColor = Color.Sienna;

                        HabilitarCamposSelecionarCliente(false);

                        NovaVenda = true;
                        EditarVenda = false;
                        InserirVenda();

                        MostrarTabProcedimentos();
                        ExibirProcedimento();
                        HabilitarCamposSelecionarProcedimentos(true);
                        cboxBuscarProcedimentoVenda.Enabled = false;
                        tctrlVenda.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAlterarClienteVenda_Click(object sender, EventArgs e)
        {
            LimparDadosCliente();
            cboxFuncionarioVenda.Text = string.Empty;

            btnAlterarClienteVenda.Enabled = false;
            btnAlterarClienteVenda.BackColor = Color.Sienna;
            btnConfirmarClienteVenda.Enabled = false;
            btnConfirmarClienteVenda.BackColor = Color.Sienna;
        }

        private void chkBuscarProcedimentoVenda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarProcedimentoVenda.Checked)
            {
                cboxBuscarProcedimentoVenda.Enabled = true;
                ExibirCategoriaBuscar();
                cboxBuscarProcedimentoVenda.Text = null;
            }
            else
            {
                cboxBuscarProcedimentoVenda.DataSource = null;
                cboxBuscarProcedimentoVenda.Enabled = false;

                if (txtBuscarProcedimentoVenda.Text != string.Empty)
                {
                    BuscarNomeProcedimento();
                }
                else
                {
                    ExibirProcedimento();
                }
            }
        }

        private void txtBuscarProcedimentoVenda_TextChanged(object sender, EventArgs e)
        {
            if (chkBuscarProcedimentoVenda.Checked && cboxBuscarProcedimentoVenda.Text != string.Empty)
            {
                BuscarProcedimento();
            }
            else
            {
                BuscarNomeProcedimento();
            }
        }

        private void btnBuscarProcedimentoVenda_Click(object sender, EventArgs e)
        {
            if (chkBuscarProcedimentoVenda.Checked && cboxBuscarProcedimentoVenda.Text != string.Empty && txtBuscarProcedimentoVenda.Text != string.Empty)
            {
                BuscarProcedimento();
            }
            else if (chkBuscarProcedimentoVenda.Checked && cboxBuscarProcedimentoVenda.Text != string.Empty)
            {
                BuscarCategoriaProcedimento();
            }
            else if (txtBuscarProcedimentoVenda.Text != string.Empty)
            {
                BuscarNomeProcedimento();
            }
            else
            {
                ExibirProcedimento();
            }
        }

        private void dgvProcedimentoVenda_DoubleClick(object sender, EventArgs e)
        {
            bool procedimentoInvalido = false;

            foreach (DataGridViewRow row in dgvItemVenda.Rows)
            {
                if (dgvProcedimentoVenda.CurrentRow.Cells["NM_Procedimento"].Value.Equals(row.Cells["NM_Procedimento"].Value))
                {
                    MensagemErro("Este procedimento já foi adicionado na venda");
                    LimparDadosProcedimentos();
                    procedimentoInvalido = true;
                }
            }

            if (procedimentoInvalido == false)
            {
                txtCodigoProcedimentoVenda.Text = Convert.ToString(dgvProcedimentoVenda.CurrentRow.Cells["ID_Procedimento"].Value);
                txtCategoriaProcedimentoVenda.Text = Convert.ToString(dgvProcedimentoVenda.CurrentRow.Cells["NM_Categoria"].Value);
                txtProcedimentoVenda.Text = Convert.ToString(dgvProcedimentoVenda.CurrentRow.Cells["NM_Procedimento"].Value);
                txtDescricaoProcedimentoVenda.Text = Convert.ToString(dgvProcedimentoVenda.CurrentRow.Cells["DS_Procedimento"].Value);

                txtDescricaoProcedimentoVenda.Enabled = true;
                txtDescricaoProcedimentoVenda.ReadOnly = true;
                txtPrecoVendaProcedimentoVenda.Enabled = true;
                txtValorLucroProcedimentoVenda.Enabled = true;
                txtQuantidadeSessoesProcedimentoVenda.Enabled = true;

                btnCancelarProcedimentoVenda.Enabled = true;
                btnCancelarProcedimentoVenda.BackColor = Color.Wheat;
                btnConfirmarProcedimentoVenda.Enabled = true;
                btnConfirmarProcedimentoVenda.BackColor = Color.Wheat;
            }
        }

        private void btnConfirmarProcedimentoVenda_Click(object sender, EventArgs e)
        {
            bool PrecoVendaProcedimentoVendaOK = false;
            bool ValorLucroProcedimentoVendaOK = false;
            bool QuantidadeSessoesProcedimentoVendaOK = false;

            ValidarCampoNulo(txtPrecoVendaProcedimentoVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarValorComZero(txtPrecoVendaProcedimentoVenda);
                if (myValidar.ValorValido == true)
                {
                    PrecoVendaProcedimentoVendaOK = true;
                }
            }

            ValidarCampoNulo(txtValorLucroProcedimentoVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarValorComZero(txtValorLucroProcedimentoVenda);
                if (myValidar.ValorValido == true)
                {
                    ValorLucroProcedimentoVendaOK = true;
                }
            }

            ValidarCampoNulo(txtQuantidadeSessoesProcedimentoVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarNumero(txtQuantidadeSessoesProcedimentoVenda);
                if (myValidar.NumeroValido == true)
                {
                    if (Convert.ToInt32(txtQuantidadeSessoesProcedimentoVenda.Text) < 1)
                    {
                        errorIcone.SetError(txtQuantidadeSessoesProcedimentoVenda, "A quantidade de sessões não pode ser" +
                                                                                "\nmenor ou igual a 0 (zero)");
                    }
                    else
                    {
                        errorIcone.SetError(txtQuantidadeSessoesProcedimentoVenda, string.Empty);
                        QuantidadeSessoesProcedimentoVendaOK = true;
                    }
                }
            }

            if (PrecoVendaProcedimentoVendaOK == false ||
                ValorLucroProcedimentoVendaOK == false ||
                QuantidadeSessoesProcedimentoVendaOK == false)
            {
                MensagemErro("Por favor, preencha corretamente os campos sinalizados");
            }
            else
            {
                errorIcone.Clear();
                NovaVenda = true;
                EditarVenda = false;

                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja adicionar este procedimento na venda?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        InserirItemVenda();

                        LimparDadosProcedimentos();
                        btnConfirmarProcedimentoVenda.Enabled = false;
                        btnConfirmarProcedimentoVenda.BackColor = Color.Sienna;
                        btnCancelarProcedimentoVenda.Enabled = false;
                        btnCancelarProcedimentoVenda.BackColor = Color.Sienna;
                        txtPrecoVendaProcedimentoVenda.Enabled = false;
                        txtValorLucroProcedimentoVenda.Enabled = false;
                        txtQuantidadeSessoesProcedimentoVenda.Enabled = false;
                        txtDescricaoProcedimentoVenda.Enabled = false;
                        chkExcluirItemVenda.Enabled = true;

                        CalcularVenda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnCancelarProcedimentoVenda_Click(object sender, EventArgs e)
        {
            errorIcone.SetError(txtPrecoVendaProcedimentoVenda, string.Empty);
            errorIcone.SetError(txtValorLucroProcedimentoVenda, string.Empty);
            errorIcone.SetError(txtQuantidadeSessoesProcedimentoVenda, string.Empty);

            LimparDadosProcedimentos();
            txtPrecoVendaProcedimentoVenda.Enabled = false;
            txtValorLucroProcedimentoVenda.Enabled = false;
            txtQuantidadeSessoesProcedimentoVenda.Enabled = false;
            txtDescricaoProcedimentoVenda.Enabled = false;
            btnConfirmarProcedimentoVenda.Enabled = false;
            btnConfirmarProcedimentoVenda.BackColor = Color.Sienna;
            btnCancelarProcedimentoVenda.Enabled = false;
            btnCancelarProcedimentoVenda.BackColor = Color.Sienna;
        }

        private void chkExcluirItemVenda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExcluirItemVenda.Checked)
            {
                dgvItemVenda.Columns[0].Visible = true;
                btnExcluirItemVenda.Enabled = true;
                btnExcluirItemVenda.BackColor = Color.Wheat;
            }
            else
            {
                dgvItemVenda.Columns[0].Visible = false;
                btnExcluirItemVenda.Enabled = false;
                btnExcluirItemVenda.BackColor = Color.Sienna;
            }
        }

        private void btnExcluirItemVenda_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;

            foreach (DataGridViewRow row in dgvItemVenda.Rows)
            {
                if (bool.Parse(row.Cells[0].EditedFormattedValue.ToString()))
                {
                    marcouitem = true;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há itens selecionados para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja excluir o item da venda?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Venda;
                        int Procedimento;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvItemVenda.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Venda = Convert.ToInt32(row.Cells[1].Value);
                                Procedimento = Convert.ToInt32(row.Cells[2].Value);
                                resp = myItemVenda.ExcluirItemVenda(Venda, Procedimento);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Item excluído com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        chkExcluirItemVenda.Checked = false;
                        ExibirItemVenda();
                        CalcularVenda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dgvItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItemVenda.Columns["ExcluirItemCompra"].Index)
            {
                DataGridViewCheckBoxCell ChkExcluir = (DataGridViewCheckBoxCell)dgvItemVenda.Rows[e.RowIndex].Cells["ExcluirItemCompra"];
                ChkExcluir.Value = !Convert.ToBoolean(ChkExcluir.Value);
            }
        }

        private void dgvItemVenda_DoubleClick(object sender, EventArgs e)
        {
            txtCodigoItemVenda.Text = Convert.ToString(dgvItemVenda.CurrentRow.Cells["ID_Procedimento"].Value);
            txtCategoriaItemVenda.Text = Convert.ToString(dgvItemVenda.CurrentRow.Cells["NM_Categoria"].Value);
            txtItemVenda.Text = Convert.ToString(dgvItemVenda.CurrentRow.Cells["NM_Procedimento"].Value);
            txtDescricaoItemVenda.Text = Convert.ToString(dgvItemVenda.CurrentRow.Cells["DS_Procedimento"].Value);
            txtPrecoVendaItemVenda.Text = (Convert.ToDouble(dgvItemVenda.CurrentRow.Cells["PR_ItemVenda"].Value)).ToString("N2");
            txtValorLucroItemVenda.Text = (Convert.ToDouble(dgvItemVenda.CurrentRow.Cells["VL_Lucro"].Value)).ToString("N2");
            txtQuantidadeSessoesItemVenda.Text = Convert.ToString(dgvItemVenda.CurrentRow.Cells["QTDE_Sessao"].Value);
            txtSubtotalItemVenda.Text = (Convert.ToDouble(dgvItemVenda.CurrentRow.Cells["VL_Subtotal"].Value)).ToString("N2");

            txtDescricaoItemVenda.Enabled = true;
            txtDescricaoItemVenda.ReadOnly = true;
            txtPrecoVendaItemVenda.Enabled = true;
            txtValorLucroItemVenda.Enabled = true;
            txtQuantidadeSessoesItemVenda.Enabled = true;

            btnCancelarItemVenda.Enabled = true;
            btnCancelarItemVenda.BackColor = Color.Wheat;
            btnEditarItemVenda.Enabled = true;
            btnEditarItemVenda.BackColor = Color.Wheat;
        }

        private void btnEditarItemVenda_Click(object sender, EventArgs e)
        {
            bool PrecoVendaItemVendaOK = false;
            bool ValorLucroItemVendaOK = false;
            bool QuantidadeSessoesItemVendaOK = false;

            ValidarCampoNulo(txtPrecoVendaItemVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarValorComZero(txtPrecoVendaItemVenda);
                if (myValidar.ValorValido == true)
                {
                    PrecoVendaItemVendaOK = true;
                }
            }

            ValidarCampoNulo(txtValorLucroItemVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarValorComZero(txtValorLucroItemVenda);
                if (myValidar.ValorValido == true)
                {
                    ValorLucroItemVendaOK = true;
                }
            }

            ValidarCampoNulo(txtQuantidadeSessoesItemVenda);
            if (myValidar.CampoValido == true)
            {
                ValidarNumero(txtQuantidadeSessoesItemVenda);
                if (myValidar.NumeroValido == true)
                {
                    if (Convert.ToInt32(txtQuantidadeSessoesItemVenda.Text) < 1)
                    {
                        errorIcone.SetError(txtQuantidadeSessoesItemVenda, "A quantidade de sessões não pode ser" +
                                                                        "\nmenor ou igual a 0 (zero)");
                    }
                    else
                    {
                        QuantidadeSessoesItemVendaOK = true;
                    }
                }
            }

            if (PrecoVendaItemVendaOK == false ||
                ValorLucroItemVendaOK == false ||
                QuantidadeSessoesItemVendaOK == false)
            {
                MensagemErro("Por favor, preencha corretamente os campos sinalizados");
            }
            else
            {
                errorIcone.Clear();
                NovaVenda = false;
                EditarVenda = true;

                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja editar este procedimento na venda?",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        InserirItemVenda();

                        LimparDadosItemVenda();
                        btnEditarItemVenda.Enabled = false;
                        btnEditarItemVenda.BackColor = Color.Sienna;
                        btnCancelarItemVenda.Enabled = false;
                        btnCancelarItemVenda.BackColor = Color.Sienna;
                        txtPrecoVendaItemVenda.Enabled = false;
                        txtValorLucroItemVenda.Enabled = false;
                        txtQuantidadeSessoesItemVenda.Enabled = false;
                        txtDescricaoItemVenda.Enabled = false;
                        chkExcluirItemVenda.Enabled = true;

                        CalcularVenda();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnCancelarItemVenda_Click(object sender, EventArgs e)
        {
            errorIcone.SetError(txtPrecoVendaItemVenda, string.Empty);
            errorIcone.SetError(txtQuantidadeSessoesItemVenda, string.Empty);

            LimparDadosItemVenda();
            txtPrecoVendaItemVenda.Enabled = false;
            txtValorLucroItemVenda.Enabled = false;
            txtQuantidadeSessoesItemVenda.Enabled = false;
            txtDescricaoItemVenda.Enabled = false;

            btnEditarItemVenda.Enabled = false;
            btnEditarItemVenda.BackColor = Color.Sienna;
            btnCancelarItemVenda.Enabled = false;
            btnCancelarItemVenda.BackColor = Color.Sienna;
        }

        private void btnRealizarPagamentoVenda_Click(object sender, EventArgs e)
        {
            if (dgvItemVenda.Rows.Count == 0)
            {
                MensagemErro("Não há nenhum item na venda");
            }
            else
            {
                btnRealizarPagamentoVenda.Enabled = false;
                btnRealizarPagamentoVenda.BackColor = Color.Sienna;
                MostrarTabVenda();
                HabilitarCamposFinalizarVenda(true);
                tctrlVenda.SelectedIndex = 2;

                ExibirItemVendaFinalizar();
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja cancelar esta venda? \nTodos os dados serão excluídos.",
                "Studio Carol Cruz",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                NovaVenda = false;
                EditarVenda = false;
                HabilitarCamposFinalizarVenda(false);
                HabilitarCamposSelecionarProcedimentos(false);
                HabilitarCamposSelecionarCliente(false);
                LimparDadosVenda();
                LimparDadosProcedimentos();
                LimparDadosCliente();
                OcultarTabVenda();
                OcultarTabProcedimentos();
                dgvItemVendaFinalizar.DataSource = "";
                dgvItemVenda.DataSource = "";
                dgvProcedimentoVenda.DataSource = "";
                dgvClienteVenda.DataSource = "";
                cboxFuncionarioVenda.DataSource = null;
                BotoesCliente();

                tctrlVenda.SelectedIndex = 0;
            }
        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            ExibirItemVendaFinalizar();

            if (dgvItemVendaFinalizar.Rows.Count < 1)
            {
                MensagemErro("Não há nenhum item na venda");
            }
            else
            {
                bool ObservacoesVendaFinalizarOK = false;
                bool TipoPagamentoVendaFinalizarOK = false;

                if (txtObservacoesVendaFinalizar.Text != string.Empty)
                {
                    ValidarTamanhoCampo(txtObservacoesVendaFinalizar, 1500);
                    if (myValidar.TamanhoValido == true)
                    {
                        ObservacoesVendaFinalizarOK = true;
                    }
                }

                if (cboxTipoPagamentoVendaFinalizar.Text == string.Empty)
                {
                    errorIcone.SetError(cboxTipoPagamentoVendaFinalizar, "Selecione o método de pagamento");
                }
                else
                {
                    errorIcone.SetError(cboxTipoPagamentoVendaFinalizar, string.Empty);
                    TipoPagamentoVendaFinalizarOK = true;
                }


                if (ObservacoesVendaFinalizarOK == false ||
                    TipoPagamentoVendaFinalizarOK == false)
                {
                    MensagemErro("Por favor, preencha corretamente os campos sinalizados");
                }
                else
                {
                    errorIcone.Clear();
                    ExibirItemVendaFinalizar();

                    NovaVenda = false;
                    EditarVenda = true;

                    if (InserirVenda() == true)
                    {
                        if (InserirSessao() == true)
                        {
                            NovaVenda = false;
                            EditarVenda = false;
                            HabilitarCamposFinalizarVenda(false);
                            HabilitarCamposSelecionarProcedimentos(false);
                            HabilitarCamposSelecionarCliente(false);
                            LimparDadosVenda();
                            LimparDadosProcedimentos();
                            LimparDadosCliente();
                            OcultarTabVenda();
                            OcultarTabProcedimentos();
                            dgvItemVendaFinalizar.DataSource = "";
                            dgvItemVenda.DataSource = "";
                            dgvProcedimentoVenda.DataSource = "";
                            dgvClienteVenda.DataSource = "";
                            cboxFuncionarioVenda.DataSource = null;
                            BotoesCliente();

                            tctrlVenda.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void btnAtualizarItemVendaFinalizar_Click(object sender, EventArgs e)
        {
            dgvItemVendaFinalizar.DataSource = "";

            ExibirItemVendaFinalizar();
        }

        private void txtPrecoVendaProcedimentoVenda_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotalProcedimentoVenda();
        }

        private void txtQuantidadeSessoesProcedimentoVenda_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotalProcedimentoVenda();
        }

        private void txtPrecoVendaItemVenda_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotalItemVenda();
        }

        private void txtQuantidadeSessoesItemVenda_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotalItemVenda();
        }

        private void txtDescricaoProcedimentoVenda_MouseHover(object sender, EventArgs e)
        {
            ttmesagem.SetToolTip(txtDescricaoProcedimentoVenda, txtDescricaoProcedimentoVenda.Text);
        }

        private void txtDescricaoItemVenda_MouseHover(object sender, EventArgs e)
        {
            ttmesagem.SetToolTip(txtDescricaoItemVenda, txtDescricaoItemVenda.Text);
        }
    }
}
