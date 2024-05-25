using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{
    internal abstract class AbsPropriedades
    {
        protected string[] usuarios;
        protected string[] senhas;
        protected int contador;

        protected AbsPropriedades(int tamanho)
        {
            usuarios = new string[tamanho];
            senhas = new string[tamanho];
            contador = 0;
        }
    }
}
