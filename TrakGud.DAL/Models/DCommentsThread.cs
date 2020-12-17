using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__CommentsThread")]
    public partial class DCommentsThread
    {
        public DCommentsThread()
        {
            DBuyers = new HashSet<DBuyer>();
            DComments = new HashSet<DComment>();
            DSellers = new HashSet<DSeller>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("isVisible")]
        public bool? IsVisible { get; set; }
        [Column("isBlocked")]
        public bool? IsBlocked { get; set; }

        [InverseProperty(nameof(DBuyer.CommentsThread))]
        public virtual ICollection<DBuyer> DBuyers { get; set; }
        [InverseProperty(nameof(DComment.CommentsThread))]
        public virtual ICollection<DComment> DComments { get; set; }
        [InverseProperty(nameof(DSeller.CommentsThread))]
        public virtual ICollection<DSeller> DSellers { get; set; }
    }
}
