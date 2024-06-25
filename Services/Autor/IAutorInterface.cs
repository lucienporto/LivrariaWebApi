using LivrariaWebApi.Dto.Autor;
using LivrariaWebApi.Models;

namespace LivrariaWebApi.Services.Autor
{
    public interface IAutorInterface
    {
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto);
        Task<ResponseModel<List<AutorModel>>> EditarAutor(EditarAutorDto editarAutorDto);
        Task<ResponseModel<List<AutorModel>>> DeletarAutor(int idAutor);

    }
}
