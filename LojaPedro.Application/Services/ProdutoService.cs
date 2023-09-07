using AutoMapper;
using LojaPedro.Application.DTOs;
using LojaPedro.Application.Interfaces;
using LojaPedro.Application.Produtos.Commands;
using LojaPedro.Application.Produtos.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaPedro.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProdutoService(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            var produtosQuery = new GetProdutosQuery();

            if (produtosQuery == null) throw new Exception($"Entidade não foi carregada");

            var result = await _mediator.Send(produtosQuery);

            return _mapper.Map<IEnumerable<ProdutoDTO>>(result);

        }

        public async Task<ProdutoDTO> GetById(int? id)
        {
            var produtoByIdQuery = new GetProdutoByIdQuery(id.Value);

            if (produtoByIdQuery == null) throw new Exception($"Entidade não foi carregada");

            var result = await _mediator.Send(produtoByIdQuery);

            return _mapper.Map<ProdutoDTO>(result);
        }

        public async Task<ProdutoDTO> GetProdutoCategoria(int? id)
        {
            var produtoByIdQuery = new GetProdutoByIdQuery(id.Value);

            if (produtoByIdQuery == null) throw new Exception($"Entidade não foi carregada");

            var result = await _mediator.Send(produtoByIdQuery);

            return _mapper.Map<ProdutoDTO>(result);
        }

        public async Task Add(ProdutoDTO produtoDTO)
        {
            var produtoCreateCommand = _mapper.Map<ProdutoCreateCommand>(produtoDTO);
            await _mediator.Send(produtoCreateCommand);
        }

        public async Task Update(ProdutoDTO produtoDTO)
        {
            var produtoUpdateCommand = _mapper.Map<ProdutoUpdateCommand>(produtoDTO);
            await _mediator.Send(produtoUpdateCommand);
        }

        public async Task Remove(int? id)
        {
            var produtoRemoveCommand = new ProdutoRemoveCommand(id.Value);
            
            if (produtoRemoveCommand == null) throw new Exception($"Entidade não foi carregada");

            await _mediator.Send(produtoRemoveCommand);


        }
    }
}
