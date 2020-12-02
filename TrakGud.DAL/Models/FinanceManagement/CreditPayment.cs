using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class CreditPayment: Payment
	{
		public float? receivedAmt { get; set; }
		public DateTime dueDate { get; set; }

		public CreditPayment(int id_, string type_, float? receivedAmt_ = default, DateTime dueDate_ = default): base(id_, type_)
		{
			this.receivedAmt = receivedAmt_;
			this.dueDate = dueDate_;
		}
	}
}