using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__CashPayment")]	public class CashPayment: Payment
	{
		public float receivedAmt { get; set; }

		public CashPayment() { }


		public CashPayment(float receivedAmt, int id, string type): base(id, type)
		{
			this.receivedAmt = receivedAmt;
		}
	}
}