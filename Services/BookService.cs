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

        public Book create(Book book)
        {
            return _bookRepository.create(book);
        }

        public void delete(int id)
        {
            _bookRepository.delete(id);
        }

        public List<Book> getAll()
        {
            return _bookRepository.getAll();
        }

        public Book getById(int id)
        {
            return _bookRepository.getById(id);
        }

        public Book update(int id, Book book)
        {
            return _bookRepository.update(id, book);
        }
    }
}
