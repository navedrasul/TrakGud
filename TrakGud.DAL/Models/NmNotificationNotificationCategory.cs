using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("nm__Notification_NotificationCategory")]
    public partial class NmNotificationNotificationCategory
    {
        [Key]
        [Column("notificationId")]
        public int NotificationId { get; set; }
        [Key]
        [Column("notificationCategoryId")]
        public int NotificationCategoryId { get; set; }
    }
}
