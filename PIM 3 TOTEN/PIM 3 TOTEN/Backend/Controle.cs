using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{
    internal abstract class Controle : AbsPropriedades
    {
        public Controle(int tamanho) : base(tamanho)
        {
        }


        public bool Cadastrar(string usuario, string senha)
        {
        
            for (int i = 0; i < contador; i++)
            {
                if (usuarios[i] == usuario)
                {
                    return false;
                }
            }

           
            usuarios[contador] = usuario;
            senhas[contador] = senha;
            contador++;
            return true;
        }
    }
}
   
