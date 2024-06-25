﻿using LivrariaWebApi.Dto.Vinculo;
using LivrariaWebApi.Models;

namespace LivrariaWebApi.Dto.Livro
{
    public class EditarLivroDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
