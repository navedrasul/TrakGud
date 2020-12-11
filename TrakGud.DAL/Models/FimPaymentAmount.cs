using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Payment_amounts")]
    public partial class FimPaymentAmount
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("totalAmt")]
        public float TotalAmt { get; set; }
        [Column("receivedAmt")]
        public float? ReceivedAmt { get; set; }
        [Column("isComplete")]
        public bool? IsComplete { get; set; }
        [Column("transactionTS", TypeName = "timestamp with time zone")]
        public DateTime? TransactionTs { get; set; }
    }
}
