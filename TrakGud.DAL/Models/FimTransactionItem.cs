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
    }
}
