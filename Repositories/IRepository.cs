namespace Repositories
{
    public interface IRepository<T> where T : Model.Base.BaseEntity
    {
        T create(T entity);
        T getById(int id);
        List<T> getAll();
        T update(int id, T entity);
        void delete(int id);
        bool exists(int id);
    }
}