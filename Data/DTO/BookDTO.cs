using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DTO
{
    public class BookDTO
    {
        public string? Title { get; set; }

        public string? Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
        public int Id { get; internal set; }
    }
}
