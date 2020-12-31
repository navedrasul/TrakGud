using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("d__Comment")]
    public partial class DComment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("commentsThreadId")]
        public int CommentsThreadId { get; set; }
        [Column("parentCommentId")]
        public int? ParentCommentId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime AddTs { get; set; }
        [Column("adderId")]
        public int AdderId { get; set; }
        [Column("modderId")]
        public int? ModderId { get; set; }
        [Column("isRemoved")]
        public bool? IsRemoved { get; set; }
        [Column("modTS", TypeName = "timestamp with time zone")]
        public DateTime? ModTs { get; set; }
        [Column("TS", TypeName = "timestamp with time zone")]
        public DateTime? Ts { get; set; }
    }
}
