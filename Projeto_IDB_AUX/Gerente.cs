using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_IDB_AUX
{
    class Gerente
    {

        public string Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string Nome { get; set; }
        public string Senha { get; set; }

        public Gerente(string id, string email,string telefone,string nome, string senha)
        {
            Id = id;
            Email = email;
            Telefone = telefone;
            Nome = nome;
            Senha = senha;
        }
    }
}
