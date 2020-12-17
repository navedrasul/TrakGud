using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleType")]
    public partial class FmVehicleType
    {
        public FmVehicleType()
        {
            FmVehicleCapacityUnits = new HashSet<FmVehicleCapacityUnit>();
            FmVehicles = new HashSet<FmVehicle>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FmVehicleCapacityUnit.VehicleTypeNavigation))]
        public virtual ICollection<FmVehicleCapacityUnit> FmVehicleCapacityUnits { get; set; }
        [InverseProperty(nameof(FmVehicle.VehicleTypeNavigation))]
        public virtual ICollection<FmVehicle> FmVehicles { get; set; }
    }
}
