using AutoMapper;
using LojaPedro.Application.DTOs;
using LojaPedro.Application.Interfaces;
using LojaPedro.Domain;
using LojaPedro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaPedro.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository ??
                throw new ArgumentNullException(nameof(produtoRepository));

            _mapper = mapper;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            var produtosEntity = await _produtoRepository.GetProdutosAsync();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtosEntity);
        }

        public async Task<ProdutoDTO> GetById(int? id)
        {
            var produtoEntity = await _produtoRepository.GetIdAsync(id);
            return _mapper.Map<ProdutoDTO>(produtoEntity);
        }

        public async Task<ProdutoDTO> GetProdutoCategoria(int? id)
        {
            var produtoEntity = await _produtoRepository.GetProdutoCategoriaAsync(id);
            return _mapper.Map<ProdutoDTO>(produtoEntity);
        }

        public async Task Add(ProdutoDTO produtoDTO)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDTO);
            await _produtoRepository.CreateAsync(produtoEntity);
        }

        public async Task Update(ProdutoDTO produtoDTO)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDTO);
            await _produtoRepository.UpdateAsync(produtoEntity);
        }

        public async Task Remove(int? id)
        {
            var produtoEntity = _produtoRepository.GetIdAsync(id).Result;
            await _produtoRepository.RemoveAsync(produtoEntity);
        }
    }
}
