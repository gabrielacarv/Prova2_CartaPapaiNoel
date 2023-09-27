using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{
			CreateMap<CartaViewModel, Carta>()
			   .ConstructUsing(c => new Carta(c.Nome, c.Endereco, c.Idade, c.Conteudo));

			CreateMap<NovaCartaViewModel, Carta>()
			   .ConstructUsing(c => new Carta(c.Nome, c.Endereco, c.Idade, c.Conteudo));
        }
	}
}
