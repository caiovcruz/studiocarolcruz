using Control;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace View
{
    public partial class ViewRelatorio : Form
    {
        ControlVenda myVenda = new ControlVenda();
        ControlItemVenda myItemVenda = new ControlItemVenda();
        ControlFuncionario myFuncionario = new ControlFuncionario();

        public ViewRelatorio()
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

        private void ExibirVendaRelatorio()
        {
            dgvVendaRelatorio.DataSource = myVenda.ExibirVendaAno();
        }

        private void AtualizarGrafico()
        {
            ConfiguracoesGrafico();

            ExibirVendaRelatorio();

            if (dgvVendaRelatorio.Rows.Count > 0)
            {
                bool GerouGrafico = false;

                double vendaJaneiro = 0;
                double lucroJaneiro = 0;

                double vendaFevereiro = 0;
                double lucroFevereiro = 0;

                double vendaMarco = 0;
                double lucroMarco = 0;

                double vendaAbril = 0;
                double lucroAbril = 0;

                double vendaMaio = 0;
                double lucroMaio = 0;

                double vendaJunho = 0;
                double lucroJunho = 0;

                double vendaJulho = 0;
                double lucroJulho = 0;

                double vendaAgosto = 0;
                double lucroAgosto = 0;

                double vendaSetembro = 0;
                double lucroSetembro = 0;

                double vendaOutubro = 0;
                double lucroOutubro = 0;

                double vendaNovembro = 0;
                double lucroNovembro = 0;

                double vendaDezembro = 0;
                double lucroDezembro = 0;

                DateTime janeiro = new DateTime(DateTime.Today.Year, 01, 01);
                DateTime fevereiro = new DateTime(DateTime.Today.Year, 02, 01);
                DateTime marco = new DateTime(DateTime.Today.Year, 03, 01);
                DateTime abril = new DateTime(DateTime.Today.Year, 04, 01);
                DateTime maio = new DateTime(DateTime.Today.Year, 05, 01);
                DateTime junho = new DateTime(DateTime.Today.Year, 06, 01);
                DateTime julho = new DateTime(DateTime.Today.Year, 07, 01);
                DateTime agosto = new DateTime(DateTime.Today.Year, 08, 01);
                DateTime setembro = new DateTime(DateTime.Today.Year, 09, 01);
                DateTime outubro = new DateTime(DateTime.Today.Year, 10, 01);
                DateTime novembro = new DateTime(DateTime.Today.Year, 11, 01);
                DateTime dezembro = new DateTime(DateTime.Today.Year, 12, 01);

                foreach (DataGridViewRow row in dgvVendaRelatorio.Rows)
                {
                    DateTime data = Convert.ToDateTime(row.Cells["DT_Venda"].Value);

                    if (Convert.ToString(data.Year) == cboxAnoGrafico.Text)
                    {
                        GerouGrafico = true;

                        if (data.Month == janeiro.Month)
                        {
                            vendaJaneiro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroJaneiro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == fevereiro.Month)
                        {
                            vendaFevereiro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroFevereiro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == marco.Month)
                        {
                            vendaMarco += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroMarco += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == abril.Month)
                        {
                            vendaAbril += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroAbril += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == maio.Month)
                        {
                            vendaMaio += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroMaio += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == junho.Month)
                        {
                            vendaJunho += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroJunho += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == julho.Month)
                        {
                            vendaJulho += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroJulho += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == agosto.Month)
                        {
                            vendaAgosto += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroAgosto += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == setembro.Month)
                        {
                            vendaSetembro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroSetembro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == outubro.Month)
                        {
                            vendaOutubro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroOutubro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == novembro.Month)
                        {
                            vendaNovembro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroNovembro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                        else if (data.Month == dezembro.Month)
                        {
                            vendaDezembro += Convert.ToDouble(row.Cells["VL_Total"].Value);
                            lucroDezembro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
                        }
                    }
                }

                if (GerouGrafico)
                {
                    chtGrafico.Series[0].Points.AddXY("Janeiro", vendaJaneiro);
                    chtGrafico.Series[1].Points.AddY(lucroJaneiro);

                    chtGrafico.Series[0].Points.AddXY("Fevereiro", vendaFevereiro);
                    chtGrafico.Series[1].Points.AddY(lucroFevereiro);

                    chtGrafico.Series[0].Points.AddXY("Março", vendaMarco);
                    chtGrafico.Series[1].Points.AddY(lucroMarco);

                    chtGrafico.Series[0].Points.AddXY("Abril", vendaAbril);
                    chtGrafico.Series[1].Points.AddY(lucroAbril);

                    chtGrafico.Series[0].Points.AddXY("Maio", vendaMaio);
                    chtGrafico.Series[1].Points.AddY(lucroMaio);

                    chtGrafico.Series[0].Points.AddXY("Junho", vendaJunho);
                    chtGrafico.Series[1].Points.AddY(lucroJunho);

                    chtGrafico.Series[0].Points.AddXY("Julho", vendaJulho);
                    chtGrafico.Series[1].Points.AddY(lucroJulho);

                    chtGrafico.Series[0].Points.AddXY("Agosto", vendaAgosto);
                    chtGrafico.Series[1].Points.AddY(lucroAgosto);

                    chtGrafico.Series[0].Points.AddXY("Setembro", vendaSetembro);
                    chtGrafico.Series[1].Points.AddY(lucroSetembro);

                    chtGrafico.Series[0].Points.AddXY("Outubro", vendaOutubro);
                    chtGrafico.Series[1].Points.AddY(lucroOutubro);

                    chtGrafico.Series[0].Points.AddXY("Novembro", vendaNovembro);
                    chtGrafico.Series[1].Points.AddY(lucroNovembro);

                    chtGrafico.Series[0].Points.AddXY("Dezembro", vendaDezembro);
                    chtGrafico.Series[1].Points.AddY(lucroDezembro);


                    double totalVenda = vendaJaneiro + vendaFevereiro + vendaMarco + vendaAbril + vendaMaio + vendaJunho +
                        vendaJulho + vendaAgosto + vendaSetembro + vendaOutubro + vendaNovembro + vendaDezembro;
                    lblValorTotalVendaRelatorio.Text = "R$" + totalVenda.ToString("N2");

                    double totalLucro = lucroJaneiro + lucroFevereiro + lucroMarco + lucroAbril + lucroMaio + lucroJunho +
                        lucroJulho + lucroAgosto + lucroSetembro + lucroOutubro + lucroNovembro + lucroDezembro;
                    lblValorTotalLucroRelatorio.Text = "R$" + totalLucro.ToString("N2");
                }
                else
                {
                    lblValorTotalVendaRelatorio.Text = "R$0,00";
                    lblValorTotalLucroRelatorio.Text = "R$0,00";
                }
            }
        }

        private void ConfiguracoesGrafico()
        {
            chtGrafico.ChartAreas.Clear();
            chtGrafico.ChartAreas.Add("ChartAreas1");
            chtGrafico.Series.Clear();
            chtGrafico.Series.Add("Venda");
            chtGrafico.Series.Add("Lucro");

            chtGrafico.Titles[0].Font = new Font("Century Gothic", 14, FontStyle.Bold);
            chtGrafico.Titles[0].Text = "Gráfico de Venda & Lucro\nAno: " + cboxAnoGrafico.Text;

            chtGrafico.Series[0].LabelBackColor = Color.White;
            chtGrafico.Series[0].Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chtGrafico.Series[0].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chtGrafico.Series[0].Color = Color.Green;
            chtGrafico.Series[0].BackSecondaryColor = Color.PaleGreen;
            chtGrafico.Series[0].IsValueShownAsLabel = true;

            chtGrafico.Series[1].LabelBackColor = Color.White;
            chtGrafico.Series[1].Font = new Font("Century Gothic", 10, FontStyle.Regular);
            chtGrafico.Series[1].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chtGrafico.Series[1].Color = Color.Blue;
            chtGrafico.Series[1].BackSecondaryColor = Color.LightSkyBlue;
            chtGrafico.Series[1].IsValueShownAsLabel = true;
        }

        private void PreencherComboBox()
        {
            for (int i = 2020; i <= DateTime.Today.Year; i++)
            {
                cboxAnoGrafico.Items.Add(i);
            }

            cboxAnoGrafico.Text = Convert.ToString(DateTime.Today.Year);
        }

        private void OcultarColunaExcluir()
        {
            dgvVenda.Columns[0].Visible = false;
        }

        private void HabilitarDataGridView()
        {
            if (dgvVenda.Rows.Count == 0)
            {
                chkExcluirVenda.Enabled = false;
                btnExcluirVenda.Enabled = false;
                btnExcluirVenda.BackColor = Color.Sienna;
                dgvVenda.Enabled = false;
            }
            else
            {
                chkExcluirVenda.Enabled = true;
                btnExcluirVenda.Enabled = true;
                btnExcluirVenda.BackColor = Color.Wheat;
                dgvVenda.Enabled = true;
            }
        }

        private void ConfiguracoesDgv()
        {
            dgvVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvVenda.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);

            dgvListaItemVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvListaItemVenda.RowsDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Regular);
        }

        private void ExibirVenda()
        {
            dgvVenda.DataSource = myVenda.ExibirVendaMes();
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            dgvVenda.Columns[1].HeaderText = "CÓDIGO";
            dgvVenda.Columns[2].HeaderText = "DATA\nVENDA";
            dgvVenda.Columns[3].HeaderText = "FUNCIONÁRIO";
            dgvVenda.Columns[4].HeaderText = "CLIENTE";
            dgvVenda.Columns[5].HeaderText = "OBSERVAÇÕES";
            dgvVenda.Columns[6].HeaderText = "MÉTODO\nPAGAMENTO";
            dgvVenda.Columns[7].HeaderText = "SUBTOTAL";
            dgvVenda.Columns[8].HeaderText = "LUCRO";
            dgvVenda.Columns[9].HeaderText = "TOTAL";

            dgvVenda.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            HabilitarDataGridView();
        }

        private void ExibirFuncionario()
        {
            cboxBuscarFuncionarioVenda.DataSource = myFuncionario.ExibirFuncionario();
            cboxBuscarFuncionarioVenda.DisplayMember = "NM_Funcionario";
            cboxBuscarFuncionarioVenda.ValueMember = "ID_Funcionario";
        }

        private void BuscarVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarVenda(
                dtInicioBuscar.Value, 
                dtFinalBuscar.Value.AddDays(1),
                txtBuscarClienteVenda.Text, 
                Convert.ToInt32(cboxBuscarFuncionarioVenda.SelectedValue.ToString()));
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarDataVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarDataVenda(dtInicioBuscar.Value, dtFinalBuscar.Value.AddDays(1));
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarClienteVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarClienteVenda(txtBuscarClienteVenda.Text);
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarFuncionarioVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarFuncionarioVenda(Convert.ToInt32(cboxBuscarFuncionarioVenda.SelectedValue.ToString()));
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarDataClienteVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarDataClienteVenda(
                dtInicioBuscar.Value,
                dtFinalBuscar.Value.AddDays(1),
                txtBuscarClienteVenda.Text);
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarDataFuncionarioVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarDataFuncionarioVenda(
                dtInicioBuscar.Value,
                dtFinalBuscar.Value.AddDays(1),
                Convert.ToInt32(cboxBuscarFuncionarioVenda.SelectedValue.ToString()));
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void BuscarFuncionarioClienteVenda()
        {
            dgvVenda.DataSource = myVenda.BuscarFuncionarioClienteVenda(
                Convert.ToInt32(cboxBuscarFuncionarioVenda.SelectedValue.ToString()),
                txtBuscarClienteVenda.Text);
            OcultarColunaExcluir();
            lblTotalVenda.Text = "Total de Vendas: " + Convert.ToString(dgvVenda.Rows.Count);

            double valorVenda = 0;
            double valorLucro = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                valorVenda += Convert.ToDouble(row.Cells["VL_Total"].Value);
                valorLucro += Convert.ToDouble(row.Cells["VL_Lucro"].Value);
            }

            lblValorTotalVenda.Text = "R$" + valorVenda.ToString("N2");
            lblValorTotalLucro.Text = "R$" + valorLucro.ToString("N2");

            HabilitarDataGridView();
        }

        private void HabilitarBuscar(bool Valor)
        {
            dtInicioBuscar.Value = DateTime.Today;
            dtFinalBuscar.Value = DateTime.Today;

            dtInicioBuscar.Enabled = Valor;
            dtFinalBuscar.Enabled = Valor;
        }

        private void ViewRelatorio_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            myVenda.ValidarVenda();
            AtualizarGrafico();
            PreencherComboBox();
            ConfiguracoesDgv();
            ExibirVenda();
            HabilitarBuscar(false);

            cboxBuscarFuncionarioVenda.Enabled = false;
        }

        private void cboxGrafico3D_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxGrafico3D.Checked)
            {
                chtGrafico.ChartAreas[0].Area3DStyle.Enable3D = true;
                chtGrafico.ChartAreas[0].Area3DStyle.Rotation = 5;
            }
            else
            {
                chtGrafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }

        private void cboxAnoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrafico();
        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVenda.Columns["Excluir"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dgvVenda.Rows[e.RowIndex].Cells["Excluir"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }

            dgvListaItemVenda.DataSource = myItemVenda.ExibirItemVenda(
                Convert.ToInt32(dgvVenda.CurrentRow.Cells["ID_Venda"].Value));
            lblTotalItemCompra.Text = "Total de Itens: " + Convert.ToString(dgvListaItemVenda.Rows.Count);

            lblValorTotalVendaItemVenda.Text = "R$" + Convert.ToString(dgvVenda.CurrentRow.Cells["VL_Total"].Value);
            lblValorTotalLucroItemVenda.Text = "R$" + Convert.ToString(dgvVenda.CurrentRow.Cells["VL_Lucro"].Value);

            dgvListaItemVenda.Columns[0].Visible = false;
            dgvListaItemVenda.Columns[1].Visible = false;
            dgvListaItemVenda.Columns[2].HeaderText = "CATEGORIA";
            dgvListaItemVenda.Columns[3].HeaderText = "PROCEDIMENTO";
            dgvListaItemVenda.Columns[4].Visible = false;
            dgvListaItemVenda.Columns[5].HeaderText = "SESSÕES";
            dgvListaItemVenda.Columns[6].HeaderText = "PREÇO VENDA";
            dgvListaItemVenda.Columns[7].HeaderText = "VALOR LUCRO";
            dgvListaItemVenda.Columns[8].HeaderText = "SUBTOTAL";

            dgvListaItemVenda.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvListaItemVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaItemVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void tctrlRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tctrlRelatorio.SelectedIndex == 0)
            {
                AtualizarGrafico();
            }
        }

        private void chkBuscarVenda_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkBuscarVenda.Checked)
            {
                HabilitarBuscar(true);
            }
            else
            {
                HabilitarBuscar(false);

                if (cboxBuscarFuncionarioVenda.Text != string.Empty && txtBuscarClienteVenda.Text != string.Empty)
                {
                    BuscarFuncionarioClienteVenda();
                }
                else if (txtBuscarClienteVenda.Text != string.Empty)
                {
                    BuscarClienteVenda();
                }
                else if (cboxBuscarFuncionarioVenda.Text != string.Empty)
                {
                    BuscarFuncionarioVenda();
                }
                else
                {
                    ExibirVenda();
                }
            }
        }

        private void chkBuscarFuncionarioVenda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuscarFuncionarioVenda.Checked)
            {
                cboxBuscarFuncionarioVenda.Enabled = true;
                ExibirFuncionario();
                cboxBuscarFuncionarioVenda.Text = null;
            }
            else
            {
                cboxBuscarFuncionarioVenda.DataSource = null;
                cboxBuscarFuncionarioVenda.Enabled = false;

                if (chkBuscarVenda.Checked && txtBuscarClienteVenda.Text != string.Empty)
                {
                    BuscarDataClienteVenda();
                }
                else if (chkBuscarVenda.Checked)
                {
                    BuscarDataVenda();
                }
                else if (txtBuscarClienteVenda.Text != string.Empty)
                {
                    BuscarClienteVenda();
                }
                else
                {
                    ExibirVenda();
                }
            }
        }

        private void btnBuscarVenda_Click_1(object sender, EventArgs e)
        {
            if (chkBuscarVenda.Checked && cboxBuscarFuncionarioVenda.Text != string.Empty && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarVenda();
            }
            else if (chkBuscarVenda.Checked && cboxBuscarFuncionarioVenda.Text != string.Empty)
            {
                BuscarDataFuncionarioVenda();
            }
            else if (chkBuscarVenda.Checked && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarDataClienteVenda();
            }
            else if (cboxBuscarFuncionarioVenda.Text != string.Empty && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarFuncionarioClienteVenda();
            }
            else if (chkBuscarVenda.Checked)
            {
                BuscarDataVenda();
            }
            else if (txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarClienteVenda();
            }
            else if (cboxBuscarFuncionarioVenda.Text != string.Empty)
            {
                BuscarFuncionarioVenda();
            }
            else
            {
                ExibirVenda();
            }
        }

        private void txtBuscarClienteVenda_TextChanged_1(object sender, EventArgs e)
        {
            if (chkBuscarVenda.Checked && cboxBuscarFuncionarioVenda.Text != string.Empty && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarVenda();
            }
            else if (chkBuscarVenda.Checked && cboxBuscarFuncionarioVenda.Text != string.Empty)
            {
                BuscarDataFuncionarioVenda();
            }
            else if (chkBuscarVenda.Checked && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarDataClienteVenda();
            }
            else if (cboxBuscarFuncionarioVenda.Text != string.Empty && txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarFuncionarioClienteVenda();
            }
            else if (chkBuscarVenda.Checked)
            {
                BuscarDataVenda();
            }
            else if (txtBuscarClienteVenda.Text != string.Empty)
            {
                BuscarClienteVenda();
            }
            else if (cboxBuscarFuncionarioVenda.Text != string.Empty)
            {
                BuscarFuncionarioVenda();
            }
            else
            {
                ExibirVenda();
            }
        }

        private void chkExcluirVenda_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkExcluirVenda.Checked)
            {
                dgvVenda.Columns[0].Visible = true;
            }
            else
            {
                dgvVenda.Columns[0].Visible = false;

                foreach (DataGridViewRow row in dgvVenda.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            bool marcouitem = false;
            int quantidadeCheckada = 0;

            foreach (DataGridViewRow row in dgvVenda.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    marcouitem = true;
                    quantidadeCheckada++;
                }
            }

            if (!marcouitem)
            {
                MensagemErro("Não há venda(s) selecionada(s) para excluir");
            }
            else
            {
                try
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show(
                        "Realmente deseja excluir " + quantidadeCheckada + " venda(s)?" +
                        "\n\nObs.: Esta ação impactará na confiabilidade de seus relatórios",
                        "Studio Carol Cruz",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (Opcao == DialogResult.Yes)
                    {
                        int Codigo;
                        string resp = "";

                        foreach (DataGridViewRow row in dgvVenda.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                resp = myVenda.ExcluirVenda(Codigo);
                            }
                        }

                        if (resp.Equals("OK"))
                        {
                            MensagemOk("Venda(s) excluída(s) com sucesso");
                        }
                        else
                        {
                            MensagemErro(resp);
                        }

                        ExibirVenda();
                        chkExcluirVenda.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
