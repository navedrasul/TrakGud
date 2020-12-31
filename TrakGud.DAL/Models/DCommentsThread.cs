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
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("isVisible")]
        public bool? IsVisible { get; set; }
        [Column("isBlocked")]
        public bool? IsBlocked { get; set; }
    }
}
