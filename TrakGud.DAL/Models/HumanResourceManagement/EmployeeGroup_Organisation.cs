using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__EmployeeGroup_Organisation")]	public class EmployeeGroup_Organisation
	{
		public int employeeGroupId { get; set; }
		public int organisationId { get; set; }

		public EmployeeGroup_Organisation() { }


		public EmployeeGroup_Organisation(int employeeGroupId, int organisationId)		{
			this.employeeGroupId = employeeGroupId;
			this.organisationId = organisationId;
		}
	}
}