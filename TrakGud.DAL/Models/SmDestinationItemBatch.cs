using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__DestinationItemBatch")]
    [Index(nameof(ReceivedUnitId), Name = "fki_receivedUnitId_fkey")]
    public partial class SmDestinationItemBatch
    {
        public SmDestinationItemBatch()
        {
            SmShipments = new HashSet<SmShipment>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("itemBatchType")]
        [StringLength(25)]
        public string ItemBatchType { get; set; }
        [Column("productId")]
        public int ProductId { get; set; }
        [Column("sourceType")]
        [StringLength(25)]
        public string SourceType { get; set; }
        [Column("sourceId")]
        public int? SourceId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("receivedQty")]
        public float? ReceivedQty { get; set; }
        [Column("receivedUnitId")]
        public int? ReceivedUnitId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.SmDestinationItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.SmDestinationItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.SmDestinationItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.SmDestinationItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(ReceivedUnitId))]
        [InverseProperty(nameof(DProductUnit.SmDestinationItemBatches))]
        public virtual DProductUnit ReceivedUnit { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.SmDestinationItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
        [InverseProperty(nameof(SmShipment.DestinationItemBatch))]
        public virtual ICollection<SmShipment> SmShipments { get; set; }
    }
}
