using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__RelativeCountryType")]
    public partial class DRelativeCountryType
    {
        public DRelativeCountryType()
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

        [InverseProperty(nameof(DBuyer.RctNavigation))]
        public virtual ICollection<DBuyer> DBuyers { get; set; }
        [InverseProperty(nameof(DSeller.RctNavigation))]
        public virtual ICollection<DSeller> DSellers { get; set; }
        [InverseProperty(nameof(FimTransaction.RctNavigation))]
        public virtual ICollection<FimTransaction> FimTransactions { get; set; }
    }
}
