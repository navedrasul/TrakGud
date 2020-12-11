using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__StateProvince")]
    public partial class CmStateProvince
    {
        public CmStateProvince()
        {
            CmCities = new HashSet<CmCity>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("countryId")]
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(CmCountry.CmStateProvinces))]
        public virtual CmCountry Country { get; set; }
        [InverseProperty(nameof(CmCity.StateProvince))]
        public virtual ICollection<CmCity> CmCities { get; set; }
    }
}
