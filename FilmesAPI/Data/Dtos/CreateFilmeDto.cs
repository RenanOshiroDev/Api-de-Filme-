﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titúlo do filme é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O nome diretor do filme é obrigatório!")]
    public string Diretor { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório!")]
    [StringLength(100, ErrorMessage = "O gênero é inválido!")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatório!")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ter entre 70 a 600 minutos!")]
    public int Duracao { get; set; }

}