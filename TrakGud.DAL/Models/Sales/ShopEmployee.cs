using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
	public class ShopEmployee
	{
		public int id { get; set; }
		public string designationId { get; set; }
		public int employeeId { get; set; }

		public ShopEmployee(int id_, string designationId_, int employeeId_)		{
			this.id = id_;
			this.designationId = designationId_;
			this.employeeId = employeeId_;
		}
	}
}