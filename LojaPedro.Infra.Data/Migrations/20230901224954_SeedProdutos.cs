using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaPedro.Infra.Data.Migrations
{
    public partial class SeedProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, Estoque, Imagem, CategoriaId) " +
                "VALUES('Dell Inspiron', 'All in One', 9.500, '5', 'dell1.jpg', 1 )");

            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, Estoque, Imagem, CategoriaId) " +
                "VALUES('Teclado Razer', 'Mecânico', 800, '23', 'teclado1.jpg', 2 )");

            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, Estoque, Imagem, CategoriaId) " +
                "VALUES('Teclado Hp', 'Soft Touch', 300, '10', 'teclado2.jpg', 2 )");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
