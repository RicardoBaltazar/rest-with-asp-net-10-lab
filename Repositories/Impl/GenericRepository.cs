using Microsoft.EntityFrameworkCore;

namespace Repositories.Impl
{
    public class GenericRepository<T> : IRepository<T> where T : Model.Base.BaseEntity
    {
        private Model.Context.SQLContext _context;
        private DbSet<T> _dataSet;

        public GenericRepository(Model.Context.SQLContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public T create(T entity)
        {
            _dataSet.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void delete(int id)
        {
            var entity = _dataSet.Find(id);
            if (entity != null)
            {
                _dataSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public bool exists(int id)
        {
            return _dataSet.Any(e => e.Id == id);
        }

        public List<T> getAll()
        {
            return _dataSet.ToList();
        }

        public T getById(int id)
        {
            return _dataSet.Find(id);
        }

        public T update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}