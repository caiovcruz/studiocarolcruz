using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class ViewMenu : Form
    {
        private IconButton iconBtn;
        private Panel pnlLeft;
        private Form frmAtual;

        public ViewMenu()
        {
            InitializeComponent();

            pnlLeft = new Panel();
            pnlLeft.Size = new Size(7, 45);
            pnlMenuLateral.Controls.Add(pnlLeft);
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;

            WindowState = FormWindowState.Maximized;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(251, 68, 68); //VERMELHO CLARO
        }

        private void desativaBtn()
        {
            if (iconBtn != null)
            {
                iconBtn.BackColor = Color.FromArgb(75, 40, 10);
                iconBtn.ForeColor = Color.White;
                iconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                iconBtn.IconColor = Color.White;
                iconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
        }

        private void ativaBtn(object senderBtn, Color color)
        {
            desativaBtn();

            iconBtn = (IconButton)senderBtn;
            iconBtn.BackColor = Color.FromArgb(37, 36, 81);
            iconBtn.ForeColor = color;
            iconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            iconBtn.IconColor = color;
            iconBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            pnlLeft.BackColor = color;
            pnlLeft.Location = new Point(0, iconBtn.Location.Y);
            pnlLeft.Visible = true;
            pnlLeft.BringToFront();
            iconeFrmFilho.IconChar = iconBtn.IconChar;
            iconeFrmFilho.IconColor = Color.White;
        }

        private void abrirFormulario(Form frmFilho)
        {
            if (frmAtual != null)
            {
                frmAtual.Close();
            }

            frmAtual = frmFilho;
            frmFilho.TopLevel = false;
            frmFilho.FormBorderStyle = FormBorderStyle.None;
            frmFilho.Dock = DockStyle.Fill;
            pnlView.Controls.Add(frmFilho);
            pnlView.Tag = frmFilho;
            frmFilho.BringToFront();
            frmFilho.Show();
            lblTituloFrmFilho.Text = frmFilho.Text;
        }

        private void reiniciarFrm()
        {
            desativaBtn();
            pnlLeft.Visible = false;
            iconeFrmFilho.IconChar = IconChar.Home;
            iconeFrmFilho.IconColor = Color.White;
            lblTituloFrmFilho.Text = "Início";
        }

        private void pboxLogo_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            pnlView.Controls.Add(lblHora);
            pnlView.Controls.Add(lblData);

            reiniciarFrm();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show(
                "Realmente deseja fechar o programa ?",
                "Studio Carol Cruz",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToString("dd : MMMM : yyyy");
        }

        private void btnViewCliente_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewCliente());
        }

        private void btnViewVenda_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewVenda());
        }

        private void btnViewRelatorio_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewRelatorio());
        }

        private void btnViewProcedimento_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewProcedimento());
        }

        private void btnViewProduto_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewProduto());
        }

        private void btnViewCategoria_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewCategoria());
        }

        private void btnViewCompra_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewCompra());
        }

        private void btnViewFuncionario_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewFuncionario());
        }

        private void btnViewLogin_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewLogin());
        }

        private void btnViewSessao_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewSessao());
        }

        private void btnViewBaixaEstoque_Click(object sender, EventArgs e)
        {
            pnlView.Controls.Clear();

            ativaBtn(sender, RGBcolors.color1);
            abrirFormulario(new ViewBaixaEstoque());
        }

        private void ViewMenu_Load(object sender, EventArgs e)
        {
            using (ViewRealizarLogin myLogin = new ViewRealizarLogin())
            {
                this.Visible = false;
                DialogResult = myLogin.ShowDialog();
                if (myLogin.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    this.Visible = true;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show(
                "Realmente deseja retornar a tela de login?",
                "Studio Carol Cruz",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Opcao == DialogResult.Yes)
            {
                using (ViewRealizarLogin myLogin = new ViewRealizarLogin())
                {
                    this.Visible = false;
                    DialogResult = myLogin.ShowDialog();
                    if (myLogin.DialogResult != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        this.Visible = true;
                    }
                }
            }
        }
    }
}
