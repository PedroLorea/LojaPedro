using LojaPedro.Application.DTOs;
using LojaPedro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaPedro.WebUI.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categorias = await _categoriaService.GetCategorias();
            return View(categorias);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoriaDTO categoria)
        {
            if (ModelState.IsValid)
            {
                await _categoriaService.Create(categoria);
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var categoriaDto = await _categoriaService.GetById(id);

            if (categoriaDto == null) return NotFound();

            return View(categoriaDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoriaDTO categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _categoriaService.Update(categoria);
                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        [HttpGet]
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null) return NotFound();

            var categoriaDTO = await _categoriaService.GetById(id);

            if (categoriaDTO == null) return NotFound();

            return View(categoriaDTO);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _categoriaService.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var categoriaDTO = await _categoriaService.GetById(id);

            if (categoriaDTO == null) return NotFound();

            return View(categoriaDTO);
        }
    }
}
