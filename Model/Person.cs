using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("first_name", TypeName = "varchar(100)")]
        [Required]
        public required string FirstName { get; set; }

        [Column("last_name", TypeName = "varchar(100)")]
        public string? LastName { get; set; }

        [Column("address", TypeName = "varchar(225)")]
        [Required]
        public required string Address { get; set; }

        [Column("age")]
        [Required]
        public int Age { get; set; }
    }
}