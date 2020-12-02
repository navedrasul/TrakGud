using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class Employee_EmployeeGroup
	{
		public int employeeId { get; set; }
		public int employeeGroupId { get; set; }
		public string designationAtGroup { get; set; }
		public string designationDesc { get; set; }

		public Employee_EmployeeGroup(int employeeId_, int employeeGroupId_, string designationAtGroup_ = default, string designationDesc_ = default)		{
			this.employeeId = employeeId_;
			this.employeeGroupId = employeeGroupId_;
			this.designationAtGroup = designationAtGroup_;
			this.designationDesc = designationDesc_;
		}
	}
}