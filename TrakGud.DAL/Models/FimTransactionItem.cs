using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__TransactionItem")]
    [Index(nameof(ItemBatchId), Name = "fki_itemBatchId_fkey")]
    public partial class FimTransactionItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("transactionId")]
        public int TransactionId { get; set; }
        [Column("itemBatchId")]
        public int ItemBatchId { get; set; }
        [Column("price")]
        public float Price { get; set; }
        [Column("qty")]
        public float Qty { get; set; }
        [Column("unitId")]
        public int UnitId { get; set; }
        [Column("discount")]
        public float? Discount { get; set; }

        [ForeignKey(nameof(ItemBatchId))]
        [InverseProperty(nameof(DItemBatch.FimTransactionItems))]
        public virtual DItemBatch ItemBatch { get; set; }
        [ForeignKey(nameof(TransactionId))]
        [InverseProperty(nameof(FimTransaction.FimTransactionItems))]
        public virtual FimTransaction Transaction { get; set; }
        [ForeignKey(nameof(UnitId))]
        [InverseProperty(nameof(DProductUnit.FimTransactionItems))]
        public virtual DProductUnit Unit { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual FimTransactionItemAgr FimTransactionItemAgr { get; set; }
    }
}
