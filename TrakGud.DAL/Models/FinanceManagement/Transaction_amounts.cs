using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Transaction_amounts
	{
		public int id { get; set; }
		public float? totalBeforeDiscount { get; set; }
		public float? discount { get; set; }
		public float? total { get; set; }

		public Transaction_amounts(int id_, float? totalBeforeDiscount_ = default, float? discount_ = default, float? total_ = default)		{
			this.id = id_;
			this.totalBeforeDiscount = totalBeforeDiscount_;
			this.discount = discount_;
			this.total = total_;
		}
	}
}