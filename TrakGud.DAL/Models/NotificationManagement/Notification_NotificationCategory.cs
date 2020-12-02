using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
	public class Notification_NotificationCategory
	{
		public int notificationId { get; set; }
		public int notificationCategoryId { get; set; }

		public Notification_NotificationCategory(int notificationId_, int notificationCategoryId_)		{
			this.notificationId = notificationId_;
			this.notificationCategoryId = notificationCategoryId_;
		}
	}
}