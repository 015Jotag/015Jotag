using PIM_3_TOTEN.Backend;
using System;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PIM_3_TOTEN
{
    public partial class Iniciar : Form
    {
        private Controle controle;

        private int notaAvaliacao = 0;

        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;
        private static Dictionary<string, bool> respostas1Persistidas;
        public Iniciar(Controle controle, Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4, int notaAvaliacao)
        {
            InitializeComponent();
            this.controle = controle ?? throw new ArgumentNullException(nameof(controle));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Location = new Point(0, 0);
            this.respostas = respostas;
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Login loguin = new Login(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            loguin.Show();
            this.Hide();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

