using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia_PCSHARP_MZ
{
    class Produto_Model
    {

        public string Id { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto_Model(string id,string categoria, string nome, double preco)
        {
            Id = id;
            Categoria = categoria;
            Nome = nome;
            Preco = preco;
        }

    }
}
