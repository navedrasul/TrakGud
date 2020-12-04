using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Payment")]	public class Payment
	{
		public int id { get; set; }
		public string type { get; set; }

		public Payment() { }


		public Payment(int id, string type)		{
			this.id = id;
			this.type = type;
		}
	}
}