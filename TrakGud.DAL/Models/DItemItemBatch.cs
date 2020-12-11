using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Item_ItemBatch")]
    public partial class DItemItemBatch
    {
        [Key]
        [Column("itemId")]
        public int ItemId { get; set; }
        [Key]
        [Column("batchId")]
        public int BatchId { get; set; }

        [ForeignKey(nameof(BatchId))]
        [InverseProperty(nameof(DItemBatch.DItemItemBatches))]
        public virtual DItemBatch Batch { get; set; }
        [ForeignKey(nameof(ItemId))]
        [InverseProperty(nameof(DItem.DItemItemBatches))]
        public virtual DItem Item { get; set; }
    }
}
