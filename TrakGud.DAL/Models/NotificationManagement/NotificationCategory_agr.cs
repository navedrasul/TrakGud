using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
	public class NotificationCategory_agr
	{
		public int id { get; set; }
		public int? total { get; set; }
		public int? unread { get; set; }
		public int? expired { get; set; }
		public int? deleted { get; set; }

		public NotificationCategory_agr(int id_, int? total_ = default, int? unread_ = default, int? expired_ = default, int? deleted_ = default)		{
			this.id = id_;
			this.total = total_;
			this.unread = unread_;
			this.expired = expired_;
			this.deleted = deleted_;
		}
	}
}