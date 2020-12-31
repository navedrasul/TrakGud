using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__PaymentPart")]
    [Index(nameof(PaymentPartType), Name = "fki_paymentPartType_fkey")]
    public partial class FimPaymentPart
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("totalAmt")]
        public float TotalAmt { get; set; }
        [Column("isComplete")]
        public bool? IsComplete { get; set; }
        [Required]
        [Column("paymentPartType")]
        [StringLength(25)]
        public string PaymentPartType { get; set; }
    }
}
