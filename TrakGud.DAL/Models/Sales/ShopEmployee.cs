using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
[Table("s__ShopEmployee")]	public class ShopEmployee
	{
		public int id { get; set; }
		public string designationId { get; set; }
		public int employeeId { get; set; }

		public ShopEmployee() { }


		public ShopEmployee(int id, string designationId, int employeeId)		{
			this.id = id;
			this.designationId = designationId;
			this.employeeId = employeeId;
		}
	}
}