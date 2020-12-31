using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__BankBranchPOC")]
    [Index(nameof(BankBranchId), Name = "fki_bankBranchId_fkey")]
    public partial class FimBankBranchPoc
    {
        [Key]
        [Column("bankBranchId")]
        public int BankBranchId { get; set; }
        [Key]
        [Column("contactId")]
        public int ContactId { get; set; }
    }
}
