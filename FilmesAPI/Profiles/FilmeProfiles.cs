using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfiles : Profile
{
    public FilmeProfiles()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>()
            .ForMember(readFilmeDto => readFilmeDto.Sessao,
            opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
