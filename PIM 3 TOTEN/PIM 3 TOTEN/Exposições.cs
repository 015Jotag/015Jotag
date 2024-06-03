using PIM_3_TOTEN.Backend;
using PIM_3_TOTEN.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_3_TOTEN
{
    public partial class Exposições : Form
    {
        private Controle controle;

        private int notaAvaliacao = 0;


        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;
        
        public Exposições(Controle controle, Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4, int notaAvaliacao)
        {
            InitializeComponent();
            this.controle = controle ?? throw new ArgumentNullException(nameof(controle));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Location = new Point(0, 0);
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = this.Height;
            vScrollBar1.LargeChange = this.ClientSize.Height;
            vScrollBar1.SmallChange = 20;
            this.respostas = respostas;
            this.respostas2 = respostas2;
            this.respostas3 = respostas3;
            this.respostas4 = respostas4;
        }

        private void btn_avaliar1_Click(object sender, EventArgs e)
        {
            Avaliacao avaliacao = new Avaliacao(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            avaliacao.Show();
            this.Hide();
        }

        private void btn_avaliar2_Click(object sender, EventArgs e)
        {
            Avaliacao2 avaliacao2 = new Avaliacao2(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            avaliacao2.Show();
            this.Hide();

        }

        private void btn_avaliar3_Click(object sender, EventArgs e)
        {
            Avaliacao3 avaliacao3 = new Avaliacao3(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            avaliacao3.Show();
            this.Hide();
        }

        private void btn_avaliar4_Click(object sender, EventArgs e)
        {
            Avaliacao3 avaliacao3 = new Avaliacao3(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            avaliacao3.Show();
            this.Hide();
        }

        private void Btn_sair_Click_1(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            iniciar.ShowDialog();
            this.Hide();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.AutoScrollPosition = new System.Drawing.Point(0, e.NewValue);
        }
    }

}

