using Data.DTO;
using Model;

namespace Services
{
    public interface IBookService
    {
        BookDTO create(BookDTO book);
        BookDTO getById(int id);
        List<BookDTO> getAll();
        BookDTO update(int id, BookDTO book);
        void delete(int id);
    }
}
