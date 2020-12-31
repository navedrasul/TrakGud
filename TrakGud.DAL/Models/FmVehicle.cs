using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__Vehicle")]
    [Index(nameof(Status), Name = "fki_status_fkey")]
    [Index(nameof(VehicleType), Name = "fki_vehicleType_fkey")]
    public partial class FmVehicle
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("desc")]
        [StringLength(150)]
        public string Desc { get; set; }
        [Required]
        [Column("regNumber")]
        [StringLength(50)]
        public string RegNumber { get; set; }
        [Column("currentDriverId")]
        public int? CurrentDriverId { get; set; }
        [Column("isInService")]
        public bool? IsInService { get; set; }
        [Required]
        [Column("status")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("driverAssignmentTS", TypeName = "timestamp with time zone")]
        public DateTime? DriverAssignmentTs { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("vehicleType")]
        [StringLength(25)]
        public string VehicleType { get; set; }
    }
}
