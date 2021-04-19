using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IDB_AUX
{
    class pedido_model
    {

        public string Pedido_cod { get; set; }
        public string Cod_gerente { get; set; }
        public string Cod_cliente { get; set; }
        public string Data_pedido { get; set; }
        public string Quantidade { get; set; }

        public string Data_entrega { get; set; }


        public pedido_model(string pedido_cod, string cod_gerente, string cod_cliente, string data_pedido,string quantidade,string data_entrega)
        {
            Pedido_cod = pedido_cod; Cod_gerente = cod_gerente; Cod_cliente = cod_cliente; Data_pedido = data_pedido;
            Quantidade = quantidade; Data_entrega = data_entrega;
        }
    }
}
