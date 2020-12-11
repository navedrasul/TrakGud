using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Keyless]
    [Table("fim__CreditPayment")]
    public partial class FimCreditPayment
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Column("receivedAmt")]
        public float? ReceivedAmt { get; set; }
        [Column("dueDate", TypeName = "timestamp with time zone")]
        public DateTime? DueDate { get; set; }

        [ForeignKey(nameof(Type))]
        public virtual FimPaymentType TypeNavigation { get; set; }
    }
}
