using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
[Table("nm__NotificationCategory")]	public class NotificationCategory
	{
		public int id { get; set; }
		public string name { get; set; }

		public NotificationCategory() { }


		public NotificationCategory(int id, string name)		{
			this.id = id;
			this.name = name;
		}
	}
}