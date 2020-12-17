using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__BuyerType")]
    public partial class DBuyerType
    {
        public DBuyerType()
        {
            DBuyers = new HashSet<DBuyer>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(DBuyer.BuyerTypeNavigation))]
        public virtual ICollection<DBuyer> DBuyers { get; set; }
    }
}
