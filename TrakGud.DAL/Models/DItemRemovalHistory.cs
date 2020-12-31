using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__ItemRemovalHistory")]
    public partial class DItemRemovalHistory
    {
        [Key]
        [Column("itemId")]
        public int ItemId { get; set; }
        [Column("removerId")]
        public int RemoverId { get; set; }
        [Column("TS", TypeName = "timestamp with time zone")]
        public DateTime? Ts { get; set; }
    }
}
