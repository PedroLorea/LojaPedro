using FluentAssertions;
using System;
using Xunit;

namespace LojaPedro.Domain.Tests
{
    public class ProdutoUnitTest1
    {
        [Fact]
        public void CriarProduto_ComParametrosValidos_ResultadoEstadoValidoObjeto()
        {
            Action action = () => new Produto(1, "Nome Produto", "Desc", 9.99m, 10, "imagem");
            action.Should()
                .NotThrow<LojaPedro.Domain.Validacao.DomainExceptionValidation>();
        }
    }
}
