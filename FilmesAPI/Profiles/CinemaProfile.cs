using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class CinemaProfile : Profile    
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>().
            ForMember(readCinemaDto => readCinemaDto.Endereco,
            opt => opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(readCinemaDto => readCinemaDto.Sessao,
            opt => opt.MapFrom(cinema => cinema.Sessoes));
        CreateMap<UpdateCinemaDto, Cinema>();

    }
}
