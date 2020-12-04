using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Transaction_amounts")]	public class Transaction_amounts
	{
		public int id { get; set; }
		public float? totalBeforeDiscount { get; set; }
		public float? discount { get; set; }
		public float? total { get; set; }

		public Transaction_amounts() { }


		public Transaction_amounts(int id, float? totalBeforeDiscount = default, float? discount = default, float? total = default)		{
			this.id = id;
			this.totalBeforeDiscount = totalBeforeDiscount;
			this.discount = discount;
			this.total = total;
		}
	}
}