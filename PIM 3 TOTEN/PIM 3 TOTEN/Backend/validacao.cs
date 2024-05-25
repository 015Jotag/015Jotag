using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{
    internal abstract class validacao : AbsPropriedades
    {
        protected validacao(int tamanho) : base(tamanho)
        {
        }

        public bool Login(string usuario, string senha)
        {

            for (int i = 0; i < contador; i++)
            {
                if (usuarios[i] == usuario && senhas[i] == senha)
                {
                    return true; // Login bem sucedido
                }
            }
            return false; // Usuário ou senha inválidos
        }
    }
}


