﻿using Livraria.Domain.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Domain.Dto
{
    public class AutorDto
    {
        public string Nome { get; set; }
        public List<LivroDto> Livros { get; set; }

        public static AutorDto ConverterParaDto(Autor autor)
        {
            if (autor == null) return null;
            return new AutorDto()
            {
                Nome = autor.Nome,
                Livros = autor.Livros.Select(x => LivroDto.ConverterParaDto(x)).ToList()
            };
        }
    }
}
