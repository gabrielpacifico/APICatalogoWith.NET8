using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        PagedList<Produto> GetProdutos(ProdutosParameters produtosParams);
        PagedList<Produto> GetProdutosFiltroPreco(ProdutosFiltroPreco produtosFiltroParams);
        PagedList<Produto> GetProdutosPorNome(ProdutosFiltroNome produtosFiltroNome);
        IEnumerable<Produto> GetProdutosPorCategoria(int id);
    }
}
