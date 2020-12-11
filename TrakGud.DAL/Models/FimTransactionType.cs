using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__TransactionType")]
    public partial class FimTransactionType
    {
        public FimTransactionType()
        {
            FimTransactions = new HashSet<FimTransaction>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FimTransaction.TypeNavigation))]
        public virtual ICollection<FimTransaction> FimTransactions { get; set; }
    }
}
