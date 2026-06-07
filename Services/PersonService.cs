using Model;
using Model.Context;

namespace Services
{
    public class PersonService: IPersonService
    {

        private Repositories.IRepository<Person> _repository;

        public PersonService(Repositories.IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person create(Person person)
        {
            return _repository.create(person);
        }

        public void delete(int id)
        {
            _repository.delete(id);
        }

        public List<Person> getAll()
        {
            return _repository.getAll();
        }

        public Person getById(int id)
        {
            return _repository.getById(id);
        }

        public Person update(int id, Person person)
        {
            return _repository.update(id, person);
        }

    }
}