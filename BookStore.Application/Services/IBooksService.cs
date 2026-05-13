using BookStore.Core.Models;

namespace BookStore.Application.Services
{
    public interface IBooksService
    {
        Task<Guid> CreateBook(Book book);
        Task<Guid> DeleteBooks(Guid id);
        Task<List<Book>> GetAllBooks();
        Task<Guid> UpdateBooks(Guid id, string title, string description, decimal price);
    }
}