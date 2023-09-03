using LojaPedro.Domain.Entidades;
using LojaPedro.Domain.Validacao;

namespace LojaPedro.Domain
{
    public sealed class Produto : Entidade
    {
        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public decimal Preco { get; private set; }

        public int Estoque { get; private set; }

        public string Imagem { get; private set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public Produto(string nome, string descricao, decimal preco, int estoque, string imagem)
        {
            ValidarDominio(nome, descricao, preco, estoque, imagem);
        }

        public Produto(int id, string nome, string descricao, decimal preco, int estoque, string imagem)
        {
            DomainExceptionValidation.Quando(id < 0, "Valor de Id inválido");
            Id = id;
            ValidarDominio(nome, descricao, preco, estoque, imagem);
        }

        public void Atualizar(string nome, string descricao, decimal preco, int estoque, string imagem, int categoriaId)
        {
            ValidarDominio(nome, descricao, preco, estoque, imagem);
            CategoriaId = categoriaId;
        }

        private void ValidarDominio(string nome, string descricao, decimal preco, int estoque, string imagem)
        {
            DomainExceptionValidation.Quando(string.IsNullOrEmpty(nome), "Nome inválido");

            //Fazer as validações dos outros atributos

            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Imagem = imagem;
        }

    }
}
