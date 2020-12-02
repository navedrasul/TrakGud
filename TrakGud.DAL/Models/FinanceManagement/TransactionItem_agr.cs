using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class TransactionItem_agr
	{
		public int id { get; set; }
		public float? total { get; set; }

		public TransactionItem_agr(int id_, float? total_ = default)		{
			this.id = id_;
			this.total = total_;
		}
	}
}