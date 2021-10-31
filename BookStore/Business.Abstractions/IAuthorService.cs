using Business.Models;
using System.Linq;

namespace Business.Abstractions
{
    public interface IAuthorService
    {
        IQueryable<AuthorDto> GetAll();
    }
}
