using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ProductWarehouseStock")]
    [Index(nameof(WarehouseId), Name = "fki_warehouseId_fkey")]
    public partial class DProductWarehouseStock
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("qty")]
        public float? Qty { get; set; }
        [Column("unitId")]
        public int? UnitId { get; set; }
        [Column("warehouseId")]
        public int WarehouseId { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
    }
}
