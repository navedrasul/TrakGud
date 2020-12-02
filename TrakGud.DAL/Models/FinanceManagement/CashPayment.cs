using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class CashPayment: Payment
	{
		public float receivedAmt { get; set; }

		public CashPayment(int id_, string type_, float receivedAmt_): base(id_, type_)
		{
			this.receivedAmt = receivedAmt_;
		}
	}
}