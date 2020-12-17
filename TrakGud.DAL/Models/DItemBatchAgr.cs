using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ItemBatch_agr")]
    public partial class DItemBatchAgr
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("qty")]
        public float? Qty { get; set; }
        [Column("unitId")]
        public int? UnitId { get; set; }
        [Column("price")]
        public float? Price { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(DItemBatch.DItemBatchAgr))]
        public virtual DItemBatch IdNavigation { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(DProductUnit.DItemBatchAgrs))]
        public virtual DProductUnit Unit { get; set; }
    }
}
