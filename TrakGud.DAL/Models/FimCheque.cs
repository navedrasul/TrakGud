using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Cheque")]
    [Index(nameof(IssuerContactId), Name = "fki_issuerContactId_fkey")]
    public partial class FimCheque
    {
        public FimCheque()
        {
            FimChequePayments = new HashSet<FimChequePayment>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("chequeNo")]
        [StringLength(10)]
        public string ChequeNo { get; set; }
        [Required]
        [Column("accNo")]
        [StringLength(25)]
        public string AccNo { get; set; }
        [Column("sourceNo")]
        [StringLength(5)]
        public string SourceNo { get; set; }
        [Column("footerNo")]
        [StringLength(50)]
        public string FooterNo { get; set; }
        [Column("accTitle")]
        [StringLength(150)]
        public string AccTitle { get; set; }
        [Column("chequeDate", TypeName = "date")]
        public DateTime? ChequeDate { get; set; }
        [Column("issuerContactId")]
        public int? IssuerContactId { get; set; }
        [Column("amount")]
        public float Amount { get; set; }
        [Column("bankId")]
        public int BankId { get; set; }

        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(FimBank.FimCheques))]
        public virtual FimBank Bank { get; set; }
        [ForeignKey(nameof(IssuerContactId))]
        [InverseProperty(nameof(CmContact.FimCheques))]
        public virtual CmContact IssuerContact { get; set; }
        [InverseProperty(nameof(FimChequePayment.Cheque))]
        public virtual ICollection<FimChequePayment> FimChequePayments { get; set; }
    }
}
