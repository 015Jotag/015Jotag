using PIM_3_TOTEN.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_3_TOTEN
{
    public partial class Resultado : Form
    {
        private Controle controle;

        private int notaAvaliacao = 0;

        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;






        public Resultado(Controle controle, Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4, int notaAvaliacao)
        {
            InitializeComponent();
            this.controle = controle ?? throw new ArgumentNullException(nameof(controle));
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Location = new Point(0, 0);
            this.respostas = respostas;
            this.respostas2 = respostas2;
            this.respostas3 = respostas3;
            this.respostas4 = respostas4;
            this.notaAvaliacao = notaAvaliacao;


            PreencherLabels();
        }

        private void PreencherLabels()
        {

            {
                int labelTop = 57;
                Label labelNotaAvaliacao = new Label();
                labelNotaAvaliacao.Text = $"Nota de Avaliação: {notaAvaliacao}";
                labelNotaAvaliacao.Height = 120;
                labelNotaAvaliacao.Width = 230;
                labelNotaAvaliacao.Location = new Point(605, labelTop);
                labelNotaAvaliacao.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                labelNotaAvaliacao.BackColor = Color.Transparent;
                labelNotaAvaliacao.ForeColor = Color.White;
                Controls.Add(labelNotaAvaliacao);
                labelTop += 120;

                if (respostas != null && respostas.Any())
                {


                    foreach (var resposta in respostas)
                    {
                        {
                            Label labelPergunta = new Label();
                            labelPergunta.Height = 70;
                            labelPergunta.Width = 300;
                            labelPergunta.Text = $"{resposta.Key}: {(resposta.Value ? "Sim" : "Não")}";
                            labelPergunta.Location = new Point(605, labelTop);
                            labelPergunta.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                            labelPergunta.BackColor = Color.Transparent;
                            labelPergunta.ForeColor = Color.White;
                            Controls.Add(labelPergunta);
                            labelTop += 90;
                        }
                    }
                }
                else
                {
                    Label labelNenhumaResposta = new Label();
                    labelNenhumaResposta.Text = "Nenhuma resposta encontrada.";
                    labelNenhumaResposta.Location = new Point(20, 20);
                    Controls.Add(labelNenhumaResposta);
                }
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            Exposições exposições = new Exposições(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao);
            exposições.Show();
            this.Hide();
        }
    }
}
