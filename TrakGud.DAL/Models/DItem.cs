using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Item")]
    [Index(nameof(ProdId), Name = "fki_prodId_fkey")]
    public partial class DItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("prodId")]
        public int ProdId { get; set; }
        [Column("price")]
        public float? Price { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("qty")]
        public float? Qty { get; set; }
        [Column("unitId")]
        public int? UnitId { get; set; }
        [Column("expireTS", TypeName = "timestamp with time zone")]
        public DateTime? ExpireTs { get; set; }
        [Column("expireMargin")]
        public float? ExpireMargin { get; set; }
        [Column("isFixed")]
        public bool? IsFixed { get; set; }
        [Column("isExpired")]
        public bool? IsExpired { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
    }
}
