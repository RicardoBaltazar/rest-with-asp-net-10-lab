using Model;
using Model.Context;

namespace Services
{
    public class PersonService: IPersonService
    {

        private SQLContext _context;

        public PersonService(SQLContext context)
        {
            _context = context;
        }
    
        public Person create(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return person;
        }

        public void delete(int id)
        {
            var person = _context.Persons.Find(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
                _context.SaveChanges();
            }
        }

        public List<Person> getAll()
        {
            return _context.Persons.ToList();
        }

        public Person getById(int id)
        {

            return _context.Persons.Find(id);
        }

        public Person update(int id, Person person)
        {
            var existingPerson = _context.Persons.Find(id);
            if (existingPerson == null)
            {
                return null;
            }

            existingPerson.FirstName = person.FirstName;
            existingPerson.LastName = person.LastName;
            existingPerson.Address = person.Address;
            existingPerson.Age = person.Age;

            _context.SaveChanges();
            return existingPerson;
        }

    }
}