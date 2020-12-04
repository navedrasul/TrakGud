using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ContactFieldType")]	public class ContactFieldType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ContactFieldType() { }


		public ContactFieldType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}