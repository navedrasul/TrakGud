using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Payment
	{
		public int id { get; set; }
		public string type { get; set; }

		public Payment(int id_, string type_)		{
			this.id = id_;
			this.type = type_;
		}
	}
}