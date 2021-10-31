using AutoMapper;
using AutoMapper.QueryableExtensions;
using Business.Abstractions;
using Business.Models;
using Data.DomainModels;
using Data.EF.Repository;
using System.Linq;

namespace Business.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAsyncRepository<Author> _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAsyncRepository<Author> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public IQueryable<AuthorDto> GetAll()
        {
            return _authorRepository.Get().ProjectTo<AuthorDto>(_mapper.ConfigurationProvider);
        }
    }
}
