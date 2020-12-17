using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Bank")]
    public partial class FimBank
    {
        public FimBank()
        {
            FimBankBranches = new HashSet<FimBankBranch>();
            FimCheques = new HashSet<FimCheque>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(150)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(250)]
        public string Desc { get; set; }

        [InverseProperty(nameof(FimBankBranch.Bank))]
        public virtual ICollection<FimBankBranch> FimBankBranches { get; set; }
        [InverseProperty(nameof(FimCheque.Bank))]
        public virtual ICollection<FimCheque> FimCheques { get; set; }
    }
}
