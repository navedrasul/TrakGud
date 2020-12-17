using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Transaction_amounts")]
    public partial class FimTransactionAmount
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("totalBeforeDiscount")]
        public float? TotalBeforeDiscount { get; set; }
        [Column("discount")]
        public float? Discount { get; set; }
        [Column("total")]
        public float? Total { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(FimTransaction.FimTransactionAmount))]
        public virtual FimTransaction IdNavigation { get; set; }
    }
}
