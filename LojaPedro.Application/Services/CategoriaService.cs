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
    public class CategoriaService : ICategoriaService
    {

        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }


        public async Task<CategoriaDTO> GetById(int? id)
        {
            var categoriaEntity = await _categoriaRepository.GetById(id);
            return _mapper.Map<CategoriaDTO>(categoriaEntity);
        }

        public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
        {
            var categoriasEntity = await _categoriaRepository.GetCategorias();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriasEntity);
        }

        public async Task Create(CategoriaDTO categoriaDTO)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.Create(categoriaEntity);
        }
        public async Task Remove(int? id)
        {
            var categoriaEntity = _categoriaRepository.GetById(id).Result;
            await _categoriaRepository.Remove(categoriaEntity);
        }

        public async Task Update(CategoriaDTO categoriaDTO)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.Update(categoriaEntity);
        }
    }
}
