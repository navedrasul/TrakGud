using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("gs__AppType")]
    public partial class GsAppType
    {
        public GsAppType()
        {
            GsApps = new HashSet<GsApp>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(GsApp.AppTypeNavigation))]
        public virtual ICollection<GsApp> GsApps { get; set; }
    }
}
