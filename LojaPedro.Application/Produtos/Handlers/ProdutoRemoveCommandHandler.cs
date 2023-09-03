using LojaPedro.Application.Produtos.Commands;
using LojaPedro.Domain;
using LojaPedro.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LojaPedro.Application.Produtos.Handlers
{
    public class ProdutoRemoveCommandHandler : IRequestHandler<ProdutoRemoveCommand, Produto>
    {

        private readonly IProdutoRepository _produtoRepository;
        
        public ProdutoRemoveCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ??
                throw new ArgumentNullException(nameof(produtoRepository));
        }

        public async Task<Produto> Handle(ProdutoRemoveCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.GetIdAsync(request.Id);

            if (produto == null)
            {
                throw new ApplicationException($"Entidade não foi encontrada");
            }
            else
            {
                var result = await _produtoRepository.RemoveAsync(produto);
                return result;
            }
        }
    }
}
