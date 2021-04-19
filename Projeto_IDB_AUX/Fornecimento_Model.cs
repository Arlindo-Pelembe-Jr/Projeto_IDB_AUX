using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IDB_AUX
{
    class Fornecimento_Model
    {

        public string Cod_forn { get; set; }
        public string Cod_prod { get; set; }
        public string Quantidade { get; set; }



        public Fornecimento_Model(string cod_forn, string cod_prod, string quantidade)
        {
             Cod_forn = cod_forn; Cod_prod = cod_prod; Quantidade = quantidade; 
        }
    }
}
