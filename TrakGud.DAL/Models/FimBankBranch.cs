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
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("bankId")]
        public int BankId { get; set; }
        [Column("addressId")]
        public int AddressId { get; set; }
    }
}
