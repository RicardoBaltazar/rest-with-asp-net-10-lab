using Data.DTO;
using Mapster;
using Model;

namespace Services
{
    public class BookService : IBookService
    {
        private Repositories.IRepository<Book> _bookRepository;

        public BookService(Repositories.IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public BookDTO create(BookDTO book)
        {
            return _bookRepository.create(book.Adapt<Book>()).Adapt<BookDTO>();
        }

        public void delete(int id)
        {
            _bookRepository.delete(id);
        }

        public List<BookDTO> getAll()
        {
            return _bookRepository.getAll().Adapt<List<BookDTO>>();
        }

        public BookDTO getById(int id)
        {
            return _bookRepository.getById(id).Adapt<BookDTO>();
        }

        public BookDTO update(int id, BookDTO book)
        {
            return _bookRepository.update(id, book.Adapt<Book>()).Adapt<BookDTO>();
        }
    }
}
