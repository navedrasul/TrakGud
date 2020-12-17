using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Country_Continent")]
    [Index(nameof(ContinentId), Name = "fki_continentId_fkey")]
    [Index(nameof(CountryId), Name = "fki_countryId_fkey")]
    public partial class CmCountryContinent
    {
        [Key]
        [Column("countryId")]
        public int CountryId { get; set; }
        [Key]
        [Column("continentId")]
        public int ContinentId { get; set; }

        [ForeignKey(nameof(ContinentId))]
        [InverseProperty(nameof(CmContinent.CmCountryContinents))]
        public virtual CmContinent Continent { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(CmCountry.CmCountryContinents))]
        public virtual CmCountry Country { get; set; }
    }
}
