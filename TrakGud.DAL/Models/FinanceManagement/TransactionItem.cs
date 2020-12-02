using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class TransactionItem
	{
		public int id { get; set; }
		public int transactionId { get; set; }
		public int itemBatchId { get; set; }
		public float price { get; set; }
		public float qty { get; set; }
		public int unitId { get; set; }
		public float? discount { get; set; }

		public TransactionItem(int id_, int transactionId_, int itemBatchId_, float price_, float qty_, int unitId_, float? discount_ = default)		{
			this.id = id_;
			this.transactionId = transactionId_;
			this.itemBatchId = itemBatchId_;
			this.price = price_;
			this.qty = qty_;
			this.unitId = unitId_;
			this.discount = discount_;
		}
	}
}