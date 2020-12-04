using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__Organisation")]	public class Organisation
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public int? parentOrgId { get; set; }

		public Organisation() { }


		public Organisation(int id, string name, string desc = default, int? parentOrgId = default)		{
			this.id = id;
			this.name = name;
			this.desc = desc;
			this.parentOrgId = parentOrgId;
		}
	}
}