using Model;

namespace Services
{
    public interface IPersonService
    {
        Person create(Person person);

        Person getById(int id);

        List<Person> getAll();
        Person update(int id, Person person);
        void delete(int id);
    }
}