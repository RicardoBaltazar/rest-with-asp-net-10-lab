using Microsoft.AspNetCore.Mvc;
using Model;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly Services.IPersonService _personService;
        private readonly ILogger<PersonController> _logger;

        public PersonController(
            Services.IPersonService personService, ILogger<PersonController> logger
        )
        {
            _personService = personService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var person = _personService.getById(1);
            _logger.LogInformation("Fetched person with ID 1: {@Person}", person);

            return Ok(person);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Fetching person with ID {PersonId}", id);
            var person = _personService.getById(id);
            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            var createdPerson = _personService.create(person);
            _logger.LogInformation("Created a new person with ID {PersonId}", createdPerson.Id);

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