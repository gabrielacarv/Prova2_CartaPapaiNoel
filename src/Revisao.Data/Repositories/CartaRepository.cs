using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {

        #region Construtores

        private readonly string _cartaCaminhoArquivo;

        public CartaRepository()
        {
            _cartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "carta.json");
        }
        #endregion

        #region Funções do Arquivo      
        public Task<IEnumerable<Carta>> ObterTodos()
        {
            List<Carta> cartas = LerCartasDoArquivo();
            return Task.FromResult<IEnumerable<Carta>>(cartas);
        }

        public void Adicionar(Carta novaCarta)
        {
            //List<Produto> produtos = new List<Produto>();
            List<Carta> cartas = LerCartasDoArquivo();
            cartas.Add(novaCarta);
            EscreverCartasNoArquivo(cartas);
        }
        #endregion

        #region Métodos do Arquivo
        private List<Carta> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartaCaminhoArquivo))
            {
                return new List<Carta>();
            }

            string json = System.IO.File.ReadAllText(_cartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Carta>>(json);
        }

        private void EscreverCartasNoArquivo(List<Carta> cartas)
        {
            string json = JsonConvert.SerializeObject(cartas);
            System.IO.File.WriteAllText(_cartaCaminhoArquivo, json);
        }
        #endregion
    }
}
