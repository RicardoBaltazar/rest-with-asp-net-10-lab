using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title", TypeName = "varchar(255)")]
        public string? Title { get; set; }

        [Column("author", TypeName = "varchar(255)")]
        public string? Author { get; set; }

        [Column("price", TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }

        [Column("launch_date", TypeName = "date")]
        [Required]
        public DateTime LaunchDate { get; set; }
    }
}
