using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__SellerType")]
    public partial class DSellerType
    {
        public DSellerType()
        {
            DSellers = new HashSet<DSeller>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(DSeller.SellerTypeNavigation))]
        public virtual ICollection<DSeller> DSellers { get; set; }
    }
}
