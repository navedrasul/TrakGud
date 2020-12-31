using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__Right_RightsSection")]
    [Index(nameof(RightId), Name = "fki_rightId_fkey")]
    [Index(nameof(RightsSectionId), Name = "fki_rightsSectionId_fkey")]
    public partial class UmRightRightsSection
    {
        [Key]
        [Column("rightId")]
        public int RightId { get; set; }
        [Key]
        [Column("rightsSectionId")]
        public int RightsSectionId { get; set; }
    }
}
