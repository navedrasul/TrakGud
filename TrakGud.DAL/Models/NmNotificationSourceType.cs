using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("nm__NotificationSourceType")]
    public partial class NmNotificationSourceType
    {
        public NmNotificationSourceType()
        {
            NmNotifications = new HashSet<NmNotification>();
        }

        [Key]
        [Column("value")]
        [StringLength(25)]
        public string Value { get; set; }
        [Required]
        [Column("text")]
        [StringLength(25)]
        public string Text { get; set; }

        [InverseProperty(nameof(NmNotification.NotificationSourceTypeNavigation))]
        public virtual ICollection<NmNotification> NmNotifications { get; set; }
    }
}
