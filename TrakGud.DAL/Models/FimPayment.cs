using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Payment")]
    public partial class FimPayment
    {
        public FimPayment()
        {
            FimTransactions = new HashSet<FimTransaction>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }

        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(FimPaymentType.FimPayments))]
        public virtual FimPaymentType TypeNavigation { get; set; }
        [InverseProperty(nameof(FimTransaction.Payment))]
        public virtual ICollection<FimTransaction> FimTransactions { get; set; }
    }
}
