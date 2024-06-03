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
using RadioButton = System.Windows.Forms.RadioButton;

namespace PIM_3_TOTEN
{
    public partial class Avaliacao2 : Form
    {

        private Controle controle;

        private int notaAvaliacao = 0;

        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;



        public Avaliacao2(Controle controle, Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4, int notaAvaliacao)
        {
            InitializeComponent();
            InicializarRespostas();
            this.controle = controle ?? throw new ArgumentNullException(nameof(controle));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Location = new Point(0, 0);
        }

        private void InicializarRespostas()
        {

            respostas = new Dictionary<string, bool>
            {
                { "Pergunta 1", false },
                { "Pergunta 2", false },
                { "Pergunta 3", false },
                { "Pergunta 4", false }

            };
        }

        private void AtualizarResposta(string pergunta, bool resposta)
        {

            respostas[pergunta] = resposta;
        }

        private bool TodasRespondidas()
        {
            foreach (System.Windows.Forms.Control control in Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton)
                {
                    if (radioButton.Tag is string pergunta)
                    {
                        if (!respostas.ContainsKey(pergunta) || !radioButton.Checked)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private void AtualizarRadioButtonResposta(object sender, bool resposta)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                string pergunta = radioButton.Tag as string;
                if (pergunta != null)
                {
                    AtualizarResposta(pergunta, resposta);
                }
                else
                {
                    MessageBox.Show("Tag do RadioButton não definida ou é nula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void RbSim_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, true);
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, false);
        }

        private void RbSim2_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, true);
        }

        private void RbNao2_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, false);
        }

        private void RbSim3_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, true);
        }

        private void RbNao3_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, false);
        }

        private void RbSim4_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, true);
        }

        private void RbNao4_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, false);
        }

        private void RbSim5_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, true);
        }

        private void RbNao5_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarRadioButtonResposta(sender, false);
        }

        private void Btn_Avaliar2_Click(object sender, EventArgs e)
        {
            if (TodasRespondidas())
            {
                RespostasData.Respostas = respostas;

                Resultado resultado = new Resultado(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
                resultado.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, responda todas as perguntas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notaAvaliacao = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notaAvaliacao = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            notaAvaliacao = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notaAvaliacao = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notaAvaliacao = 5;
        }
    }
}


