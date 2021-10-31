using AutoMapper;
using Business.Models;
using Data.DomainModels;

namespace Business.Mappers
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();
        }
    }
}
