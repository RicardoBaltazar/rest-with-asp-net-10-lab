using Model;
using Model.Context;

namespace Services
{
    public class PersonService: IPersonService
    {

        private Repositories.IPersonRepository _personRepository;

        public PersonService(Repositories.IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person create(Person person)
        {
            return _personRepository.create(person);
        }

        public void delete(int id)
        {
            _personRepository.delete(id);
        }

        public List<Person> getAll()
        {
            return _personRepository.getAll();
        }

        public Person getById(int id)
        {
            return _personRepository.getById(id);
        }

        public Person update(int id, Person person)
        {
            return _personRepository.update(id, person);
        }

    }
}