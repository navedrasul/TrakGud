using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("s__Shop")]
    public partial class SShop
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("locationId")]
        public int? LocationId { get; set; }
        [Column("isOnline")]
        public bool? IsOnline { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty(nameof(CmLocationInfo.SShops))]
        public virtual CmLocationInfo Location { get; set; }
    }
}
