using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__Employee_EmployeeGroup")]	public class Employee_EmployeeGroup
	{
		public int employeeId { get; set; }
		public int employeeGroupId { get; set; }
		public string designationAtGroup { get; set; }
		public string designationDesc { get; set; }

		public Employee_EmployeeGroup() { }


		public Employee_EmployeeGroup(int employeeId, int employeeGroupId, string designationAtGroup = default, string designationDesc = default)		{
			this.employeeId = employeeId;
			this.employeeGroupId = employeeGroupId;
			this.designationAtGroup = designationAtGroup;
			this.designationDesc = designationDesc;
		}
	}
}