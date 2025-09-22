using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraApi.Models
{
    [Table("compra_items")]
    public class CompraItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("unit_price", TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        // Relación Many-to-One con Producto
        [Column("product_id")]
        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Producto Product { get; set; } = null!;

        // Relación Many-to-One con Compra
        [Column("compra_id")]
        public long CompraId { get; set; }

        [ForeignKey("CompraId")]
        public Compra Compra { get; set; } = null!;
    }
}
