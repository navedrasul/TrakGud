using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__ContactFieldType")]
    public partial class CmContactFieldType
    {
        public CmContactFieldType()
        {
            CmContactFields = new HashSet<CmContactField>();
            CmEmails = new HashSet<CmEmail>();
            CmFaxes = new HashSet<CmFax>();
            CmPhones = new HashSet<CmPhone>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(CmContactField.FieldTypeNavigation))]
        public virtual ICollection<CmContactField> CmContactFields { get; set; }
        [InverseProperty(nameof(CmEmail.FieldTypeNavigation))]
        public virtual ICollection<CmEmail> CmEmails { get; set; }
        [InverseProperty(nameof(CmFax.FieldTypeNavigation))]
        public virtual ICollection<CmFax> CmFaxes { get; set; }
        [InverseProperty(nameof(CmPhone.FieldTypeNavigation))]
        public virtual ICollection<CmPhone> CmPhones { get; set; }
    }
}
