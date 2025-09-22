using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraApi.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Required]
        [Column("name")]
        public required string Name { get; set; }

        [Column("price", TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        [Column("stock")]
        public int Stock { get; set; }

        [Column("description")]
        [MaxLength(1024)]
        public required string Description { get; set; }

        [Column("image_url")]
        [MaxLength(512)]
        public required string ImageUrl { get; set; }

        [Column("tags")]
        [MaxLength(256)]
        public required string Tags { get; set; }

        [Column("product_category")]
        public required string ProductCategory { get; set; }
    }
}
