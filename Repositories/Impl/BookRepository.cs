using Model;
using Model.Context;

namespace Repositories.Impl
{
    public class BookRepository : IBookRepository
    {
        private SQLContext _context;

        public BookRepository(SQLContext context)
        {
            _context = context;
        }

        public Book create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public void delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public List<Book> getAll()
        {
            return _context.Books.ToList();
        }

        public Book getById(int id)
        {
            return _context.Books.Find(id);
        }

        public Book update(int id, Book book)
        {
            var existingBook = _context.Books.Find(id);
            if (existingBook == null)
            {
                return null;
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;
            existingBook.LaunchDate = book.LaunchDate;

            _context.SaveChanges();
            return existingBook;
        }
    }
}
