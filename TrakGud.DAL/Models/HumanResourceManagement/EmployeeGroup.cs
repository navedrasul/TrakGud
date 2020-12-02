using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class EmployeeGroup
	{
		public int id { get; set; }
		public string name { get; set; }
		public string desc { get; set; }
		public int? parentGroupId { get; set; }

		public EmployeeGroup(int id_, string name_, string desc_ = default, int? parentGroupId_ = default)		{
			this.id = id_;
			this.name = name_;
			this.desc = desc_;
			this.parentGroupId = parentGroupId_;
		}
	}
}