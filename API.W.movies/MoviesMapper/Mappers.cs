using API.W.movies.DATA.Models;
using API.W.movies.DATA.Models.Dtos;
using AutoMapper;

namespace API.W.movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()         { 

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
