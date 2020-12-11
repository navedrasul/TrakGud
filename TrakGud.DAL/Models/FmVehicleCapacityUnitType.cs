using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("fm__VehicleCapacityUnitType")]
    public partial class FmVehicleCapacityUnitType
    {
        public FmVehicleCapacityUnitType()
        {
            FmVehicleCapacityUnits = new HashSet<FmVehicleCapacityUnit>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(FmVehicleCapacityUnit.VehicleUnitTypeNavigation))]
        public virtual ICollection<FmVehicleCapacityUnit> FmVehicleCapacityUnits { get; set; }
    }
}
