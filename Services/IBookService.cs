using Model;

namespace Services
{
    public interface IBookService
    {
        Book create(Book book);
        Book getById(int id);
        List<Book> getAll();
        Book update(int id, Book book);
        void delete(int id);
    }
}
