using AutoMapper;
using LojaPedro.Application.DTOs;
using LojaPedro.Application.Produtos.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPedro.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProdutoDTO, ProdutoCreateCommand>();
            CreateMap<ProdutoDTO, ProdutoUpdateCommand>();
        }
        
    }
}
