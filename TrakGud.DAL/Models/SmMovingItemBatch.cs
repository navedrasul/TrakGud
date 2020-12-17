using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__MovingItemBatch")]
    [Index(nameof(ShipmentId), Name = "fki_shipmentId_fkey")]
    public partial class SmMovingItemBatch
    {
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
        [Column("shipmentId")]
        public int ShipmentId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.SmMovingItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.SmMovingItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.SmMovingItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.SmMovingItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(ShipmentId))]
        [InverseProperty(nameof(SmShipment.SmMovingItemBatches))]
        public virtual SmShipment Shipment { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.SmMovingItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
    }
}
