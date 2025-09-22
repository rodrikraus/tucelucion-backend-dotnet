using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiPrimeraApi.Models
{
    [Table("compras")]
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("fecha_compra")]
        public DateTime FechaCompra { get; set; }

        [Column("total_amount", TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Column("email")]
        [MaxLength(256)]
        public required string Email { get; set; }

        [Column("shipping_address")]
        [MaxLength(512)]
        public required string ShippingAddress { get; set; }

        [Column("numero_celular")]
        [MaxLength(32)]
        public required string NumeroCelular { get; set; }

        [Column("estado")]
        [MaxLength(32)]
        public required string Estado { get; set; } // "PENDIENTE","ENTREGADO","CANCELADO"

        [Column("items")]
        public List<CompraItem> Items { get; set; } = new();
    }
}
