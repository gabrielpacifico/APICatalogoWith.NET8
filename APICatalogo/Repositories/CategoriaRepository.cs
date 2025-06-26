using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace APICatalogo.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(APIDbContext context) : base(context)
        {
        }
        public async Task<IPagedList<Categoria>> GetCategoriasAsync(CategoriasParameters categoriasParams)
        {
            var categorias = await GetAllAsync();

            var categoriasOrdenadas = categorias.OrderBy(c => c.CategoriaId).AsQueryable();

            var result = await categoriasOrdenadas.ToPagedListAsync(categoriasParams.pageNumber, categoriasParams.PageSize);

            return result;
        }

        public async Task<IPagedList<Categoria>> GetCategoriasPorNomeAsync(CategoriasFiltroNome categoriasParams)
        {
            var categorias = await GetAllAsync();

            if (!string.IsNullOrEmpty(categoriasParams.Nome))
            {
                categorias = categorias.Where(c => c.Nome.Contains(categoriasParams.Nome, StringComparison.OrdinalIgnoreCase));
            }

            var categoriasFiltradas = await categorias.ToPagedListAsync(categoriasParams.pageNumber, categoriasParams.PageSize);
            return categoriasFiltradas;
        }
    }
}
