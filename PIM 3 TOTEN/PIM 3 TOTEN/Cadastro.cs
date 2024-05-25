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

namespace PIM_3_TOTEN
{
    public partial class Cadastro : Form
    {

        

        private Controle controle;






        public Cadastro()
        {
            InitializeComponent();

            this.controle = controle;
        }

            private void lbl_cadastro_Click(object sender, EventArgs e)
        {
            Loguin loguin = new Loguin();

            loguin.ShowDialog();

            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Iniciar iniciar = new Iniciar();

            iniciar.ShowDialog();

            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            string usuario = txb_NomeUsuario.Text;
            string senha = txb_Senha.Text;

            if (controle.Cadastrar(usuario, senha))
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                txb_NomeUsuario.Text = "";
                txb_Senha.Text = "";

                Loguin loguin = new Loguin();

                loguin.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário já existe!");
            }
        }
    }

}

