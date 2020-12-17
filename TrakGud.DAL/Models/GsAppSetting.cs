using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("gs__AppSettings")]
    [Index(nameof(DefaultCurrencyId), Name = "fki_defaultCurrencyId_fkey")]
    public partial class GsAppSetting
    {
        [Column("companyName")]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Key]
        [Column("appId")]
        public int AppId { get; set; }
        [Column("defaultCurrencyId")]
        [StringLength(25)]
        public string DefaultCurrencyId { get; set; }

        [ForeignKey(nameof(AppId))]
        [InverseProperty(nameof(GsApp.GsAppSetting))]
        public virtual GsApp App { get; set; }
        [ForeignKey(nameof(DefaultCurrencyId))]
        [InverseProperty(nameof(FimCurrency.GsAppSettings))]
        public virtual FimCurrency DefaultCurrency { get; set; }
    }
}
