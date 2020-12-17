using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ItemBatch")]
    [Index(nameof(ProductId), Name = "fki_productId_fkey")]
    [Index(nameof(SourceType), Name = "fki_sourceType_fkey")]
    public partial class DItemBatch
    {
        public DItemBatch()
        {
            DItemItemBatches = new HashSet<DItemItemBatch>();
            FimTransactionItems = new HashSet<FimTransactionItem>();
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
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.DItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.DItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.DItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.DItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual DItemBatchAgr DItemBatchAgr { get; set; }
        [InverseProperty(nameof(DItemItemBatch.Batch))]
        public virtual ICollection<DItemItemBatch> DItemItemBatches { get; set; }
        [InverseProperty(nameof(FimTransactionItem.ItemBatch))]
        public virtual ICollection<FimTransactionItem> FimTransactionItems { get; set; }
    }
}
