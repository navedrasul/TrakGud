using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("gs__Theme")]
    public partial class GsTheme
    {
        public GsTheme()
        {
            GsUserSettings = new HashSet<GsUserSetting>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(25)]
        public string Title { get; set; }
        [Column("desc")]
        [StringLength(150)]
        public string Desc { get; set; }
        [Required]
        [Column("themePath")]
        [StringLength(250)]
        public string ThemePath { get; set; }

        [InverseProperty(nameof(GsUserSetting.CurrentTheme))]
        public virtual ICollection<GsUserSetting> GsUserSettings { get; set; }
    }
}
