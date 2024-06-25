using LivrariaWebApi.Dto.Autor;
using LivrariaWebApi.Dto.Livro;
using LivrariaWebApi.Models;

namespace LivrariaWebApi.Services.Livro
{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDto livroCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(EditarLivroDto editarLivroDto);
        Task<ResponseModel<List<LivroModel>>> DeletarLivro(int idLivro);
    }
}
