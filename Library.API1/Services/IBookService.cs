

using Library.API1.Models;

namespace Library.Api.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);
        Book GetByID(Guid id);
        void Remove(Guid id);
        object GetById(Guid id);
    }
}
