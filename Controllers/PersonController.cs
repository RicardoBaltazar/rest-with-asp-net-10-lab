using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly Services.IPersonService _personService;

        public PersonController(Services.IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var person = _personService.getById(1);

            return Ok(person);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var person = _personService.getById(id);
            if (person == null) return NotFound();
            
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            var createdPerson = _personService.create(person);

            return Ok(createdPerson);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Person person)
        {
            var updatedPerson = _personService.update(id, person);

            return Ok(updatedPerson);
        }
 

         [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.delete(id);

            return NoContent();
        }
    }
}