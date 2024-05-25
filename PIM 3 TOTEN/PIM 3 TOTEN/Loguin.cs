using PIM_3_TOTEN.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PIM_3_TOTEN
{
    public partial class Loguin : Form
    {

        private validacao validacao;

        public Loguin(string[] usuarios, string[] senhas, int contador)
        {
            InitializeComponent();
            this.validacao = validacao;
        }

        public Loguin()
        {
            InitializeComponent();

            this.Text = "Formulario Centralizado";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loguin_Load(object sender, EventArgs e)
        {


        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.ShowDialog();

            this.Hide();
        }

        private void btn_loguin_Click(object sender, EventArgs e)
        {

            string usuario = txb_NomeUsuario.Text;
            string senha = txb_Senha.Text;

            if (validacao.Login(usuario, senha))
            {
                MessageBox.Show("Login bem sucedido!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");




            }
        }

      
   

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar();

            iniciar.ShowDialog();

            this.Hide();

        }
    }
}
