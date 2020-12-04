using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__PaymentPart")]	public class PaymentPart
	{
		public int id { get; set; }
		public int paymentPartTypeId { get; set; }
		public float totalAmt { get; set; }
		public bool? isComplete { get; set; }

		public PaymentPart() { }


		public PaymentPart(int id, int paymentPartTypeId, float totalAmt, bool? isComplete = default)		{
			this.id = id;
			this.paymentPartTypeId = paymentPartTypeId;
			this.totalAmt = totalAmt;
			this.isComplete = isComplete;
		}
	}
}