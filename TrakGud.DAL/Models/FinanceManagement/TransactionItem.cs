using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__TransactionItem")]	public class TransactionItem
	{
		public int id { get; set; }
		public int transactionId { get; set; }
		public int itemBatchId { get; set; }
		public float price { get; set; }
		public float qty { get; set; }
		public int unitId { get; set; }
		public float? discount { get; set; }

		public TransactionItem() { }


		public TransactionItem(int id, int transactionId, int itemBatchId, float price, float qty, int unitId, float? discount = default)		{
			this.id = id;
			this.transactionId = transactionId;
			this.itemBatchId = itemBatchId;
			this.price = price;
			this.qty = qty;
			this.unitId = unitId;
			this.discount = discount;
		}
	}
}