using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Country")]
    [Index(nameof(RegionId), Name = "fki_regionId_fkey")]
    public partial class CmCountry
    {
        public CmCountry()
        {
            CmCountryContinents = new HashSet<CmCountryContinent>();
            CmStateProvinces = new HashSet<CmStateProvince>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(25)]
        public string Name { get; set; }
        [Column("regionId")]
        public int? RegionId { get; set; }
        [Column("dialingCode")]
        public int DialingCode { get; set; }

        [ForeignKey(nameof(RegionId))]
        [InverseProperty(nameof(CmRegion.CmCountries))]
        public virtual CmRegion Region { get; set; }
        [InverseProperty(nameof(CmCountryContinent.Country))]
        public virtual ICollection<CmCountryContinent> CmCountryContinents { get; set; }
        [InverseProperty(nameof(CmStateProvince.Country))]
        public virtual ICollection<CmStateProvince> CmStateProvinces { get; set; }
    }
}
