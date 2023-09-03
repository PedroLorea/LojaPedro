using LojaPedro.Domain;
using MediatR;

namespace LojaPedro.Application.Produtos.Commands
{
    public class ProdutoRemoveCommand : IRequest<Produto>
    {
        public int Id { get; set; }
        public ProdutoRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
