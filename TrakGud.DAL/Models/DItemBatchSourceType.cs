using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ItemBatchSourceType")]
    public partial class DItemBatchSourceType
    {
        public DItemBatchSourceType()
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

        [InverseProperty(nameof(DItemBatch.SourceTypeNavigation))]
        public virtual ICollection<DItemBatch> DItemBatches { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.SourceTypeNavigation))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatches { get; set; }
        [InverseProperty(nameof(DRemovedItemBatch.SourceTypeNavigation))]
        public virtual ICollection<DRemovedItemBatch> DRemovedItemBatches { get; set; }
        [InverseProperty(nameof(DStoredItemBatch.SourceTypeNavigation))]
        public virtual ICollection<DStoredItemBatch> DStoredItemBatches { get; set; }
        [InverseProperty(nameof(SmDestinationItemBatch.SourceTypeNavigation))]
        public virtual ICollection<SmDestinationItemBatch> SmDestinationItemBatches { get; set; }
        [InverseProperty(nameof(SmMovingItemBatch.SourceTypeNavigation))]
        public virtual ICollection<SmMovingItemBatch> SmMovingItemBatches { get; set; }
        [InverseProperty(nameof(SmShippedItemBatch.SourceTypeNavigation))]
        public virtual ICollection<SmShippedItemBatch> SmShippedItemBatches { get; set; }
        [InverseProperty(nameof(SmSourceItemBatch.SourceTypeNavigation))]
        public virtual ICollection<SmSourceItemBatch> SmSourceItemBatches { get; set; }
    }
}
