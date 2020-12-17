using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("um__RightsSection")]
    public partial class UmRightsSection
    {
        public UmRightsSection()
        {
            UmRightRightsSections = new HashSet<UmRightRightsSection>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("parentSectionId")]
        public int? ParentSectionId { get; set; }

        [InverseProperty(nameof(UmRightRightsSection.RightsSection))]
        public virtual ICollection<UmRightRightsSection> UmRightRightsSections { get; set; }
    }
}
