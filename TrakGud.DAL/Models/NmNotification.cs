using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("nm__Notification")]
    [Index(nameof(DeletorId), Name = "fki_deletorId_fkey")]
    [Index(nameof(NotificationSourceType), Name = "fki_notificationSourceType_fkey")]
    public partial class NmNotification
    {
        public NmNotification()
        {
            NmNotificationNotificationCategories = new HashSet<NmNotificationNotificationCategory>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("notificationSourceType")]
        [StringLength(25)]
        public string NotificationSourceType { get; set; }
        [Column("subject")]
        [StringLength(78)]
        public string Subject { get; set; }
        [Required]
        [Column("body")]
        public string Body { get; set; }
        [Column("isRead")]
        public bool? IsRead { get; set; }
        [Column("isExpired")]
        public bool? IsExpired { get; set; }
        [Column("isDeleted")]
        public bool? IsDeleted { get; set; }
        [Column("deletorId")]
        public int? DeletorId { get; set; }
        [Column("addTS", TypeName = "timestamp with time zone")]
        public DateTime? AddTs { get; set; }
        [Column("expTS", TypeName = "timestamp with time zone")]
        public DateTime? ExpTs { get; set; }
        [Column("sourceId")]
        public int? SourceId { get; set; }

        [ForeignKey(nameof(DeletorId))]
        [InverseProperty(nameof(UmUser.NmNotifications))]
        public virtual UmUser Deletor { get; set; }
        [ForeignKey(nameof(NotificationSourceType))]
        [InverseProperty(nameof(NmNotificationSourceType.NmNotifications))]
        public virtual NmNotificationSourceType NotificationSourceTypeNavigation { get; set; }
        [InverseProperty(nameof(NmNotificationNotificationCategory.Notification))]
        public virtual ICollection<NmNotificationNotificationCategory> NmNotificationNotificationCategories { get; set; }
    }
}
