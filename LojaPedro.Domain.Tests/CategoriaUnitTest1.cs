using FluentAssertions;
using System;
using Xunit;

namespace LojaPedro.Domain.Tests
{
    public class CategoriaUnitTest1
    {
        [Fact(DisplayName = "Criar Categoria com Parametros Validos")]
        public void CriarCategoria_ComParametrosValidos_ResultadoEstadoValidoObjeto()
        {
            Action action = () => new Categoria(1, "Nome Categoria");
            action.Should()
                .NotThrow<LojaPedro.Domain.Validacao.DomainExceptionValidation>();

        }

        [Fact]
        public void CriarCategoria_ComIdInvalido_DomainExceptionIdInvalido()
        {
            Action action = () => new Categoria(-1, "Nome Categoria");
            action.Should().Throw<LojaPedro.Domain.Validacao.DomainExceptionValidation>()
                .WithMessage("Valor de Id inválido.");

        }
    }
}
