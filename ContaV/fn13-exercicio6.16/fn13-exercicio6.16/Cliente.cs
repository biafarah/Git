using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fn13_exercicio6._16
{
    public class Cliente
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            else
            {
                return false;    
            }
        }
    }
}
