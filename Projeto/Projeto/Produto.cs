using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class Produto
    {
        public string Nome { get; set; }
        public string Funcionalidade { get; set; }
        public string Validade { get; set; }
        public string Origem { get; set; }
        public string Quantidade { get; set; }
        public string Marca { get; set; }
        public string FaixaEtaria { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public Produto()
        { 
        
        }

        public Produto(string nome, string validade, string marca)
        {
            this.Nome = nome;
            this.Validade = validade;
            this.Marca = marca;
            
        }
    }
}
