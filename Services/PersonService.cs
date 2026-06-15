using Model;
using Data.DTO;
using Data.Converter.Impl;

namespace Services
{
    public class PersonService(
        Repositories.IRepository<Person> repository,
        PersonConverter converter
    ) : IPersonService
    {

        private readonly Repositories.IRepository<Person> _repository = repository;
        private readonly PersonConverter _converter = converter;


        public PersonDTO Create(PersonDTO person)
        {
            return _converter.Parse(
                _repository.create(
                    _converter.Parse(person)
                )
            );
        }

        public void Delete(int id)
        {
            _repository.delete(id);
        }

        public List<PersonDTO> GetAll()
        {
            return _converter.ParseList(
                _repository.getAll()
            );
        }

        public PersonDTO GetById(int id)
        {
            return _converter.Parse(
                _repository.getById(id)
            );
        }

        public PersonDTO Update(int id, PersonDTO person)
        {
            return _converter.Parse(
                _repository.update(
                    id,
                    _converter.Parse(person)
                )
            );
        }
    }
}