using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraApi.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("username")]
        [MaxLength(256)]
        public required string Username { get; set; }

        [Column("password")]
        [MaxLength(256)]
        public required string Password { get; set; }

        [Column("role")]
        [MaxLength(64)]
        public required string Role { get; set; }
    }
}
