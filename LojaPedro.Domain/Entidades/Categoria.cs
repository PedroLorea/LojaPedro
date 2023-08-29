using LojaPedro.Domain.Entidades;
using LojaPedro.Domain.Validacao;
using System.Collections.Generic;


namespace LojaPedro.Domain
{
    public sealed class Categoria : Entidade
    {
        public string Nome { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        public Categoria(string nome)
        {
            ValidarDominio(nome);
        }

        public Categoria(int id, string nome)
        {
            DomainExceptionValidation.Quando(id < 0, "Valor de Id inválido.");
            Id = id;
            ValidarDominio(nome);
        }

        public void Atualizar(string nome)
        {
            ValidarDominio(nome);
        }

        private void ValidarDominio(string nome)
        {
            DomainExceptionValidation.Quando(string.IsNullOrEmpty(nome), "Nome inválido");

            DomainExceptionValidation.Quando(nome.Length < 3, "Minimo 3 caracteres");

            Nome = nome;
        }

    }
}
