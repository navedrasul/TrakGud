using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Transaction")]
    [Index(nameof(PaymentId), Name = "fki_paymentId_fkey")]
    public partial class FimTransaction
    {
        public FimTransaction()
        {
            DReceivedItemBatches = new HashSet<DReceivedItemBatch>();
            FimTransactionItems = new HashSet<FimTransactionItem>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Column("RCT")]
        [StringLength(25)]
        public string Rct { get; set; }
        [Column("RST")]
        [StringLength(25)]
        public string Rst { get; set; }
        [Column("paymentId")]
        public int PaymentId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("TS", TypeName = "timestamp with time zone")]
        public DateTime? Ts { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }

        [ForeignKey(nameof(AdderId))]
        [InverseProperty(nameof(UmUser.FimTransactionAdders))]
        public virtual UmUser Adder { get; set; }
        [ForeignKey(nameof(ModderId))]
        [InverseProperty(nameof(UmUser.FimTransactionModders))]
        public virtual UmUser Modder { get; set; }
        [ForeignKey(nameof(PaymentId))]
        [InverseProperty(nameof(FimPayment.FimTransactions))]
        public virtual FimPayment Payment { get; set; }
        [ForeignKey(nameof(Rct))]
        [InverseProperty(nameof(DRelativeCountryType.FimTransactions))]
        public virtual DRelativeCountryType RctNavigation { get; set; }
        [ForeignKey(nameof(Rst))]
        [InverseProperty(nameof(DRelativeStateProvType.FimTransactions))]
        public virtual DRelativeStateProvType RstNavigation { get; set; }
        [ForeignKey(nameof(Type))]
        [InverseProperty(nameof(FimTransactionType.FimTransactions))]
        public virtual FimTransactionType TypeNavigation { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual FimTransactionAmount FimTransactionAmount { get; set; }
        [InverseProperty(nameof(DReceivedItemBatch.Transaction))]
        public virtual ICollection<DReceivedItemBatch> DReceivedItemBatches { get; set; }
        [InverseProperty(nameof(FimTransactionItem.Transaction))]
        public virtual ICollection<FimTransactionItem> FimTransactionItems { get; set; }
    }
}
