using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TrakGud.DAL.Models
{
    [Table("nm__NotificationCategory")]
    public partial class NmNotificationCategory
    {
        public NmNotificationCategory()
        {
            NmNotificationNotificationCategories = new HashSet<NmNotificationNotificationCategory>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual NmNotificationCategoryAgr NmNotificationCategoryAgr { get; set; }
        [InverseProperty(nameof(NmNotificationNotificationCategory.NotificationCategory))]
        public virtual ICollection<NmNotificationNotificationCategory> NmNotificationNotificationCategories { get; set; }
    }
}
