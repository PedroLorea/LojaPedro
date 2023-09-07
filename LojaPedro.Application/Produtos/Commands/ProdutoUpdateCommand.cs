namespace LojaPedro.Application.Produtos.Commands
{
    public class ProdutoUpdateCommand : ProdutoCommand
    {
        public int Id { get; set; }

        public ProdutoUpdateCommand(int id)
        {
            Id = id;
        }
    }
}
