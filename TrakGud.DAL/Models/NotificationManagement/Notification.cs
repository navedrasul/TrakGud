using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
	public class Notification
	{
		public int id { get; set; }
		public string notificationSourceType { get; set; }
		public string body { get; set; }
		public string subject { get; set; }
		public bool? isRead { get; set; }
		public bool? isExpired { get; set; }
		public bool? isDeleted { get; set; }
		public int? deletorId { get; set; }
		public DateTime addTS { get; set; }
		public DateTime expTS { get; set; }

		public Notification(int id_, string notificationSourceType_, string body_, string subject_ = default, bool? isRead_ = default, bool? isExpired_ = default, bool? isDeleted_ = default, int? deletorId_ = default, DateTime addTS_ = default, DateTime expTS_ = default)		{
			this.id = id_;
			this.notificationSourceType = notificationSourceType_;
			this.body = body_;
			this.subject = subject_;
			this.isRead = isRead_;
			this.isExpired = isExpired_;
			this.isDeleted = isDeleted_;
			this.deletorId = deletorId_;
			this.addTS = addTS_;
			this.expTS = expTS_;
		}
	}
}