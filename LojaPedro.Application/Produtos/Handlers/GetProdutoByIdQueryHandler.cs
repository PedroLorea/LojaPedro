using LojaPedro.Application.Produtos.Queries;
using LojaPedro.Domain;
using LojaPedro.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LojaPedro.Application.Produtos.Handlers
{
    public class GetProdutoByIdQueryHandler : IRequestHandler<GetProdutoByIdQuery, Produto>
    {

        private readonly IProdutoRepository _produtoRepository;

        public GetProdutoByIdQueryHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ??
                throw new ArgumentNullException(nameof(produtoRepository));
        }

        public async Task<Produto> Handle(GetProdutoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetIdAsync(request.Id);
        }
    }
}
