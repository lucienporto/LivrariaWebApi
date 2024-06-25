using LivrariaWebApi.Dto.Vinculo;
using LivrariaWebApi.Models;

namespace LivrariaWebApi.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
