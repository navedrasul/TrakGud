using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleCapacityUnit")]
    [Index(nameof(VehicleUnitType), Name = "fki_vehicleUnitType_fkey")]
    public partial class FmVehicleCapacityUnit
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isDefault")]
        public bool? IsDefault { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Required]
        [Column("vehicleUnitType")]
        [StringLength(25)]
        public string VehicleUnitType { get; set; }
        [Column("vehicleType")]
        [StringLength(25)]
        public string VehicleType { get; set; }
    }
}
