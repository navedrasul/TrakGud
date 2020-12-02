using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ContactFieldType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ContactFieldType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}