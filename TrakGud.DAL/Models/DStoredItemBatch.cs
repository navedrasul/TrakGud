using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__StoredItemBatch")]
    [Index(nameof(ProductWarehouseStockId), Name = "fki_productWarehouseStockId_fkey")]
    public partial class DStoredItemBatch
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
        [Column("productWarehouseStockId")]
        public int ProductWarehouseStockId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.DStoredItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.DStoredItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DStoredItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.DStoredItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(ProductWarehouseStockId))]
        [InverseProperty(nameof(DProductWarehouseStock.DStoredItemBatches))]
        public virtual DProductWarehouseStock ProductWarehouseStock { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.DStoredItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
    }
}
