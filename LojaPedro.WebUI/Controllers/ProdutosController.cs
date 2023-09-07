using LojaPedro.Application.DTOs;
using LojaPedro.Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LojaPedro.WebUI.Controllers
{
    public class ProdutosController : Controller
    {

        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IWebHostEnvironment _environment;

        public ProdutosController(IProdutoService produtoService, ICategoriaService categoriaService, IWebHostEnvironment environment)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
            _environment = environment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.GetProdutos();
            return View(produtos);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.CategoriaId =
                new SelectList(await _categoriaService.GetCategorias(), "Id", "Nome");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create (ProdutoDTO produtoDto)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Add(produtoDto);
                return RedirectToAction(nameof(Index));
            }
            return View(produtoDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit (int? id)
        {
            if (id == null) return NotFound();

            var produtoDto = await _produtoService.GetById(id);

            if (produtoDto == null) return NotFound();

            var categorias = await _categoriaService.GetCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Nome", produtoDto.CategoriaId);

            return View(produtoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit (ProdutoDTO produtoDto)
        {
            if (ModelState.IsValid)
            {
                await _produtoService.Update(produtoDto);
                return RedirectToAction(nameof(Index));
            }
            return View(produtoDto);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var produtoDto = await _produtoService.GetById(id);

            if (produtoDto == null) return NotFound();

            return View(produtoDto);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _produtoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details (int? id)
        {
            if (id == null) return NotFound();
            var produtoDto = await _produtoService.GetById(id);

            if (produtoDto == null) return NotFound();

            var wwwroot = _environment.WebRootPath;
            var imagem = Path.Combine(wwwroot, "images\\" + produtoDto.Imagem);
            var exists = System.IO.File.Exists(imagem);
            ViewBag.ImageExist = exists;

            return View(produtoDto);

        }
    }
}
