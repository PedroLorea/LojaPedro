using LojaPedro.Application.Produtos.Commands;
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
    public class ProdutoUpdateCommandHandler : IRequestHandler<ProdutoUpdateCommand, Produto>
    {

        private readonly IProdutoRepository _produtoRepository;
        public ProdutoUpdateCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ??
                throw new ArgumentNullException(nameof(produtoRepository));
        }

        public async Task<Produto> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.GetIdAsync(request.Id);

            if(produto == null)
            {
                throw new ApplicationException($"Entidade não foi encontrada");
            }
            else
            {
                produto.Atualizar(request.Nome, request.Descricao, request.Preco,
                                    request.Estoque, request.Imagem, request.CategoriaId);

                return await _produtoRepository.UpdateAsync(produto);
            }
        }
    }
}
