using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IDB_AUX
{

//    nr_requisicao int not null auto_increment,
//cod_gerente int not null,
//cod_produto int not null, 
//data_requisicao timestamp default now(), 
 
    class requisicao_model
    {
        public string Nr_requisicao { get; set; }
        public string Cod_gerente { get; set; }
        public string Cod_produto { get; set; }
        public string Data_rquisicao { get; set; }

        public requisicao_model(string nr_requisicao,string cod_gerente,string cod_produto,string data_requisicao)
        {
            Nr_requisicao = nr_requisicao; Cod_gerente = cod_gerente; Cod_produto = cod_produto; Data_rquisicao = data_requisicao;
        }
    }
}
