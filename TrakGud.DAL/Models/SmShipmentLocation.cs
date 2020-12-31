using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("sm__ShipmentLocation")]
    [Index(nameof(LocationInfoId), Name = "fki_locationInfoId_fkey")]
    public partial class SmShipmentLocation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("type")]
        [StringLength(25)]
        public string Type { get; set; }
        [Column("locationInfoId")]
        public int LocationInfoId { get; set; }
    }
}
