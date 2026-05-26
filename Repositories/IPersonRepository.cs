using Model;

namespace Repositories
{
    public interface IPersonRepository
    {
        Person getById(int id);
        Person create(Person person);
        Person update(int id, Person person);
        void delete(int id);
        List<Person> getAll();
    }

}