using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
[Table("nm__Notification")]	public class Notification
	{
		public int id { get; set; }
		public string notificationSourceType { get; set; }
		public string body { get; set; }
		public string subject { get; set; }
		public bool? isRead { get; set; }
		public bool? isExpired { get; set; }
		public bool? isDeleted { get; set; }
		public int? deletorId { get; set; }
		public DateTime? addTS { get; set; }
		public DateTime? expTS { get; set; }

		public Notification() { }


		public Notification(int id, string notificationSourceType, string body, string subject = default, bool? isRead = default, bool? isExpired = default, bool? isDeleted = default, int? deletorId = default, DateTime? addTS = default, DateTime? expTS = default)		{
			this.id = id;
			this.notificationSourceType = notificationSourceType;
			this.body = body;
			this.subject = subject;
			this.isRead = isRead;
			this.isExpired = isExpired;
			this.isDeleted = isDeleted;
			this.deletorId = deletorId;
			this.addTS = addTS;
			this.expTS = expTS;
		}
	}
}