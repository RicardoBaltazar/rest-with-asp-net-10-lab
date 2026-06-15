using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DTO
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        public required string Address { get; set; }

        public int Age { get; set; }
    }
}