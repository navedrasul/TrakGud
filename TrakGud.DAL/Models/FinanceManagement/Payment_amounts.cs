using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Payment_amounts")]	public class Payment_amounts
	{
		public int id { get; set; }
		public float totalAmt { get; set; }
		public float? receivedAmt { get; set; }
		public bool? isComplete { get; set; }
		public DateTime? transactionTS { get; set; }

		public Payment_amounts() { }


		public Payment_amounts(int id, float totalAmt, float? receivedAmt = default, bool? isComplete = default, DateTime? transactionTS = default)		{
			this.id = id;
			this.totalAmt = totalAmt;
			this.receivedAmt = receivedAmt;
			this.isComplete = isComplete;
			this.transactionTS = transactionTS;
		}
	}
}