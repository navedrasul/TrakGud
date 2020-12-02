using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
	public class NotificationCategory
	{
		public int id { get; set; }
		public string name { get; set; }

		public NotificationCategory(int id_, string name_)		{
			this.id = id_;
			this.name = name_;
		}
	}
}