using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__TransactionItem_agr")]
    public partial class FimTransactionItemAgr
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("total")]
        public float? Total { get; set; }
    }
}
