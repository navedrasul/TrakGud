using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class Organisation
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public int? parentOrgId { get; set; }

		public Organisation(int id_, string name_, string desc_ = default, int? parentOrgId_ = default)		{
			this.id = id_;
			this.name = name_;
			this.desc = desc_;
			this.parentOrgId = parentOrgId_;
		}
	}
}