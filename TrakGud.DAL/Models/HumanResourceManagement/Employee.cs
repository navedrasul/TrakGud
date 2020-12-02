using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.HumanResourceManagement
{
	public class Employee
	{
		public int id { get; set; }
		public int contactId { get; set; }

		public Employee(int id_, int contactId_)		{
			this.id = id_;
			this.contactId = contactId_;
		}
	}
}