using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface ICartaService
    {
        Task<IEnumerable<CartaViewModel>> ObterTodos();

        void Adicionar(NovaCartaViewModel novaCartaViewModel);
    }
}
