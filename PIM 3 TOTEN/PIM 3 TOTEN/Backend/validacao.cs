using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{


    public class Validacao : AbsPropriedades
    {

       
        public static bool ValidarEntrada(string usuario, string senha)
        {
            return !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha);
        }

       
    }
}
