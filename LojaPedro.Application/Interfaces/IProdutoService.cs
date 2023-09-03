using LojaPedro.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaPedro.Application.Interfaces
{
    public interface IProdutoService
    {
        
        Task<IEnumerable<ProdutoDTO>> GetProdutos();
        //Task<ProdutoDTO> GetById(int? id);
        //Task<ProdutoDTO> GetProdutoCategoria(int? id);
        //Task Add(ProdutoDTO produtoDTO);
        //Task Update(ProdutoDTO produtoDTO);
        //Task Remove(int? id);
    }
}
