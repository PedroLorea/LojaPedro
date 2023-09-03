using LojaPedro.Application.Produtos.Queries;
using LojaPedro.Domain;
using LojaPedro.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LojaPedro.Application.Produtos.Handlers
{
    public class GetProdutosQueryHandler : IRequestHandler<GetProdutosQuery, IEnumerable<Produto>>
    {
        private readonly IProdutoRepository _produtoRepository;

        public GetProdutosQueryHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ??
                throw new ArgumentNullException(nameof(produtoRepository));
        }

        public async Task<IEnumerable<Produto>> Handle(GetProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetProdutosAsync();
        }
    }
}
