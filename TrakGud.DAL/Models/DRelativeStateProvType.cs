using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__RelativeStateProvType")]
    public partial class DRelativeStateProvType
    {
        public DRelativeStateProvType()
        {
            DBuyers = new HashSet<DBuyer>();
            DSellers = new HashSet<DSeller>();
            FimTransactions = new HashSet<FimTransaction>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(DBuyer.RstNavigation))]
        public virtual ICollection<DBuyer> DBuyers { get; set; }
        [InverseProperty(nameof(DSeller.RstNavigation))]
        public virtual ICollection<DSeller> DSellers { get; set; }
        [InverseProperty(nameof(FimTransaction.RstNavigation))]
        public virtual ICollection<FimTransaction> FimTransactions { get; set; }
    }
}
