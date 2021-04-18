using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IDB_AUX
{
    class Cliente_Model
    {





        public string Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Bairro { get; set; }
        public string Avenida { get; set; }
        public string Nome { get; set; }
       

        public Cliente_Model(string id, string nome,string bairro,string avenida, string telefone, string email)
        {
            Id = id;
            Email = email;
            Telefone = telefone;
            Nome = nome;
            Bairro = bairro;
            Avenida = avenida;
        }
    }
}
