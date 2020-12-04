using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__ChequePayment")]	public class ChequePayment: Payment
	{
		public bool? isBounced { get; set; }
		public int chequeId { get; set; }

		public ChequePayment() { }


		public ChequePayment(int chequeId, int id, string type, bool? isBounced = default): base(id, type)
		{
			this.isBounced = isBounced;
			this.chequeId = chequeId;
		}
	}
}