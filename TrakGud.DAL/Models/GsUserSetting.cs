using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("gs__UserSettings")]
    [Index(nameof(CurrentThemeId), Name = "fki_currentThemeId_fkey")]
    public partial class GsUserSetting
    {
        [Key]
        [Column("userId")]
        public int UserId { get; set; }
        [Column("currentThemeId")]
        public int? CurrentThemeId { get; set; }

        [ForeignKey(nameof(CurrentThemeId))]
        [InverseProperty(nameof(GsTheme.GsUserSettings))]
        public virtual GsTheme CurrentTheme { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UmUser.GsUserSetting))]
        public virtual UmUser User { get; set; }
    }
}
