using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Payment_amounts
	{
		public int id { get; set; }
		public float totalAmt { get; set; }
		public float? receivedAmt { get; set; }
		public bool? isComplete { get; set; }
		public DateTime transactionTS { get; set; }

		public Payment_amounts(int id_, float totalAmt_, float? receivedAmt_ = default, bool? isComplete_ = default, DateTime transactionTS_ = default)		{
			this.id = id_;
			this.totalAmt = totalAmt_;
			this.receivedAmt = receivedAmt_;
			this.isComplete = isComplete_;
			this.transactionTS = transactionTS_;
		}
	}
}