using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
[Table("nm__NotificationCategory_agr")]	public class NotificationCategory_agr
	{
		public int id { get; set; }
		public int? total { get; set; }
		public int? unread { get; set; }
		public int? expired { get; set; }
		public int? deleted { get; set; }

		public NotificationCategory_agr() { }


		public NotificationCategory_agr(int id, int? total = default, int? unread = default, int? expired = default, int? deleted = default)		{
			this.id = id;
			this.total = total;
			this.unread = unread;
			this.expired = expired;
			this.deleted = deleted;
		}
	}
}