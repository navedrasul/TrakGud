using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ProductStock")]
    [Index(nameof(UnitId), Name = "fki_unitId_fkey")]
    public partial class DProductStock
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("qty")]
        public float? Qty { get; set; }
        [Column("unitId")]
        public int? UnitId { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
    }
}
