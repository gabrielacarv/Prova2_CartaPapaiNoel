using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartaService : ICartaService
    {
        #region Construtores
        private readonly ICartaRepository _cartaRepository;
        private IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }
        #endregion

        #region Funções
        public void Adicionar(NovaCartaViewModel novaCartaViewModel)
        {
            var novoProduto = _mapper.Map<Carta>(novaCartaViewModel);
            _cartaRepository.Adicionar(novoProduto);
        }
        public async Task<IEnumerable<CartaViewModel>> ObterTodos()
        {
            var cartas = await _cartaRepository.ObterTodos();
            return _mapper.Map<IEnumerable<CartaViewModel>>(cartas);
        }
        #endregion
    }
}
