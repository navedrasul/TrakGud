using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("gs__App")]
    [Index(nameof(AppType), Name = "fki_appType_fkey")]
    [Index(nameof(UserGroupId), Name = "fki_userGroupId_fkey")]
    public partial class GsApp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("appVersion")]
        [StringLength(25)]
        public string AppVersion { get; set; }
        [Required]
        [Column("appType")]
        [StringLength(25)]
        public string AppType { get; set; }
        [Column("userGroupId")]
        public int UserGroupId { get; set; }
    }
}
