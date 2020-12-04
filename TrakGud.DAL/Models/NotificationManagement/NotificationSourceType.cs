using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
[Table("nm__NotificationSourceType")]	public class NotificationSourceType
	{
		public string value { get; set; }
		public string text { get; set; }

		public NotificationSourceType() { }


		public NotificationSourceType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}