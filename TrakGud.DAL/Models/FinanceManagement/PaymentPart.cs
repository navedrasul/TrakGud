using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class PaymentPart
	{
		public int id { get; set; }
		public int paymentPartTypeId { get; set; }
		public float totalAmt { get; set; }
		public bool? isComplete { get; set; }

		public PaymentPart(int id_, int paymentPartTypeId_, float totalAmt_, bool? isComplete_ = default)		{
			this.id = id_;
			this.paymentPartTypeId = paymentPartTypeId_;
			this.totalAmt = totalAmt_;
			this.isComplete = isComplete_;
		}
	}
}