using PIM_3_TOTEN.Backend;
using System;
using System.Windows.Forms;

namespace PIM_3_TOTEN
{
    public partial class Login : Form
    {
        private Controle controle;

        private TextBox focusedTextBox;

        private int notaAvaliacao = 0;

        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;
        private static Dictionary<string, bool> respostas1Persistidas;

        public Login(Controle controle, Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4, int notaAvaliacao)
        {
            InitializeComponent();
            this.controle = controle ?? throw new ArgumentNullException(nameof(controle));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.respostas = respostas;
        }

        private void btn_loguin_Click(object sender, EventArgs e)
        {
            string usuario = txb_NomeUsuario.Text;
            string senha = txb_Senha.Text;

            if (!Validacao.ValidarEntrada(usuario, senha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (controle.ValidarLogin(usuario, senha))
            {
                MessageBox.Show("Login realizado com sucesso!");


                Exposições espocições = new Exposições(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
                espocições.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastrar = new Cadastro(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            cadastrar.Show();
            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            iniciar.Show();
            this.Hide();
        }

        private void A_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void txb_Senha_Enter(object sender, EventArgs e)
        {
            focusedTextBox = txb_Senha;
        }

        private void txb_NomeUsuario_Enter(object sender, EventArgs e)
        {
            focusedTextBox = txb_NomeUsuario;
        }

        private void Q_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void W_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void R_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void T_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void Y_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void U_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void I_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void O_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void S_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void G_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }

        }

        private void H_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void J_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void K_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void Ç_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }

        }

        private void Z_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void V_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void N_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (focusedTextBox != null && focusedTextBox.Text.Length > 0)
            {
                focusedTextBox.Text = focusedTextBox.Text.Substring(0, focusedTextBox.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && focusedTextBox != null)
            {
                focusedTextBox.Text += btn.Text;
            }
        }
    }
}

