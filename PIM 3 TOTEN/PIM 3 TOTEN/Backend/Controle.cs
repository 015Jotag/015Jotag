using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3_TOTEN.Backend
{
    public class Controle : AbsPropriedades
    {
        private Dictionary<string, bool> respostas;
        private Dictionary<string, bool> respostas2;
        private Dictionary<string, bool> respostas3;
        private Dictionary<string, bool> respostas4;

        public Controle(Dictionary<string, bool> respostas, Dictionary<string, bool> respostas2, Dictionary<string, bool> respostas3, Dictionary<string, bool> respostas4)
        {
            this.respostas = respostas;
            this.respostas2 = respostas2;
            this.respostas3 = respostas3;
            this.respostas4 = respostas4;
        }


        public bool Cadastro(string usuario, string senha)
            {
                if (Usuarios.Contains(usuario))
                {
                    return false; // Usuário já existe
                }

                Usuarios.Add(usuario);
                Senhas.Add(senha);
                return true; // Cadastro realizado com sucesso
            }

            public bool ValidarLogin(string usuario, string senha)
            {
                int index = Usuarios.IndexOf(usuario);
                if (index >= 0 && Senhas[index] == senha)
                {
                    return true; // Login válido
                }

                return false; // Login inválido
            }
        }
    }

   
