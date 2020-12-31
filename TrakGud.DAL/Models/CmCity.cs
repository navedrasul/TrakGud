using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__City")]
    [Index(nameof(StateProvinceId), Name = "fki_stateProvinceId_fkey")]
    public partial class CmCity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("stateProvinceId")]
        public int StateProvinceId { get; set; }
        [Column("dialingCode")]
        public int DialingCode { get; set; }
    }
}
