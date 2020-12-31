using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fim__Currency")]
    public partial class FimCurrency
    {
        [Key]
        [Column("value")]
        [StringLength(3)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(60)]
        public string Text { get; set; }
    }
}
