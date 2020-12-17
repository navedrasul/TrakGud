using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ItemBatchType")]
    public partial class DItemBatchType
    {
        public DItemBatchType()
        {
            DItemBatches = new HashSet<DItemBatch>();
            DReceivedItemBatches = new HashSet<DReceivedItemBatch>();
            DRemovedItemBatches = new HashSet<DRemovedItemBatch>();
            DStoredItemBatches = new HashSet<DStoredItemBatch>();
            SmDestinationItemBatches = new HashSet<SmDestinationItemBatch>();
            SmMovingItemBatches = new HashSet<SmMovingItemBatch>();
            SmShippedItemBatches = new HashSet<SmShippedItemBatch>();
            SmSourceItemBatches = new HashSet<SmSourceItemBatch>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(DItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<DItemBatch> DItemBatches { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatches { get; set; }
        [InverseProperty(nameof(DRemovedItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<DRemovedItemBatch> DRemovedItemBatches { get; set; }
        [InverseProperty(nameof(DStoredItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<DStoredItemBatch> DStoredItemBatches { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatches { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatches { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatches { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.ItemBatchTypeNavigation))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatches { get; set; }
    }
}
