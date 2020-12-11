using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__BankBranch")]
    [Index(nameof(BankId), Name = "fki_bankId_fkey")]
    public partial class FimBankBranch
    {
        public FimBankBranch()
        {
            FimBankBranchPocs = new HashSet<FimBankBranchPoc>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("bankId")]
        public int BankId { get; set; }
        [Column("addressId")]
        public int AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty(nameof(CmAddress.FimBankBranches))]
        public virtual CmAddress Address { get; set; }
        [ForeignKey(nameof(BankId))]
        [InverseProperty(nameof(FimBank.FimBankBranches))]
        public virtual FimBank Bank { get; set; }
        [InverseProperty(nameof(FimBankBranchPoc.BankBranch))]
        public virtual ICollection<FimBankBranchPoc> FimBankBranchPocs { get; set; }
    }
}
