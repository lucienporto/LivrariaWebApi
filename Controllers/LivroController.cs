using LivrariaWebApi.Dto.Autor;
using LivrariaWebApi.Dto.Livro;
using LivrariaWebApi.Models;
using LivrariaWebApi.Services.Autor;
using LivrariaWebApi.Services.Livro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroInterface _livroInterface;

        public LivroController(ILivroInterface livroInterface)
        {
            _livroInterface = livroInterface;
        }

        [HttpGet("/ListarLivros")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> ListarLivros()
        {
            var livros = await _livroInterface.ListarLivros();
            return Ok(livros);
        }

        [HttpGet("/BuscarLivroPorId/{idLivro}")]
        public async Task<ActionResult<ResponseModel<LivroModel>>> BuscarLivroPorId(int idLivro)
        {
            var livro = await _livroInterface.BuscarLivroPorId(idLivro);
            return Ok(livro);
        }

        [HttpGet("/BuscarLivroPorIdAutor/{idAutor}")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> BuscarLivroPorIdAutro(int idAutor)
        {
            var livros = await _livroInterface.BuscarLivroPorIdAutor(idAutor);
            return Ok(livros);
        }

        [HttpPost("/CriarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> CriarLivro(LivroCriacaoDto livroCriacaoDto)
        {
            var livros = await _livroInterface.CriarLivro(livroCriacaoDto);
            return Ok(livros);
        }

        [HttpPut("/EditarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> EditarLivro(EditarLivroDto editarLivroDto)
        {
            var livros = await _livroInterface.EditarLivro(editarLivroDto);
            return Ok(livros);
        }

        [HttpDelete("DeletarLivro")]
        public async Task<ActionResult<ResponseModel<List<LivroModel>>>> DeletarLivro(int idLivro)
        {
            var livros = await _livroInterface.DeletarLivro(idLivro);
            return Ok(livros);
        }
    }
}
