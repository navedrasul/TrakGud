using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ReceivedItemBatch")]
    [Index(nameof(SellerId), Name = "fki_sellerId_fkey")]
    [Index(nameof(TransactionId), Name = "fki_transactionId_fkey")]
    public partial class DReceivedItemBatch
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
        [Required]
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
        [Column("sellerId")]
        public int? SellerId { get; set; }
        [Column("transactionId")]
        public int? TransactionId { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("receptionTS", TypeName = "timestamp with time zone")]
        public DateTime? ReceptionTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.DReceivedItemBatchAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ItemBatchType))]
        [InverseProperty(nameof(DItemBatchType.DReceivedItemBatches))]
        public virtual DItemBatchType ItemBatchTypeNavigation { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.DReceivedItemBatchModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(DProduct.DReceivedItemBatches))]
        public virtual DProduct Product { get; set; }
        [ForeignKey(nameof(SellerId))]
        [InverseProperty(nameof(DSeller.DReceivedItemBatches))]
        public virtual DSeller Seller { get; set; }
        [ForeignKey(nameof(SourceType))]
        [InverseProperty(nameof(DItemBatchSourceType.DReceivedItemBatches))]
        public virtual DItemBatchSourceType SourceTypeNavigation { get; set; }
        [ForeignKey(nameof(TransactionId))]
        [InverseProperty(nameof(FimTransaction.DReceivedItemBatches))]
        public virtual FimTransaction Transaction { get; set; }
    }
}
