using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Fax: ContactField
	{
		public int cityId { get; set; }
		public string fax { get; set; }

		public Fax(int id_, string fieldType_, int? contactId_ = default, string name_ = default, int cityId_, string fax_): base(id_, fieldType_, contactId_, name_)
		{
			this.cityId = cityId_;
			this.fax = fax_;
		}
	}
}