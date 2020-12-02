using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ContactType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ContactType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}