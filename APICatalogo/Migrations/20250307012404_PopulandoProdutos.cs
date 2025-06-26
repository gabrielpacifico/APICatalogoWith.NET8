using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                                " values ('Coca Cola Zero', 'Refrigerante de Cola Zero calorias 350ml', 4.50, 'cocacola.jpg', 24, now(), 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                                " values ('Torta mista', 'Torta de presunto e queijo média', 7.50, 'tortamista.jpg', 15, now(), 2)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                                " values ('Pudim Tradicional', 'Pudim de leite condensado 200ml', 6.00, 'pudim.jpg', 21, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Produtos");
        }
    }
}
