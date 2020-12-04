using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
[Table("hrm__Employee")]	public class Employee
	{
		public int id { get; set; }
		public int contactId { get; set; }

		public Employee() { }


		public Employee(int id, int contactId)		{
			this.id = id;
			this.contactId = contactId;
		}
	}
}