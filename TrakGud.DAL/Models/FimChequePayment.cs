using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__ChequePayment")]
    [Index(nameof(ChequeId), Name = "fki_chequeId_fkey")]
    public partial class FimChequePayment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Column("isBounced")]
        public bool? IsBounced { get; set; }
        [Column("chequeId")]
        public int ChequeId { get; set; }

        [ForeignKey(nameof(ChequeId))]
        [InverseProperty(nameof(FimCheque.FimChequePayments))]
        public virtual FimCheque Cheque { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(FimPaymentType.FimChequePayments))]
        public virtual FimPaymentType TypeNavigation { get; set; }
    }
}
