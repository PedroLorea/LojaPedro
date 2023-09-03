using LojaPedro.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPedro.Application.Produtos.Commands
{
    public abstract class ProdutoCommand : IRequest<Produto>
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string Imagem { get; set; }

        public int CategoriaId { get; set; }
    }
}
