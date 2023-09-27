using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Carta
    {
        public string Nome { get; private set; }
        public List<Endereco> Endereco { get; private set; }
        public int Idade { get; private set; }
        public string Conteudo { get; private set; }

        public Carta(string nome, List<Endereco> endereco, int idade, string conteudo)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            Conteudo = conteudo;
        }
    }
}
