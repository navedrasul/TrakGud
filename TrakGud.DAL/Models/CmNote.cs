using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("cm__Note")]
    public partial class CmNote
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("text")]
        public string Text { get; set; }

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(CmContact.CmNote))]
        public virtual CmContact IdNavigation { get; set; }
    }
}
