using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{
public abstract class AbsPropriedades
    {
    public List<string> Usuarios { get; set; } = new List<string>();
    public List<string> Senhas { get; set; } = new List<string>();

        public Dictionary<string, bool> Respostas { get; private set; }



        public AbsPropriedades()
        {
            
        }

       



        public AbsPropriedades(List<string> usuarios, List<string> senhas)
        {
        Usuarios = usuarios;
        Senhas = senhas;
        }

       
    }
}

