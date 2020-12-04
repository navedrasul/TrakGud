using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Fax: ContactField
	{
		public int cityId { get; set; }
		public string fax { get; set; }

		public Fax(int cityId_, string fax_, int id_, string fieldType_, int? contactId_ = default, string name_ = default): base(id_, fieldType_, contactId_, name_)
		{
			this.cityId = cityId_;
			this.fax = fax_;
		}
	}
}