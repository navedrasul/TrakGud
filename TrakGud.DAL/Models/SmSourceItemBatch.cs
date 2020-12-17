using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__SourceItemBatch")]
    [Index(nameof(ShippedUnitId), Name = "fki_shippedUnitId_fkey")]
    public partial class SmSourceItemBatch
    {
        public SmSourceItemBatch()
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
        [Column("shippedQty")]
        public float? ShippedQty { get; set; }
        [Column("shippedUnitId")]
        public int? ShippedUnitId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.SmSourceItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.SmSourceItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.SmSourceItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.SmSourceItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(ShippedUnitId))]
        [InverseProperty(nameof(DProductUnit.SmSourceItemBatches))]
        public virtual DProductUnit ShippedUnit { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.SmSourceItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
        [InverseProperty(nameof(SmShipment.SourceItemBatch))]
        public virtual ICollection<SmShipment> SmShipments { get; set; }
    }
}
