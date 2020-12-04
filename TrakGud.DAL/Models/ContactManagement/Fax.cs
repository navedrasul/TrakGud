using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__Fax")]	public class Fax: ContactField
	{
		public int cityId { get; set; }
		public string fax { get; set; }

		public Fax() { }


		public Fax(int cityId, string fax, int id, string fieldType, int? contactId = default, string name = default): base(id, fieldType, contactId, name)
		{
			this.cityId = cityId;
			this.fax = fax;
		}
	}
}