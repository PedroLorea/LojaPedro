
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaPedro.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetCategorias();
        Task<Categoria> GetById(int? id);
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Update(Categoria categoria);
        Task<Categoria> Remove(Categoria categoria);
        
    }
}
