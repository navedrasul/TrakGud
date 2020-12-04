using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__CreditPayment")]	public class CreditPayment: Payment
	{
		public float? receivedAmt { get; set; }
		public DateTime? dueDate { get; set; }

		public CreditPayment() { }


		public CreditPayment(int id, string type, float? receivedAmt = default, DateTime? dueDate = default): base(id, type)
		{
			this.receivedAmt = receivedAmt;
			this.dueDate = dueDate;
		}
	}
}