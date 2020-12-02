using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.NotificationManagement
{
	public class NotificationSourceType
	{
		public string value { get; set; }
		public string text { get; set; }

		public NotificationSourceType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}