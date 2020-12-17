using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__PaymentType")]
    public partial class FimPaymentType
    {
        public FimPaymentType()
        {
            FimCashPayments = new HashSet<FimCashPayment>();
            FimChequePayments = new HashSet<FimChequePayment>();
            FimCreditPayments = new HashSet<FimCreditPayment>();
            FimPayments = new HashSet<FimPayment>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FimCashPayment.TypeNavigation))]
        public virtual ICollection<FimCashPayment> FimCashPayments { get; set; }
        [InverseProperty(nameof(FimChequePayment.TypeNavigation))]
        public virtual ICollection<FimChequePayment> FimChequePayments { get; set; }
        [InverseProperty(nameof(FimCreditPayment.TypeNavigation))]
        public virtual ICollection<FimCreditPayment> FimCreditPayments { get; set; }
        [InverseProperty(nameof(FimPayment.TypeNavigation))]
        public virtual ICollection<FimPayment> FimPayments { get; set; }
    }
}
