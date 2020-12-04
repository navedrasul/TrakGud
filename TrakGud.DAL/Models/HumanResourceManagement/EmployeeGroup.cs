using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__EmployeeGroup")]	public class EmployeeGroup
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public int? parentGroupId { get; set; }

		public EmployeeGroup() { }


		public EmployeeGroup(int id, string name, string desc = default, int? parentGroupId = default)		{
			this.id = id;
			this.name = name;
			this.desc = desc;
			this.parentGroupId = parentGroupId;
		}
	}
}