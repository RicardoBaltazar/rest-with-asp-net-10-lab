using Model;

namespace Repositories
{
    public interface IBookRepository
    {
        Book getById(int id);
        Book create(Book book);
        Book update(int id, Book book);
        void delete(int id);
        List<Book> getAll();
    }
}
