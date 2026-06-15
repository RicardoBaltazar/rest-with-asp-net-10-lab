using Data.DTO;

namespace Services
{
    public interface IPersonService
    {
        PersonDTO Create(PersonDTO person);

        PersonDTO GetById(int id);

        List<PersonDTO> GetAll();
        PersonDTO Update(int id, PersonDTO person);
        void Delete(int id);
    }
}