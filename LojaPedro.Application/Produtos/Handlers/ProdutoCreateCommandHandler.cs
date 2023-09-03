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
    public class ProdutoCreateCommandHandler : IRequestHandler<ProdutoCreateCommand, Produto>
    {

        private readonly IProdutoRepository _produtoRepository;
        public ProdutoCreateCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> Handle(ProdutoCreateCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Nome, request.Descricao, request.Preco,
                                    request.Estoque, request.Imagem);

            if(produto == null)
            {
                throw new ApplicationException($"Erro ao criar entidade");
            } 
            else
            {
                produto.CategoriaId = request.CategoriaId;
                return await _produtoRepository.CreateAsync(produto);
            }
        }
    }
}
