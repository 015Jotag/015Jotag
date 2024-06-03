using PIM_3_TOTEN.Backend;


namespace PIM_3_TOTEN
{

    internal static class Program
    {

        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int notaAvaliacao = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dictionary<string, bool> respostas = new Dictionary<string, bool>();
            Dictionary<string, bool> respostas2 = new Dictionary<string, bool>();
            Dictionary<string, bool> respostas3 = new Dictionary<string, bool>();
            Dictionary<string, bool> respostas4 = new Dictionary<string, bool>();

            
            Controle controle = new Controle(respostas, respostas2, respostas3, respostas4);
            Application.Run(new Iniciar(controle, respostas, respostas2, respostas3, respostas4, notaAvaliacao));
        }
    }
}