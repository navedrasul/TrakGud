using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
[Table("nm__Notification_NotificationCategory")]	public class Notification_NotificationCategory
	{
		public int notificationId { get; set; }
		public int notificationCategoryId { get; set; }

		public Notification_NotificationCategory() { }


		public Notification_NotificationCategory(int notificationId, int notificationCategoryId)		{
			this.notificationId = notificationId;
			this.notificationCategoryId = notificationCategoryId;
		}
	}
}