using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PIM_3_TOTEN
{
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();

            this.Text = "Formulario Centralizado";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Btn_Iniciar_Click(object sender, EventArgs e)
        {

            Loguin loguin = new Loguin();
            loguin.Show();
            this.Hide();

        }

       }

   }
    