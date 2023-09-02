using LojaPedro.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPedro.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> GetCategorias();
        Task<CategoriaDTO> GetById(int? id);
        Task Create(CategoriaDTO categoriaDTO);
        Task Update(CategoriaDTO categoriaDTO);
        Task Remove(int? id);
    }
}
