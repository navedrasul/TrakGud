using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("nm__NotificationCategory_agr")]
    public partial class NmNotificationCategoryAgr
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("total")]
        public int? Total { get; set; }
        [Column("unread")]
        public int? Unread { get; set; }
        [Column("expired")]
        public int? Expired { get; set; }
        [Column("deleted")]
        public int? Deleted { get; set; }
    }
}
