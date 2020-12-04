using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__TransactionItem_agr")]	public class TransactionItem_agr
	{
		public int id { get; set; }
		public float? total { get; set; }

		public TransactionItem_agr() { }


		public TransactionItem_agr(int id, float? total = default)		{
			this.id = id;
			this.total = total;
		}
	}
}